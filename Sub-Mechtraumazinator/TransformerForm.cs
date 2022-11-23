using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;
using BaroLib;
// ReSharper disable LocalizableElement

namespace Sub_Mechtraumazinator
{
    public partial class TransformerForm : Form
    {
        private readonly string defaultOpenLocation = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86), "Steam", "steamapps", "common", "Barotrauma");
        private IEnumerable<string> subFilePaths;
        public TransformerForm()
        {
            InitializeComponent();
            ContainerTagsCheckBox.Checked = (bool)Properties.Settings.Default["ContainerTags"];
            DeleteWiresCheckBox.Checked = (bool)Properties.Settings.Default["DeleteWires"];
            InplaceCheckBox.Checked = (bool)Properties.Settings.Default["Inplace"];
            PreserveColourCheckBox.Checked = (bool)Properties.Settings.Default["PreserveColour"];
            RenameCheckBox.Checked = (bool)Properties.Settings.Default["RenameSub"];
            Console.SetOut(new MultiTextWriter(new ControlWriter(OutputBox), Console.Out));
            Console.Out.NewLine = "\n";
        }

        private void BrowseButton_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog()
                         {
                             InitialDirectory = defaultOpenLocation,

                             Multiselect = true,
                         };

            if (dialog.ShowDialog() != DialogResult.OK) return;
            subFilePaths = dialog.FileNames.ToList();
            int length = subFilePaths.Count();
            string filePathBox;
            if (length > 1)
            {
                filePathBox = "";
                for (var i = 0; i < length; i++)
                {
                    filePathBox += $"\"{subFilePaths.ElementAt(i)}\"";
                    if (i + 1 != length)
                    {
                        filePathBox += ",";
                    }
                }
            }
            else
            {
                filePathBox = subFilePaths.ElementAt(0);
            }
            FilePathBox.Text = filePathBox;
        }

        private void TransformerButton_Click(object sender, EventArgs e)
        {
            var settings = new TransformerSettings(
                                               ContainerTagsCheckBox.Checked,
                                               DeleteWiresCheckBox.Checked,
                                               InplaceCheckBox.Checked,
                                               PreserveColourCheckBox.Checked,
                                               RenameCheckBox.Checked);
            foreach (string fileName in subFilePaths)
            {
                string extension = Path.GetExtension(fileName);
                if (extension != ".sub")
                {
                    Console.WriteLine($"File {fileName} has an unsupported extension, skipping.");
                    continue;
                }
                Console.WriteLine($"Loading {fileName}...");
                XDocument sub = IoUtil.LoadSub(fileName);
                Console.WriteLine("...loaded.");
                XDocument TransformedSub = sub.Transform(settings);
                string outFileName = InplaceCheckBox.Checked ? fileName : Path.Combine(Path.GetDirectoryName(fileName) ?? "",
                                         $"{Path.GetFileNameWithoutExtension(fileName)}_Mechtrauma.sub");
                Console.WriteLine($"Saving to {outFileName}...");
                TransformedSub.SaveSub(outFileName);
                Console.WriteLine("...saved.");
            }
        }

        private void TransformerForm_Load(object sender, EventArgs e)
        {

        }

        private void SpawnpointComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void OutputBox_TextChanged(object sender, EventArgs e)
        {
            OutputBox.SelectionStart = OutputBox.Text.Length;
            OutputBox.ScrollToCaret();
        }

        private void ContainerTagsCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void DeleteWiresCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void PreserveColourCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}

