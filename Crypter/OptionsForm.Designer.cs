namespace Crypter
{
    partial class OptionsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OptionsForm));
            this.toolTipDescriptions = new System.Windows.Forms.ToolTip(this.components);
            this.numericPercentOfKeyLength = new System.Windows.Forms.NumericUpDown();
            this.textStandartPathOrigin = new System.Windows.Forms.TextBox();
            this.textStandartPathKey = new System.Windows.Forms.TextBox();
            this.textStandartPathCrypte = new System.Windows.Forms.TextBox();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.textStandartNameOrigin = new System.Windows.Forms.TextBox();
            this.textStandartNameKey = new System.Windows.Forms.TextBox();
            this.textStandartNameCrypte = new System.Windows.Forms.TextBox();
            this.textExtension = new System.Windows.Forms.TextBox();
            this.checkGenerateRandomValue = new System.Windows.Forms.CheckBox();
            this.checkUseCustomExtension = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonPath1 = new System.Windows.Forms.Button();
            this.buttonPath2 = new System.Windows.Forms.Button();
            this.buttonPath3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericPercentOfKeyLength)).BeginInit();
            this.SuspendLayout();
            // 
            // numericPercentOfKeyLength
            // 
            this.numericPercentOfKeyLength.Location = new System.Drawing.Point(15, 249);
            this.numericPercentOfKeyLength.Name = "numericPercentOfKeyLength";
            this.numericPercentOfKeyLength.Size = new System.Drawing.Size(40, 20);
            this.numericPercentOfKeyLength.TabIndex = 4;
            this.numericPercentOfKeyLength.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericPercentOfKeyLength.ValueChanged += new System.EventHandler(this.numericUpDownPercent_ValueChanged);
            // 
            // textStandartPathOrigin
            // 
            this.textStandartPathOrigin.Location = new System.Drawing.Point(15, 25);
            this.textStandartPathOrigin.Name = "textStandartPathOrigin";
            this.textStandartPathOrigin.Size = new System.Drawing.Size(237, 20);
            this.textStandartPathOrigin.TabIndex = 5;
            // 
            // textStandartPathKey
            // 
            this.textStandartPathKey.Location = new System.Drawing.Point(15, 64);
            this.textStandartPathKey.Name = "textStandartPathKey";
            this.textStandartPathKey.Size = new System.Drawing.Size(237, 20);
            this.textStandartPathKey.TabIndex = 6;
            // 
            // textStandartPathCrypte
            // 
            this.textStandartPathCrypte.Location = new System.Drawing.Point(15, 103);
            this.textStandartPathCrypte.Name = "textStandartPathCrypte";
            this.textStandartPathCrypte.Size = new System.Drawing.Size(237, 20);
            this.textStandartPathCrypte.TabIndex = 7;
            // 
            // buttonLoad
            // 
            this.buttonLoad.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonLoad.Location = new System.Drawing.Point(177, 246);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(75, 23);
            this.buttonLoad.TabIndex = 8;
            this.buttonLoad.Text = "Load";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(258, 246);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 9;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // textStandartNameOrigin
            // 
            this.textStandartNameOrigin.Location = new System.Drawing.Point(15, 142);
            this.textStandartNameOrigin.Name = "textStandartNameOrigin";
            this.textStandartNameOrigin.Size = new System.Drawing.Size(156, 20);
            this.textStandartNameOrigin.TabIndex = 10;
            // 
            // textStandartNameKey
            // 
            this.textStandartNameKey.Location = new System.Drawing.Point(15, 181);
            this.textStandartNameKey.Name = "textStandartNameKey";
            this.textStandartNameKey.Size = new System.Drawing.Size(156, 20);
            this.textStandartNameKey.TabIndex = 11;
            // 
            // textStandartNameCrypte
            // 
            this.textStandartNameCrypte.Location = new System.Drawing.Point(15, 220);
            this.textStandartNameCrypte.Name = "textStandartNameCrypte";
            this.textStandartNameCrypte.Size = new System.Drawing.Size(156, 20);
            this.textStandartNameCrypte.TabIndex = 12;
            // 
            // textExtension
            // 
            this.textExtension.Location = new System.Drawing.Point(177, 220);
            this.textExtension.Name = "textExtension";
            this.textExtension.Size = new System.Drawing.Size(156, 20);
            this.textExtension.TabIndex = 12;
            // 
            // checkGenerateRandomValue
            // 
            this.checkGenerateRandomValue.AutoSize = true;
            this.checkGenerateRandomValue.Location = new System.Drawing.Point(177, 144);
            this.checkGenerateRandomValue.Name = "checkGenerateRandomValue";
            this.checkGenerateRandomValue.Size = new System.Drawing.Size(137, 17);
            this.checkGenerateRandomValue.TabIndex = 13;
            this.checkGenerateRandomValue.Text = "Generate random value";
            this.checkGenerateRandomValue.UseVisualStyleBackColor = true;
            // 
            // checkUseCustomExtension
            // 
            this.checkUseCustomExtension.AutoSize = true;
            this.checkUseCustomExtension.Location = new System.Drawing.Point(177, 183);
            this.checkUseCustomExtension.Name = "checkUseCustomExtension";
            this.checkUseCustomExtension.Size = new System.Drawing.Size(130, 17);
            this.checkUseCustomExtension.TabIndex = 14;
            this.checkUseCustomExtension.Text = "Use custom extension";
            this.checkUseCustomExtension.UseVisualStyleBackColor = true;
            this.checkUseCustomExtension.CheckedChanged += new System.EventHandler(this.checkUseCustomExtension_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Standart path to Origin File";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Standart path to Key File";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Standart path to Crypte File";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Standart name of Origin File";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Standart name of Key File";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Standart name of Crypte File";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(61, 251);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Percent of Key size";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(177, 204);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Name of custom Extention";
            // 
            // buttonPath1
            // 
            this.buttonPath1.Location = new System.Drawing.Point(259, 23);
            this.buttonPath1.Name = "buttonPath1";
            this.buttonPath1.Size = new System.Drawing.Size(75, 23);
            this.buttonPath1.TabIndex = 23;
            this.buttonPath1.Text = "Browse...";
            this.buttonPath1.UseVisualStyleBackColor = true;
            this.buttonPath1.Click += new System.EventHandler(this.buttonPath1_Click);
            // 
            // buttonPath2
            // 
            this.buttonPath2.Location = new System.Drawing.Point(258, 62);
            this.buttonPath2.Name = "buttonPath2";
            this.buttonPath2.Size = new System.Drawing.Size(75, 23);
            this.buttonPath2.TabIndex = 24;
            this.buttonPath2.Text = "Browse...";
            this.buttonPath2.UseVisualStyleBackColor = true;
            this.buttonPath2.Click += new System.EventHandler(this.buttonPath2_Click);
            // 
            // buttonPath3
            // 
            this.buttonPath3.Location = new System.Drawing.Point(258, 101);
            this.buttonPath3.Name = "buttonPath3";
            this.buttonPath3.Size = new System.Drawing.Size(75, 23);
            this.buttonPath3.TabIndex = 25;
            this.buttonPath3.Text = "Browse...";
            this.buttonPath3.UseVisualStyleBackColor = true;
            this.buttonPath3.Click += new System.EventHandler(this.buttonPath3_Click);
            // 
            // OptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 281);
            this.Controls.Add(this.buttonPath3);
            this.Controls.Add(this.buttonPath2);
            this.Controls.Add(this.buttonPath1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkUseCustomExtension);
            this.Controls.Add(this.checkGenerateRandomValue);
            this.Controls.Add(this.textExtension);
            this.Controls.Add(this.textStandartNameCrypte);
            this.Controls.Add(this.textStandartNameKey);
            this.Controls.Add(this.textStandartNameOrigin);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.textStandartPathCrypte);
            this.Controls.Add(this.textStandartPathKey);
            this.Controls.Add(this.textStandartPathOrigin);
            this.Controls.Add(this.numericPercentOfKeyLength);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "OptionsForm";
            this.Text = "Options";
            this.Load += new System.EventHandler(this.OptionsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericPercentOfKeyLength)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTipDescriptions;
        public System.Windows.Forms.NumericUpDown numericPercentOfKeyLength;
        private System.Windows.Forms.TextBox textStandartPathOrigin;
        private System.Windows.Forms.TextBox textStandartPathKey;
        private System.Windows.Forms.TextBox textStandartPathCrypte;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TextBox textStandartNameOrigin;
        private System.Windows.Forms.TextBox textStandartNameKey;
        private System.Windows.Forms.TextBox textStandartNameCrypte;
        private System.Windows.Forms.TextBox textExtension;
        private System.Windows.Forms.CheckBox checkGenerateRandomValue;
        private System.Windows.Forms.CheckBox checkUseCustomExtension;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonPath1;
        private System.Windows.Forms.Button buttonPath2;
        private System.Windows.Forms.Button buttonPath3;
    }
}