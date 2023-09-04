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
            this.textPath3 = new System.Windows.Forms.TextBox();
            this.textPath2 = new System.Windows.Forms.TextBox();
            this.textPath1 = new System.Windows.Forms.TextBox();
            this.buttonPath3 = new System.Windows.Forms.Button();
            this.buttonPath2 = new System.Windows.Forms.Button();
            this.buttonPath1 = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.numericUpDownPercent = new System.Windows.Forms.NumericUpDown();
            this.labelPercent = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.textName1 = new System.Windows.Forms.TextBox();
            this.textName2 = new System.Windows.Forms.TextBox();
            this.textName3 = new System.Windows.Forms.TextBox();
            this.buttonReset = new System.Windows.Forms.Button();
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
            this.toolStripSeparatorFile = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemUndo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemRedo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparatorEdit = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItemCut = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemTools = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemMode = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemEncryption = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemDecryption = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparatorTools1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItemGenerateCode = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparatorTools2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItemStart = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemStop = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparatorTools3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItemOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemUsersManual = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparatorHelp = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItemAboutCrypter = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPercent)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // textPath3
            // 
            this.textPath3.AccessibleDescription = "";
            this.textPath3.AccessibleName = "";
            this.textPath3.Location = new System.Drawing.Point(26, 107);
            this.textPath3.Name = "textPath3";
            this.textPath3.Size = new System.Drawing.Size(258, 20);
            this.textPath3.TabIndex = 10;
            this.toolTipDescriptions.SetToolTip(this.textPath3, "Path to Crypte file");
            // 
            // textPath2
            // 
            this.textPath2.Location = new System.Drawing.Point(26, 81);
            this.textPath2.Name = "textPath2";
            this.textPath2.Size = new System.Drawing.Size(258, 20);
            this.textPath2.TabIndex = 7;
            this.toolTipDescriptions.SetToolTip(this.textPath2, "Path to Key file");
            // 
            // textPath1
            // 
            this.textPath1.Location = new System.Drawing.Point(26, 55);
            this.textPath1.Name = "textPath1";
            this.textPath1.Size = new System.Drawing.Size(258, 20);
            this.textPath1.TabIndex = 4;
            this.toolTipDescriptions.SetToolTip(this.textPath1, "Path to Origin file");
            // 
            // buttonPath3
            // 
            this.buttonPath3.Location = new System.Drawing.Point(397, 105);
            this.buttonPath3.Name = "buttonPath3";
            this.buttonPath3.Size = new System.Drawing.Size(75, 23);
            this.buttonPath3.TabIndex = 12;
            this.buttonPath3.Text = "Browse...";
            this.buttonPath3.UseVisualStyleBackColor = true;
            this.buttonPath3.Click += new System.EventHandler(this.buttonPath3_Click_1);
            // 
            // buttonPath2
            // 
            this.buttonPath2.Location = new System.Drawing.Point(397, 79);
            this.buttonPath2.Name = "buttonPath2";
            this.buttonPath2.Size = new System.Drawing.Size(75, 23);
            this.buttonPath2.TabIndex = 9;
            this.buttonPath2.Text = "Browse...";
            this.buttonPath2.UseVisualStyleBackColor = true;
            this.buttonPath2.Click += new System.EventHandler(this.buttonPath2_Click_1);
            // 
            // buttonPath1
            // 
            this.buttonPath1.Location = new System.Drawing.Point(397, 53);
            this.buttonPath1.Name = "buttonPath1";
            this.buttonPath1.Size = new System.Drawing.Size(75, 23);
            this.buttonPath1.TabIndex = 6;
            this.buttonPath1.Text = "Browse...";
            this.buttonPath1.UseVisualStyleBackColor = true;
            this.buttonPath1.Click += new System.EventHandler(this.buttonPath1_Click_1);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(188, 134);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(284, 23);
            this.progressBar.Step = 1;
            this.progressBar.TabIndex = 17;
            // 
            // radioButton1
            // 
            this.radioButton1.AccessibleDescription = "";
            this.radioButton1.AccessibleName = "";
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(93, 30);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(75, 17);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Encryption";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(174, 30);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(76, 17);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.Text = "Decryption";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // numericUpDownPercent
            // 
            this.numericUpDownPercent.Location = new System.Drawing.Point(256, 30);
            this.numericUpDownPercent.Name = "numericUpDownPercent";
            this.numericUpDownPercent.Size = new System.Drawing.Size(40, 20);
            this.numericUpDownPercent.TabIndex = 3;
            this.numericUpDownPercent.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownPercent.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // labelPercent
            // 
            this.labelPercent.AutoSize = true;
            this.labelPercent.Location = new System.Drawing.Point(299, 32);
            this.labelPercent.Name = "labelPercent";
            this.labelPercent.Size = new System.Drawing.Size(173, 13);
            this.labelPercent.TabIndex = 20;
            this.labelPercent.Text = "Percent key size from origin file size";
            // 
            // buttonStart
            // 
            this.buttonStart.AccessibleDescription = "";
            this.buttonStart.Location = new System.Drawing.Point(12, 134);
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
            this.textName1.Location = new System.Drawing.Point(290, 55);
            this.textName1.Name = "textName1";
            this.textName1.Size = new System.Drawing.Size(101, 20);
            this.textName1.TabIndex = 5;
            this.toolTipDescriptions.SetToolTip(this.textName1, "Name of Origin file");
            // 
            // textName2
            // 
            this.textName2.Location = new System.Drawing.Point(290, 81);
            this.textName2.Name = "textName2";
            this.textName2.Size = new System.Drawing.Size(101, 20);
            this.textName2.TabIndex = 8;
            this.toolTipDescriptions.SetToolTip(this.textName2, "Name of Key file");
            // 
            // textName3
            // 
            this.textName3.AccessibleDescription = "";
            this.textName3.AccessibleName = "";
            this.textName3.Location = new System.Drawing.Point(290, 107);
            this.textName3.Name = "textName3";
            this.textName3.Size = new System.Drawing.Size(101, 20);
            this.textName3.TabIndex = 11;
            this.textName3.Tag = "";
            this.toolTipDescriptions.SetToolTip(this.textName3, "Name of Crypte file");
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(12, 27);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(75, 23);
            this.buttonReset.TabIndex = 1;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "O";
            this.toolTipDescriptions.SetToolTip(this.label2, "Attributes of Origin file");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "K";
            this.toolTipDescriptions.SetToolTip(this.label3, "Attributes of Key file");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "C";
            this.toolTipDescriptions.SetToolTip(this.label4, "Attributes of Crypte file");
            // 
            // buttonStop
            // 
            this.buttonStop.Enabled = false;
            this.buttonStop.Location = new System.Drawing.Point(100, 134);
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
            this.toolStripMenuItemEdit,
            this.toolStripMenuItemTools,
            this.toolStripMenuItemHelp});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(531, 24);
            this.menuStrip.TabIndex = 22;
            this.menuStrip.Text = "menuStrip1";
            // 
            // toolStripMenuItemFile
            // 
            this.toolStripMenuItemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemOpen,
            this.toolStripSeparatorFile,
            this.toolStripMenuItemExit});
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
            // 
            // toolStripMenuItemKey
            // 
            this.toolStripMenuItemKey.Name = "toolStripMenuItemKey";
            this.toolStripMenuItemKey.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItemKey.Text = "Key file/directory";
            // 
            // toolStripMenuItemCrypte
            // 
            this.toolStripMenuItemCrypte.Name = "toolStripMenuItemCrypte";
            this.toolStripMenuItemCrypte.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItemCrypte.Text = "Crypte file/directory";
            // 
            // toolStripSeparatorFile
            // 
            this.toolStripSeparatorFile.Name = "toolStripSeparatorFile";
            this.toolStripSeparatorFile.Size = new System.Drawing.Size(177, 6);
            // 
            // toolStripMenuItemExit
            // 
            this.toolStripMenuItemExit.Name = "toolStripMenuItemExit";
            this.toolStripMenuItemExit.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItemExit.Text = "Exit";
            // 
            // toolStripMenuItemEdit
            // 
            this.toolStripMenuItemEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemUndo,
            this.toolStripMenuItemRedo,
            this.toolStripSeparatorEdit,
            this.toolStripMenuItemCut,
            this.toolStripMenuItemCopy,
            this.toolStripMenuItemPaste,
            this.toolStripMenuItemDelete});
            this.toolStripMenuItemEdit.Name = "toolStripMenuItemEdit";
            this.toolStripMenuItemEdit.Size = new System.Drawing.Size(39, 20);
            this.toolStripMenuItemEdit.Text = "Edit";
            // 
            // toolStripMenuItemUndo
            // 
            this.toolStripMenuItemUndo.Name = "toolStripMenuItemUndo";
            this.toolStripMenuItemUndo.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItemUndo.Text = "Undo";
            // 
            // toolStripMenuItemRedo
            // 
            this.toolStripMenuItemRedo.Name = "toolStripMenuItemRedo";
            this.toolStripMenuItemRedo.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItemRedo.Text = "Redo";
            // 
            // toolStripSeparatorEdit
            // 
            this.toolStripSeparatorEdit.Name = "toolStripSeparatorEdit";
            this.toolStripSeparatorEdit.Size = new System.Drawing.Size(177, 6);
            // 
            // toolStripMenuItemCut
            // 
            this.toolStripMenuItemCut.Name = "toolStripMenuItemCut";
            this.toolStripMenuItemCut.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItemCut.Text = "Cut";
            // 
            // toolStripMenuItemCopy
            // 
            this.toolStripMenuItemCopy.Name = "toolStripMenuItemCopy";
            this.toolStripMenuItemCopy.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItemCopy.Text = "Copy";
            // 
            // toolStripMenuItemPaste
            // 
            this.toolStripMenuItemPaste.Name = "toolStripMenuItemPaste";
            this.toolStripMenuItemPaste.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItemPaste.Text = "Paste";
            // 
            // toolStripMenuItemDelete
            // 
            this.toolStripMenuItemDelete.Name = "toolStripMenuItemDelete";
            this.toolStripMenuItemDelete.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItemDelete.Text = "Delete";
            // 
            // toolStripMenuItemTools
            // 
            this.toolStripMenuItemTools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemMode,
            this.toolStripSeparatorTools1,
            this.toolStripMenuItemGenerateCode,
            this.toolStripSeparatorTools2,
            this.toolStripMenuItemStart,
            this.toolStripMenuItemStop,
            this.toolStripSeparatorTools3,
            this.toolStripMenuItemOptions});
            this.toolStripMenuItemTools.Name = "toolStripMenuItemTools";
            this.toolStripMenuItemTools.Size = new System.Drawing.Size(47, 20);
            this.toolStripMenuItemTools.Text = "Tools";
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
            this.toolStripMenuItemEncryption.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItemEncryption.Text = "Encryption";
            // 
            // toolStripMenuItemDecryption
            // 
            this.toolStripMenuItemDecryption.Name = "toolStripMenuItemDecryption";
            this.toolStripMenuItemDecryption.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItemDecryption.Text = "Decryption";
            // 
            // toolStripSeparatorTools1
            // 
            this.toolStripSeparatorTools1.Name = "toolStripSeparatorTools1";
            this.toolStripSeparatorTools1.Size = new System.Drawing.Size(177, 6);
            // 
            // toolStripMenuItemGenerateCode
            // 
            this.toolStripMenuItemGenerateCode.Name = "toolStripMenuItemGenerateCode";
            this.toolStripMenuItemGenerateCode.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItemGenerateCode.Text = "Generate Code";
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
            // 
            // toolStripMenuItemStop
            // 
            this.toolStripMenuItemStop.Name = "toolStripMenuItemStop";
            this.toolStripMenuItemStop.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItemStop.Text = "Stop";
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
            // 
            // toolStripMenuItemHelp
            // 
            this.toolStripMenuItemHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemUsersManual,
            this.toolStripSeparatorHelp,
            this.toolStripMenuItemAboutCrypter});
            this.toolStripMenuItemHelp.Name = "toolStripMenuItemHelp";
            this.toolStripMenuItemHelp.Size = new System.Drawing.Size(44, 20);
            this.toolStripMenuItemHelp.Text = "Help";
            // 
            // toolStripMenuItemUsersManual
            // 
            this.toolStripMenuItemUsersManual.Name = "toolStripMenuItemUsersManual";
            this.toolStripMenuItemUsersManual.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItemUsersManual.Text = "User\'s manual";
            // 
            // toolStripSeparatorHelp
            // 
            this.toolStripSeparatorHelp.Name = "toolStripSeparatorHelp";
            this.toolStripSeparatorHelp.Size = new System.Drawing.Size(177, 6);
            // 
            // toolStripMenuItemAboutCrypter
            // 
            this.toolStripMenuItemAboutCrypter.Name = "toolStripMenuItemAboutCrypter";
            this.toolStripMenuItemAboutCrypter.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItemAboutCrypter.Text = "About Crypter";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(531, 337);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.labelPercent);
            this.Controls.Add(this.numericUpDownPercent);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
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
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Crypter";
            this.Load += new System.EventHandler(this.OriginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPercent)).EndInit();
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
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.NumericUpDown numericUpDownPercent;
        private System.Windows.Forms.Label labelPercent;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.TextBox textName1;
        private System.Windows.Forms.TextBox textName2;
        private System.Windows.Forms.TextBox textName3;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.ToolTip toolTipDescriptions;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemFile;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemEdit;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemTools;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemHelp;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemOpen;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemOrigin;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemKey;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemCrypte;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparatorFile;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemExit;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemUndo;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemRedo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparatorEdit;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemCut;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemCopy;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemPaste;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemDelete;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemMode;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemEncryption;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemDecryption;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparatorTools1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemGenerateCode;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparatorTools2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemStart;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemStop;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparatorTools3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemOptions;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemUsersManual;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparatorHelp;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAboutCrypter;
    }
}

