namespace Crypter
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.textPath3 = new System.Windows.Forms.TextBox();
            this.textPath2 = new System.Windows.Forms.TextBox();
            this.textPath1 = new System.Windows.Forms.TextBox();
            this.buttonPath3 = new System.Windows.Forms.Button();
            this.buttonPath2 = new System.Windows.Forms.Button();
            this.buttonPath1 = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.buttonStart = new System.Windows.Forms.Button();
            this.textName1 = new System.Windows.Forms.TextBox();
            this.textName2 = new System.Windows.Forms.TextBox();
            this.textName3 = new System.Windows.Forms.TextBox();
            this.toolTipDescriptions = new System.Windows.Forms.ToolTip(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonStop = new System.Windows.Forms.Button();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemOrigin = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemKey = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemCrypte = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemTools = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemReset = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparatorTools1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItemMode = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemEncryption = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemDecryption = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparatorTools2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItemStart = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemStop = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparatorTools3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItemOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.labelPercent = new System.Windows.Forms.Label();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // textPath3
            // 
            this.textPath3.AccessibleDescription = "";
            this.textPath3.AccessibleName = "";
            this.textPath3.Location = new System.Drawing.Point(12, 118);
            this.textPath3.Name = "textPath3";
            this.textPath3.Size = new System.Drawing.Size(265, 20);
            this.textPath3.TabIndex = 10;
            this.toolTipDescriptions.SetToolTip(this.textPath3, "Path to Crypte file");
            // 
            // textPath2
            // 
            this.textPath2.Location = new System.Drawing.Point(12, 79);
            this.textPath2.Name = "textPath2";
            this.textPath2.Size = new System.Drawing.Size(265, 20);
            this.textPath2.TabIndex = 7;
            this.toolTipDescriptions.SetToolTip(this.textPath2, "Path to Key file");
            // 
            // textPath1
            // 
            this.textPath1.Location = new System.Drawing.Point(12, 40);
            this.textPath1.Name = "textPath1";
            this.textPath1.Size = new System.Drawing.Size(265, 20);
            this.textPath1.TabIndex = 4;
            this.toolTipDescriptions.SetToolTip(this.textPath1, "Path to Origin file");
            // 
            // buttonPath3
            // 
            this.buttonPath3.Location = new System.Drawing.Point(390, 116);
            this.buttonPath3.Name = "buttonPath3";
            this.buttonPath3.Size = new System.Drawing.Size(75, 23);
            this.buttonPath3.TabIndex = 12;
            this.buttonPath3.Text = "Browse...";
            this.buttonPath3.UseVisualStyleBackColor = true;
            this.buttonPath3.Click += new System.EventHandler(this.buttonPath3_Click_1);
            // 
            // buttonPath2
            // 
            this.buttonPath2.Location = new System.Drawing.Point(390, 77);
            this.buttonPath2.Name = "buttonPath2";
            this.buttonPath2.Size = new System.Drawing.Size(75, 23);
            this.buttonPath2.TabIndex = 9;
            this.buttonPath2.Text = "Browse...";
            this.buttonPath2.UseVisualStyleBackColor = true;
            this.buttonPath2.Click += new System.EventHandler(this.buttonPath2_Click_1);
            // 
            // buttonPath1
            // 
            this.buttonPath1.Location = new System.Drawing.Point(390, 38);
            this.buttonPath1.Name = "buttonPath1";
            this.buttonPath1.Size = new System.Drawing.Size(75, 23);
            this.buttonPath1.TabIndex = 6;
            this.buttonPath1.Text = "Browse...";
            this.buttonPath1.UseVisualStyleBackColor = true;
            this.buttonPath1.Click += new System.EventHandler(this.buttonPath1_Click_1);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(230, 145);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(235, 23);
            this.progressBar.Step = 1;
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar.TabIndex = 17;
            // 
            // buttonStart
            // 
            this.buttonStart.AccessibleDescription = "";
            this.buttonStart.Location = new System.Drawing.Point(12, 145);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonStart.Size = new System.Drawing.Size(82, 23);
            this.buttonStart.TabIndex = 13;
            this.buttonStart.Text = "Start";
            this.toolTipDescriptions.SetToolTip(this.buttonStart, "22");
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // textName1
            // 
            this.textName1.AccessibleDescription = "";
            this.textName1.Enabled = false;
            this.textName1.Location = new System.Drawing.Point(283, 40);
            this.textName1.Name = "textName1";
            this.textName1.Size = new System.Drawing.Size(101, 20);
            this.textName1.TabIndex = 5;
            this.toolTipDescriptions.SetToolTip(this.textName1, "Name of Origin file");
            // 
            // textName2
            // 
            this.textName2.Location = new System.Drawing.Point(283, 79);
            this.textName2.Name = "textName2";
            this.textName2.Size = new System.Drawing.Size(101, 20);
            this.textName2.TabIndex = 8;
            this.toolTipDescriptions.SetToolTip(this.textName2, "Name of Key file");
            // 
            // textName3
            // 
            this.textName3.AccessibleDescription = "";
            this.textName3.AccessibleName = "";
            this.textName3.Location = new System.Drawing.Point(283, 118);
            this.textName3.Name = "textName3";
            this.textName3.Size = new System.Drawing.Size(101, 20);
            this.textName3.TabIndex = 11;
            this.textName3.Tag = "";
            this.toolTipDescriptions.SetToolTip(this.textName3, "Name of Crypte file");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Path to origin file";
            this.toolTipDescriptions.SetToolTip(this.label2, "Attributes of Origin file");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Path to key file";
            this.toolTipDescriptions.SetToolTip(this.label3, "Attributes of Key file");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Path to crypte file";
            this.toolTipDescriptions.SetToolTip(this.label4, "Attributes of Crypte file");
            // 
            // buttonStop
            // 
            this.buttonStop.Enabled = false;
            this.buttonStop.Location = new System.Drawing.Point(100, 145);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(82, 23);
            this.buttonStop.TabIndex = 21;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemFile,
            this.toolStripMenuItemTools});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(595, 24);
            this.menuStrip.TabIndex = 22;
            this.menuStrip.Text = "menuStrip1";
            // 
            // toolStripMenuItemFile
            // 
            this.toolStripMenuItemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemOpen});
            this.toolStripMenuItemFile.Name = "toolStripMenuItemFile";
            this.toolStripMenuItemFile.Size = new System.Drawing.Size(37, 20);
            this.toolStripMenuItemFile.Text = "File";
            // 
            // toolStripMenuItemOpen
            // 
            this.toolStripMenuItemOpen.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemOrigin,
            this.toolStripMenuItemKey,
            this.toolStripMenuItemCrypte});
            this.toolStripMenuItemOpen.Name = "toolStripMenuItemOpen";
            this.toolStripMenuItemOpen.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItemOpen.Text = "Open";
            // 
            // toolStripMenuItemOrigin
            // 
            this.toolStripMenuItemOrigin.Name = "toolStripMenuItemOrigin";
            this.toolStripMenuItemOrigin.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItemOrigin.Text = "Origin file/directory";
            this.toolStripMenuItemOrigin.Click += new System.EventHandler(this.toolStripMenuItemOrigin_Click);
            // 
            // toolStripMenuItemKey
            // 
            this.toolStripMenuItemKey.Name = "toolStripMenuItemKey";
            this.toolStripMenuItemKey.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItemKey.Text = "Key file/directory";
            this.toolStripMenuItemKey.Click += new System.EventHandler(this.toolStripMenuItemKey_Click);
            // 
            // toolStripMenuItemCrypte
            // 
            this.toolStripMenuItemCrypte.Name = "toolStripMenuItemCrypte";
            this.toolStripMenuItemCrypte.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItemCrypte.Text = "Crypte file/directory";
            this.toolStripMenuItemCrypte.Click += new System.EventHandler(this.toolStripMenuItemCrypte_Click);
            // 
            // toolStripMenuItemTools
            // 
            this.toolStripMenuItemTools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemReset,
            this.toolStripSeparatorTools1,
            this.toolStripMenuItemMode,
            this.toolStripSeparatorTools2,
            this.toolStripMenuItemStart,
            this.toolStripMenuItemStop,
            this.toolStripSeparatorTools3,
            this.toolStripMenuItemOptions});
            this.toolStripMenuItemTools.Name = "toolStripMenuItemTools";
            this.toolStripMenuItemTools.Size = new System.Drawing.Size(46, 20);
            this.toolStripMenuItemTools.Text = "Tools";
            // 
            // toolStripMenuItemReset
            // 
            this.toolStripMenuItemReset.Name = "toolStripMenuItemReset";
            this.toolStripMenuItemReset.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItemReset.Text = "Reset";
            this.toolStripMenuItemReset.Click += new System.EventHandler(this.toolStripMenuItemGenerateCode_Click);
            // 
            // toolStripSeparatorTools1
            // 
            this.toolStripSeparatorTools1.Name = "toolStripSeparatorTools1";
            this.toolStripSeparatorTools1.Size = new System.Drawing.Size(177, 6);
            // 
            // toolStripMenuItemMode
            // 
            this.toolStripMenuItemMode.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemEncryption,
            this.toolStripMenuItemDecryption});
            this.toolStripMenuItemMode.Name = "toolStripMenuItemMode";
            this.toolStripMenuItemMode.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItemMode.Text = "Mode";
            // 
            // toolStripMenuItemEncryption
            // 
            this.toolStripMenuItemEncryption.Name = "toolStripMenuItemEncryption";
            this.toolStripMenuItemEncryption.Size = new System.Drawing.Size(132, 22);
            this.toolStripMenuItemEncryption.Text = "Encryption";
            this.toolStripMenuItemEncryption.Click += new System.EventHandler(this.toolStripMenuItemEncryption_Click);
            // 
            // toolStripMenuItemDecryption
            // 
            this.toolStripMenuItemDecryption.Name = "toolStripMenuItemDecryption";
            this.toolStripMenuItemDecryption.Size = new System.Drawing.Size(132, 22);
            this.toolStripMenuItemDecryption.Text = "Decryption";
            this.toolStripMenuItemDecryption.Click += new System.EventHandler(this.toolStripMenuItemDecryption_Click);
            // 
            // toolStripSeparatorTools2
            // 
            this.toolStripSeparatorTools2.Name = "toolStripSeparatorTools2";
            this.toolStripSeparatorTools2.Size = new System.Drawing.Size(177, 6);
            // 
            // toolStripMenuItemStart
            // 
            this.toolStripMenuItemStart.Name = "toolStripMenuItemStart";
            this.toolStripMenuItemStart.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItemStart.Text = "Start";
            this.toolStripMenuItemStart.Click += new System.EventHandler(this.toolStripMenuItemStart_Click);
            // 
            // toolStripMenuItemStop
            // 
            this.toolStripMenuItemStop.Enabled = false;
            this.toolStripMenuItemStop.Name = "toolStripMenuItemStop";
            this.toolStripMenuItemStop.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItemStop.Text = "Stop";
            this.toolStripMenuItemStop.Click += new System.EventHandler(this.toolStripMenuItemStop_Click);
            // 
            // toolStripSeparatorTools3
            // 
            this.toolStripSeparatorTools3.Name = "toolStripSeparatorTools3";
            this.toolStripSeparatorTools3.Size = new System.Drawing.Size(177, 6);
            // 
            // toolStripMenuItemOptions
            // 
            this.toolStripMenuItemOptions.Name = "toolStripMenuItemOptions";
            this.toolStripMenuItemOptions.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItemOptions.Text = "Options";
            this.toolStripMenuItemOptions.Click += new System.EventHandler(this.toolStripMenuItemOptions_Click);
            // 
            // labelPercent
            // 
            this.labelPercent.BackColor = System.Drawing.Color.Transparent;
            this.labelPercent.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelPercent.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPercent.Location = new System.Drawing.Point(188, 149);
            this.labelPercent.Name = "labelPercent";
            this.labelPercent.Size = new System.Drawing.Size(36, 16);
            this.labelPercent.TabIndex = 23;
            this.labelPercent.Text = "0";
            this.labelPercent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 337);
            this.Controls.Add(this.labelPercent);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.textPath3);
            this.Controls.Add(this.textPath2);
            this.Controls.Add(this.textName3);
            this.Controls.Add(this.textName2);
            this.Controls.Add(this.textName1);
            this.Controls.Add(this.textPath1);
            this.Controls.Add(this.buttonPath3);
            this.Controls.Add(this.buttonPath2);
            this.Controls.Add(this.buttonPath1);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.menuStrip);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Crypter";
            this.Load += new System.EventHandler(this.OriginForm_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textPath3;
        private System.Windows.Forms.TextBox textPath2;
        private System.Windows.Forms.TextBox textPath1;
        private System.Windows.Forms.Button buttonPath3;
        private System.Windows.Forms.Button buttonPath2;
        private System.Windows.Forms.Button buttonPath1;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.TextBox textName1;
        private System.Windows.Forms.TextBox textName2;
        private System.Windows.Forms.TextBox textName3;
        private System.Windows.Forms.ToolTip toolTipDescriptions;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemFile;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemTools;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemOpen;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemOrigin;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemKey;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemCrypte;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemMode;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemEncryption;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemDecryption;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparatorTools1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemReset;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparatorTools2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemStart;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemStop;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparatorTools3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemOptions;
        private System.Windows.Forms.Label labelPercent;
    }
}

