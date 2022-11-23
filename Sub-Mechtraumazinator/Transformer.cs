using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Xml.Linq;
using System.Xml.XPath;
// ReSharper disable LocalizableElement

namespace Sub_Mechtraumazinator

{
    internal static class Transformer
    {
        public static XDocument Transform(this XDocument sub, TransformerSettings settings)
        {
            // Set some counters to 0 for statistics when finished.
            int TransformedItems = 0,
                deletedWires = 0,
                adjustedContainerTags = 0;
            Console.WriteLine($"Transforming {sub.Root.Attribute("name").Value}...");
            if (settings.RenameSub)
            {
                sub.Root.Attribute("name").Value += "_Mechtrauma";
            }
            // Reversed so that deleted parent elements won't cause crashes when it should iterate over their children
            foreach (XElement xe in sub.Root.Descendants().Reverse())
            {
                string identifier = xe.Attribute("identifier") != null ? xe.Attribute("identifier").Value.Replace(" ", "") : "";
                string re;
                if (identifier != "")
                {
                    // Attempt to wreck an item based on its identifier
                    if (Data.Identifiers.ContainsKey(identifier))
                    {
                        // Wreck it
                        xe.SetAttributeValue("identifier", Data.Identifiers[identifier]);
                        if (!settings.PreserveColour)
                        {
                            // Reset its colour
                            xe.SetAttributeValue("spritecolor", null);
                            xe.SetAttributeValue("SpriteColor", "255,255,255,255");
                        }
                        TransformedItems++;
                    }
                    // Kill wiring components
                    // Kill wires
                    if (settings.DeleteWires && Data.Wires.Contains(identifier))
                    {
                        deletedWires++;
                        xe.Remove();
                        continue;
                    }

                }
                string tags = xe.Attribute("tags") != null && settings.ContainerTags ? xe.Attribute("tags").Value : "";
                if (tags != "")
                {
                    // Adjust tags on containers
                    foreach (KeyValuePair<string, string> kv in Data.ContainerTags)
                    {
                        re = $@"(?:(?<=,)|^){kv.Key}(?:(?=,)|$)";
                        if (!Regex.IsMatch(tags, re)) continue;
                        adjustedContainerTags++;
                        tags = Regex.Replace(tags, re, kv.Value, RegexOptions.IgnoreCase);
                    }
                    xe.SetAttributeValue("tags", tags);

                }

               
            }
            // Print out statistics
            Console.WriteLine($"Transformed {TransformedItems} items.");
            if (settings.DeleteWires) { Console.WriteLine($"Deleted {deletedWires} wires."); }
            if (settings.ContainerTags) { Console.WriteLine($"Adjusted {adjustedContainerTags} tags on containers."); }
            Console.WriteLine("...transformed.");
            return sub;
        }
    }
}
