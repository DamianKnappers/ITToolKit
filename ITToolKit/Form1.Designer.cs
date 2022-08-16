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
            this.tvwButton.Location = new System.Drawing.Point(1189, 36);
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
            this.label1.Location = new System.Drawing.Point(1198, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "TeamViewer";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // generalProgressbar
            // 
            this.generalProgressbar.Location = new System.Drawing.Point(1114, 575);
            this.generalProgressbar.Name = "generalProgressbar";
            this.generalProgressbar.Size = new System.Drawing.Size(161, 23);
            this.generalProgressbar.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1111, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "CCleaner";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ccButton
            // 
            this.ccButton.Location = new System.Drawing.Point(1097, 36);
            this.ccButton.Name = "ccButton";
            this.ccButton.Size = new System.Drawing.Size(86, 23);
            this.ccButton.TabIndex = 4;
            this.ccButton.Text = "Installeer";
            this.ccButton.UseVisualStyleBackColor = true;
            this.ccButton.Click += new System.EventHandler(this.ccButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1287, 610);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ccButton);
            this.Controls.Add(this.generalProgressbar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tvwButton);
            this.Controls.Add(this.hd1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
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
    }
}

