using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Linq;

namespace Sub_Mechtraumazinator
{
    internal static class Data
    {
        static Data()
        {
            
            ContainerTags = XElement
                            .Parse(File.ReadAllText("Resources/ContainerTags.xml"))
                            .Elements()
                            .ToDictionary(k => k.Name.ToString(), v => v.Value.ToString());
            
            Identifiers = XElement
                          .Parse(File.ReadAllText("Resources/Identifiers.xml"))
                          .Elements()
                          .ToDictionary(k => k.Name.ToString(), v => v.Value.ToString());
            
            Wires = XElement
                    .Parse(File.ReadAllText("Resources/Wires.xml"))
                    .Descendants()
                    .Select(elt => elt.Name.ToString())
                    .ToList();
            
        }

        public static Dictionary<string, string> ContainerTags { get; }
        public static Dictionary<string, string> Identifiers { get; }
        public static List<string> Wires { get; }
    }
}
