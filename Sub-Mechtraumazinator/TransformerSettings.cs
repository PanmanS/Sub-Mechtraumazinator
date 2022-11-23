namespace Sub_Mechtraumazinator
{
    internal readonly struct TransformerSettings
    {
        public bool ContainerTags { get; }
        public bool DeleteWires { get; }
        public bool Inplace { get; }
        public bool PreserveColour { get; }
        public bool RenameSub { get; }

        public TransformerSettings(
            bool containerTags,
            bool deleteWires,
            bool inplace,
            bool preserveColour,
            bool renameSub)
        {
            ContainerTags = containerTags;
            DeleteWires = deleteWires;
            Inplace = inplace;
            PreserveColour = preserveColour;
            RenameSub = renameSub;
            SaveDefaultSettings(this);
        }

        private static void SaveDefaultSettings(TransformerSettings settings)
        {
            Properties.Settings.Default["ContainerTags"] = settings.ContainerTags;
            Properties.Settings.Default["DeleteWires"] = settings.DeleteWires;
            Properties.Settings.Default["Inplace"] = settings.Inplace;
            Properties.Settings.Default["PreserveColour"] = settings.PreserveColour;
            Properties.Settings.Default["RenameSub"] = settings.RenameSub;
            Properties.Settings.Default.Save();
        }
    }
}
