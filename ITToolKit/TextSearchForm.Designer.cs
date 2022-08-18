namespace ITToolKit
{
    partial class TextSearchForm
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
            this.searchStringsInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.resultListBox = new System.Windows.Forms.ListBox();
            this.openFileButton = new System.Windows.Forms.Button();
            this.selectDriveComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.findFilesProgress = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // searchStringsInput
            // 
            this.searchStringsInput.Location = new System.Drawing.Point(334, 28);
            this.searchStringsInput.Name = "searchStringsInput";
            this.searchStringsInput.Size = new System.Drawing.Size(204, 20);
            this.searchStringsInput.TabIndex = 0;
            this.searchStringsInput.TextChanged += new System.EventHandler(this.searchStringInput_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(331, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fill in the string your looking for in a text file";
            // 
            // searchButton
            // 
            this.searchButton.Enabled = false;
            this.searchButton.Location = new System.Drawing.Point(109, 311);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(204, 42);
            this.searchButton.TabIndex = 2;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // resultListBox
            // 
            this.resultListBox.FormattingEnabled = true;
            this.resultListBox.Location = new System.Drawing.Point(109, 54);
            this.resultListBox.Name = "resultListBox";
            this.resultListBox.Size = new System.Drawing.Size(657, 251);
            this.resultListBox.TabIndex = 3;
            this.resultListBox.SelectedIndexChanged += new System.EventHandler(this.resultListBox_SelectedIndexChanged);
            // 
            // openFileButton
            // 
            this.openFileButton.Enabled = false;
            this.openFileButton.Location = new System.Drawing.Point(772, 83);
            this.openFileButton.Name = "openFileButton";
            this.openFileButton.Size = new System.Drawing.Size(75, 23);
            this.openFileButton.TabIndex = 4;
            this.openFileButton.Text = "Open File";
            this.openFileButton.UseVisualStyleBackColor = true;
            this.openFileButton.Click += new System.EventHandler(this.openFileButton_Click);
            // 
            // selectDriveComboBox
            // 
            this.selectDriveComboBox.FormattingEnabled = true;
            this.selectDriveComboBox.Location = new System.Drawing.Point(772, 181);
            this.selectDriveComboBox.Name = "selectDriveComboBox";
            this.selectDriveComboBox.Size = new System.Drawing.Size(74, 21);
            this.selectDriveComboBox.TabIndex = 5;
            this.selectDriveComboBox.SelectedIndexChanged += new System.EventHandler(this.selectDriveComboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(789, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Drive";
            // 
            // findFilesProgress
            // 
            this.findFilesProgress.Location = new System.Drawing.Point(772, 330);
            this.findFilesProgress.Name = "findFilesProgress";
            this.findFilesProgress.Size = new System.Drawing.Size(141, 23);
            this.findFilesProgress.TabIndex = 7;
            // 
            // TextSearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 365);
            this.Controls.Add(this.findFilesProgress);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.selectDriveComboBox);
            this.Controls.Add(this.openFileButton);
            this.Controls.Add(this.resultListBox);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchStringsInput);
            this.Name = "TextSearchForm";
            this.Text = "TextSearchForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox searchStringsInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.ListBox resultListBox;
        private System.Windows.Forms.Button openFileButton;
        private System.Windows.Forms.ComboBox selectDriveComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar findFilesProgress;
    }
}