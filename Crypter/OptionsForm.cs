using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crypter
{
    public partial class OptionsForm : Form
    {
        public OptionsForm()
        {
            InitializeComponent();
        }

        //Глобальные переменные
        static int optionsPercentOfKeyLength;
        static int optionsSwitcherRandomValue;
        static int optionsSwitcherCustomExtension;
        static string optionsPathToOriginFile;
        static string optionsPathToKeyFile;
        static string optionsPathToCrypteFile;
        static string optionsNameOfOriginFile;
        static string optionsNameOfKeyFile;
        static string optionsNameOfCryptedFile;
        static string optionsCustomExtension;

        //Формы
        private void OptionsForm_Load(object sender, EventArgs e)
        {
            FormLoadProcedure();
        }

        //Кнопки
        private void numericUpDownPercent_ValueChanged(object sender, EventArgs e)
        {
            CheckPercentOfKeyProcedure();
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            FormLoadProcedure();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            OptionsSaveProcedure();
        }

        //Процедуры
        public void CheckPercentOfKeyProcedure()
        {
            if (numericPercentOfKeyLength.Value > 100) numericPercentOfKeyLength.Value = 100;
            if (numericPercentOfKeyLength.Value < 1) numericPercentOfKeyLength.Value = 1;
        }

        public void FormLoadProcedure()
        {
            //Загрузка опций
            OptionsLoadProcedure();

            //Автозаполнение текста
            numericPercentOfKeyLength.Value = optionsPercentOfKeyLength;
            textStandartPathOrigin.Text = optionsPathToOriginFile;
            textStandartPathKey.Text = optionsPathToKeyFile;
            textStandartPathCrypte.Text = optionsPathToCrypteFile;
            textStandartNameOrigin.Text = optionsNameOfOriginFile;
            textStandartNameKey.Text = optionsNameOfKeyFile;
            textStandartNameCrypte.Text = optionsNameOfCryptedFile;
            if (optionsSwitcherRandomValue == 1)
            {
                checkGenerateRandomValue.Checked = true;
            }
            else
            {
                checkGenerateRandomValue.Checked = false;
            }
            if (optionsSwitcherCustomExtension == 1)
            {
                checkUseCustomExtension.Checked = true;
            }
            else
            {
                checkUseCustomExtension.Checked = false;
            }
            textExtension.Text = optionsCustomExtension;
        }

        public void OptionsLoadProcedure()
        {
            //Проверка
            try
            {
                StreamReader optionsStrim = new StreamReader(Environment.CurrentDirectory + "\\settings.cfg");
                optionsPercentOfKeyLength = int.Parse(optionsStrim.ReadLine());
                optionsPathToOriginFile = optionsStrim.ReadLine();
                optionsPathToKeyFile = optionsStrim.ReadLine();
                optionsPathToCrypteFile = optionsStrim.ReadLine();
                optionsNameOfOriginFile = optionsStrim.ReadLine();
                optionsNameOfKeyFile = optionsStrim.ReadLine();
                optionsNameOfCryptedFile = optionsStrim.ReadLine();
                optionsSwitcherRandomValue = int.Parse(optionsStrim.ReadLine());
                optionsSwitcherCustomExtension = int.Parse(optionsStrim.ReadLine());
                optionsCustomExtension = optionsStrim.ReadLine();
                optionsStrim.Close();
            }
            catch
            {
                MessageBox.Show("File settings.cfg not found or damaged. Options have been reset to default.");
                StreamWriter optionsStrim = new StreamWriter(Environment.CurrentDirectory + "\\settings.cfg");
                optionsStrim.WriteLine("100");
                optionsStrim.WriteLine("C:\\");
                optionsStrim.WriteLine("C:\\");
                optionsStrim.WriteLine("C:\\");
                optionsStrim.WriteLine("OriginFile");
                optionsStrim.WriteLine("KeyFile_");
                optionsStrim.WriteLine("CrypteFile_");
                optionsStrim.WriteLine("1");
                optionsStrim.WriteLine("1");
                optionsStrim.Write("crypt");
                optionsStrim.Close();
            }

            //Загрузка
            try
            {
                StreamReader optionsStrim = new StreamReader(Environment.CurrentDirectory + "\\settings.cfg");
                optionsPercentOfKeyLength = int.Parse(optionsStrim.ReadLine());
                optionsPathToOriginFile = optionsStrim.ReadLine();
                optionsPathToKeyFile = optionsStrim.ReadLine();
                optionsPathToCrypteFile = optionsStrim.ReadLine();
                optionsNameOfOriginFile = optionsStrim.ReadLine();
                optionsNameOfKeyFile = optionsStrim.ReadLine();
                optionsNameOfCryptedFile = optionsStrim.ReadLine();
                optionsSwitcherRandomValue = int.Parse(optionsStrim.ReadLine());
                optionsSwitcherCustomExtension = int.Parse(optionsStrim.ReadLine());
                optionsCustomExtension = optionsStrim.ReadLine();
                optionsStrim.Close();
            }
            catch { }
        }

        public void OptionsSaveProcedure()
        {
            StreamWriter optionsStrim = new StreamWriter(Environment.CurrentDirectory + "\\settings.cfg");
            optionsStrim.WriteLine(numericPercentOfKeyLength.Value);
            optionsStrim.WriteLine(textStandartPathOrigin.Text);
            optionsStrim.WriteLine(textStandartPathKey.Text);
            optionsStrim.WriteLine(textStandartPathCrypte.Text);
            optionsStrim.WriteLine(textStandartNameOrigin.Text);
            optionsStrim.WriteLine(textStandartNameKey.Text);
            optionsStrim.WriteLine(textStandartNameCrypte.Text);
            if (checkGenerateRandomValue.Checked == true)
            {
                optionsStrim.WriteLine("1");
            }
            else
            {
                optionsStrim.WriteLine("0");
            }
            if (checkUseCustomExtension.Checked == true)
            {
                optionsStrim.WriteLine("1");
            }
            else
            {
                optionsStrim.WriteLine("0");
            }
            optionsStrim.Write(textExtension.Text);
            optionsStrim.Close();
        }

        private void checkUseCustomExtension_CheckedChanged(object sender, EventArgs e)
        {
            textExtension.Enabled = checkUseCustomExtension.Checked;
        }

        private void buttonPath1_Click(object sender, EventArgs e)
        {
            using (var ofd1 = new FolderBrowserDialog())
            {
                if (ofd1.ShowDialog() == DialogResult.OK)
                    textStandartPathOrigin.Text = ofd1.SelectedPath;
            }
        }

        private void buttonPath2_Click(object sender, EventArgs e)
        {
            using (var ofd1 = new FolderBrowserDialog())
            {
                if (ofd1.ShowDialog() == DialogResult.OK)
                    textStandartPathKey.Text = ofd1.SelectedPath;
            }
        }

        private void buttonPath3_Click(object sender, EventArgs e)
        {
            using (var ofd1 = new FolderBrowserDialog())
            {
                if (ofd1.ShowDialog() == DialogResult.OK)
                    textStandartPathCrypte.Text = ofd1.SelectedPath;
            }
        }
    }
}
