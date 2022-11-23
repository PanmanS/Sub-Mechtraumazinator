namespace Sub_Mechtraumazinator
{
    partial class TransformerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransformerForm));
            this.BrowseButton = new System.Windows.Forms.Button();
            this.OutputBox = new System.Windows.Forms.RichTextBox();
            this.FilePathBox = new System.Windows.Forms.TextBox();
            this.TransformerButton = new System.Windows.Forms.Button();
            this.PreserveColourCheckBox = new System.Windows.Forms.CheckBox();
            this.ContainerTagsCheckBox = new System.Windows.Forms.CheckBox();
            this.InplaceCheckBox = new System.Windows.Forms.CheckBox();
            this.DeleteWiresCheckBox = new System.Windows.Forms.CheckBox();
            this.RenameCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // BrowseButton
            // 
            this.BrowseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BrowseButton.Location = new System.Drawing.Point(276, 10);
            this.BrowseButton.Margin = new System.Windows.Forms.Padding(2);
            this.BrowseButton.Name = "BrowseButton";
            this.BrowseButton.Size = new System.Drawing.Size(116, 31);
            this.BrowseButton.TabIndex = 0;
            this.BrowseButton.Text = "Browse";
            this.BrowseButton.UseVisualStyleBackColor = true;
            this.BrowseButton.Click += new System.EventHandler(this.BrowseButton_Click);
            // 
            // OutputBox
            // 
            this.OutputBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OutputBox.Location = new System.Drawing.Point(9, 46);
            this.OutputBox.Margin = new System.Windows.Forms.Padding(2);
            this.OutputBox.Name = "OutputBox";
            this.OutputBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.OutputBox.Size = new System.Drawing.Size(384, 292);
            this.OutputBox.TabIndex = 1;
            this.OutputBox.Text = "";
            this.OutputBox.TextChanged += new System.EventHandler(this.OutputBox_TextChanged);
            // 
            // FilePathBox
            // 
            this.FilePathBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FilePathBox.Location = new System.Drawing.Point(9, 16);
            this.FilePathBox.Margin = new System.Windows.Forms.Padding(2);
            this.FilePathBox.Name = "FilePathBox";
            this.FilePathBox.Size = new System.Drawing.Size(264, 20);
            this.FilePathBox.TabIndex = 2;
            // 
            // Transformer
            // 
            this.TransformerButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TransformerButton.Location = new System.Drawing.Point(397, 10);
            this.TransformerButton.Margin = new System.Windows.Forms.Padding(2);
            this.TransformerButton.Name = "TransformerButton";
            this.TransformerButton.Size = new System.Drawing.Size(234, 31);
            this.TransformerButton.TabIndex = 3;
            this.TransformerButton.Text = "Transform";
            this.TransformerButton.UseVisualStyleBackColor = true;
            this.TransformerButton.Click += new System.EventHandler(this.TransformerButton_Click);
            // 
            // PreserveColourCheckBox
            // 
            this.PreserveColourCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PreserveColourCheckBox.AutoSize = true;
            this.PreserveColourCheckBox.Checked = true;
            this.PreserveColourCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.PreserveColourCheckBox.Location = new System.Drawing.Point(394, 97);
            this.PreserveColourCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.PreserveColourCheckBox.Name = "PreserveColourCheckBox";
            this.PreserveColourCheckBox.Size = new System.Drawing.Size(133, 17);
            this.PreserveColourCheckBox.TabIndex = 4;
            this.PreserveColourCheckBox.Text = "Preserve sprite colours";
            this.PreserveColourCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.PreserveColourCheckBox.UseVisualStyleBackColor = true;
            this.PreserveColourCheckBox.CheckedChanged += new System.EventHandler(this.PreserveColourCheckBox_CheckedChanged);
            // 
            // ContainerTagsCheckBox
            // 
            this.ContainerTagsCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ContainerTagsCheckBox.AutoSize = true;
            this.ContainerTagsCheckBox.Checked = true;
            this.ContainerTagsCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ContainerTagsCheckBox.Location = new System.Drawing.Point(394, 122);
            this.ContainerTagsCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.ContainerTagsCheckBox.Name = "ContainerTagsCheckBox";
            this.ContainerTagsCheckBox.Size = new System.Drawing.Size(248, 17);
            this.ContainerTagsCheckBox.TabIndex = 5;
            this.ContainerTagsCheckBox.Text = "Change container tags to mechtrauma versions";
            this.ContainerTagsCheckBox.UseVisualStyleBackColor = true;
            this.ContainerTagsCheckBox.CheckedChanged += new System.EventHandler(this.ContainerTagsCheckBox_CheckedChanged);
            // 
            // InplaceCheckBox
            // 
            this.InplaceCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.InplaceCheckBox.AutoSize = true;
            this.InplaceCheckBox.Location = new System.Drawing.Point(394, 48);
            this.InplaceCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.InplaceCheckBox.Name = "InplaceCheckBox";
            this.InplaceCheckBox.Size = new System.Drawing.Size(158, 17);
            this.InplaceCheckBox.TabIndex = 7;
            this.InplaceCheckBox.Text = "Mechtrauma sub file inplace";
            this.InplaceCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.InplaceCheckBox.UseVisualStyleBackColor = true;
            // 
            // DeleteWiresCheckBox
            // 
            this.DeleteWiresCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteWiresCheckBox.AutoSize = true;
            this.DeleteWiresCheckBox.Location = new System.Drawing.Point(394, 148);
            this.DeleteWiresCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.DeleteWiresCheckBox.Name = "DeleteWiresCheckBox";
            this.DeleteWiresCheckBox.Size = new System.Drawing.Size(84, 17);
            this.DeleteWiresCheckBox.TabIndex = 8;
            this.DeleteWiresCheckBox.Text = "Delete wires";
            this.DeleteWiresCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DeleteWiresCheckBox.UseVisualStyleBackColor = true;
            this.DeleteWiresCheckBox.CheckedChanged += new System.EventHandler(this.DeleteWiresCheckBox_CheckedChanged);
            // 
            // RenameCheckBox
            // 
            this.RenameCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RenameCheckBox.AutoSize = true;
            this.RenameCheckBox.Checked = true;
            this.RenameCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.RenameCheckBox.Location = new System.Drawing.Point(394, 72);
            this.RenameCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.RenameCheckBox.Name = "RenameCheckBox";
            this.RenameCheckBox.Size = new System.Drawing.Size(86, 17);
            this.RenameCheckBox.TabIndex = 11;
            this.RenameCheckBox.Text = "Rename sub";
            this.RenameCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RenameCheckBox.UseVisualStyleBackColor = true;
            // 
            // TransformerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 344);
            this.Controls.Add(this.ContainerTagsCheckBox);
            this.Controls.Add(this.RenameCheckBox);
            this.Controls.Add(this.DeleteWiresCheckBox);
            this.Controls.Add(this.InplaceCheckBox);
            this.Controls.Add(this.PreserveColourCheckBox);
            this.Controls.Add(this.TransformerButton);
            this.Controls.Add(this.FilePathBox);
            this.Controls.Add(this.OutputBox);
            this.Controls.Add(this.BrowseButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(657, 376);
            this.Name = "TransformerForm";
            this.Text = "Sub Mechtraumizer";
            this.Load += new System.EventHandler(this.TransformerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BrowseButton;
        private System.Windows.Forms.RichTextBox OutputBox;
        private System.Windows.Forms.TextBox FilePathBox;
        private System.Windows.Forms.Button TransformerButton;
        private System.Windows.Forms.CheckBox PreserveColourCheckBox;
        private System.Windows.Forms.CheckBox ContainerTagsCheckBox;
        private System.Windows.Forms.CheckBox InplaceCheckBox;
        private System.Windows.Forms.CheckBox DeleteWiresCheckBox;
        private System.Windows.Forms.CheckBox RenameCheckBox;
    }
}

