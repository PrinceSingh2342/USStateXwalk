namespace USStateXwalk
{
    partial class USStateXwalk
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
            this.components = new System.ComponentModel.Container();
            this.ProcessXwalkCrawl = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.StateCDcomboBox = new System.Windows.Forms.ComboBox();
            this.DownloadXwalkPath = new System.Windows.Forms.TextBox();
            this.btnbrowsefolder = new System.Windows.Forms.Button();
            this.fdbbrowsefolder = new System.Windows.Forms.FolderBrowserDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // ProcessXwalkCrawl
            // 
            this.ProcessXwalkCrawl.Location = new System.Drawing.Point(426, 402);
            this.ProcessXwalkCrawl.Name = "ProcessXwalkCrawl";
            this.ProcessXwalkCrawl.Size = new System.Drawing.Size(329, 57);
            this.ProcessXwalkCrawl.TabIndex = 0;
            this.ProcessXwalkCrawl.Text = "Process Xwalk Crawl";
            this.ProcessXwalkCrawl.UseVisualStyleBackColor = true;
            this.ProcessXwalkCrawl.Click += new System.EventHandler(this.ProcessXwalkCrawl_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(157, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Statename";
            // 
            // StateCDcomboBox
            // 
            this.StateCDcomboBox.FormattingEnabled = true;
            this.StateCDcomboBox.Location = new System.Drawing.Point(982, 63);
            this.StateCDcomboBox.Name = "StateCDcomboBox";
            this.StateCDcomboBox.Size = new System.Drawing.Size(121, 28);
            this.StateCDcomboBox.TabIndex = 2;
            this.StateCDcomboBox.SelectedIndexChanged += new System.EventHandler(this.StateCDcomboBox_SelectedIndexChanged);
            // 
            // DownloadXwalkPath
            // 
            this.DownloadXwalkPath.Location = new System.Drawing.Point(348, 188);
            this.DownloadXwalkPath.Name = "DownloadXwalkPath";
            this.DownloadXwalkPath.Size = new System.Drawing.Size(475, 26);
            this.DownloadXwalkPath.TabIndex = 3;
            // 
            // btnbrowsefolder
            // 
            this.btnbrowsefolder.Location = new System.Drawing.Point(901, 191);
            this.btnbrowsefolder.Name = "btnbrowsefolder";
            this.btnbrowsefolder.Size = new System.Drawing.Size(154, 27);
            this.btnbrowsefolder.TabIndex = 4;
            this.btnbrowsefolder.Text = "Browse Folder";
            this.btnbrowsefolder.UseVisualStyleBackColor = true;
            // 
            // USStateXwalk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1249, 641);
            this.Controls.Add(this.btnbrowsefolder);
            this.Controls.Add(this.DownloadXwalkPath);
            this.Controls.Add(this.StateCDcomboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ProcessXwalkCrawl);
            this.Name = "USStateXwalk";
            this.Text = "USStateXwalk";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ProcessXwalkCrawl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox StateCDcomboBox;
        private System.Windows.Forms.TextBox DownloadXwalkPath;
        private System.Windows.Forms.Button btnbrowsefolder;
        private System.Windows.Forms.FolderBrowserDialog fdbbrowsefolder;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

