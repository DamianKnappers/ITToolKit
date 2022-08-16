namespace ITToolKit
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.hd1 = new System.Windows.Forms.Label();
            this.tvwButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.generalProgressbar = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.ccButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.adwButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // hd1
            // 
            this.hd1.AutoSize = true;
            this.hd1.Location = new System.Drawing.Point(-4, 62);
            this.hd1.Name = "hd1";
            this.hd1.Size = new System.Drawing.Size(2647, 13);
            this.hd1.TabIndex = 0;
            this.hd1.Text = resources.GetString("hd1.Text");
            // 
            // tvwButton
            // 
            this.tvwButton.AutoSize = true;
            this.tvwButton.Location = new System.Drawing.Point(270, 31);
            this.tvwButton.Name = "tvwButton";
            this.tvwButton.Size = new System.Drawing.Size(86, 23);
            this.tvwButton.TabIndex = 1;
            this.tvwButton.Text = "Installeer";
            this.tvwButton.UseVisualStyleBackColor = true;
            this.tvwButton.Click += new System.EventHandler(this.tvwButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(277, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "TeamViewer";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // generalProgressbar
            // 
            this.generalProgressbar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.generalProgressbar.Location = new System.Drawing.Point(1114, 575);
            this.generalProgressbar.Name = "generalProgressbar";
            this.generalProgressbar.Size = new System.Drawing.Size(161, 23);
            this.generalProgressbar.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(190, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "CCleaner";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ccButton
            // 
            this.ccButton.AutoSize = true;
            this.ccButton.Location = new System.Drawing.Point(178, 31);
            this.ccButton.Name = "ccButton";
            this.ccButton.Size = new System.Drawing.Size(86, 23);
            this.ccButton.TabIndex = 4;
            this.ccButton.Text = "Installeer";
            this.ccButton.UseVisualStyleBackColor = true;
            this.ccButton.Click += new System.EventHandler(this.ccButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(93, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Anti Adware";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // adwButton
            // 
            this.adwButton.AutoSize = true;
            this.adwButton.Location = new System.Drawing.Point(86, 31);
            this.adwButton.Name = "adwButton";
            this.adwButton.Size = new System.Drawing.Size(86, 23);
            this.adwButton.TabIndex = 6;
            this.adwButton.Text = "Installeer";
            this.adwButton.UseVisualStyleBackColor = true;
            this.adwButton.Click += new System.EventHandler(this.adwButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.adwButton);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tvwButton);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.ccButton);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(912, 1);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(1);
            this.groupBox1.Size = new System.Drawing.Size(365, 60);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.ClientSize = new System.Drawing.Size(1287, 610);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.generalProgressbar);
            this.Controls.Add(this.hd1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "IT Toolkit";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label hd1;
        private System.Windows.Forms.Button tvwButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar generalProgressbar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ccButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button adwButton;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

