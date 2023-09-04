using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crypter
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        //Глобальные переменные
        OptionsForm OptionForm = new OptionsForm();
        static int keyLengthPercent;
        static int switcherEnDeCryption;
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
        static string originFilePath;
        static string keyFilePath;
        static string crypteFilePath;
        static string originFileName;
        static string keyFileName;
        static string cryptedFileName;
        static long progressBarValue;
        static long progressBarMaxValue;
        FileStream readingStrim;
        FileStream keyWritingStrim;
        FileStream crypteWritingStrim;
        FileStream writingStrim;
        FileStream keyReadingStrim;
        FileStream crypteReadungStrim;
        FileStream readingKeyStrim;
        Thread CryptThread;
        Thread ProgressBarThread;

        //Формы
        private void OriginForm_Load(object sender, EventArgs e)
        {
            FormLoad();
        }

        //Кнопки
        private void buttonPath1_Click_1(object sender, EventArgs e)
        {
            SetOriginPath();
        }

        private void buttonPath2_Click_1(object sender, EventArgs e)
        {
            SetKeyPath();
        }

        private void buttonPath3_Click_1(object sender, EventArgs e)
        {
            SetCryptePath();
        }

        public void buttonStart_Click(object sender, EventArgs e)
        {
            Start();
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            Stop();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            EnableEncryption();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            EnableDecription();
        }

        private void toolStripMenuItemOrigin_Click(object sender, EventArgs e)
        {
            SetOriginPath();
        }

        private void toolStripMenuItemKey_Click(object sender, EventArgs e)
        {
            SetKeyPath();
        }

        private void toolStripMenuItemCrypte_Click(object sender, EventArgs e)
        {
            SetCryptePath();
        }

        private void toolStripMenuItemEncryption_Click(object sender, EventArgs e)
        {
            EnableEncryption();
        }

        private void toolStripMenuItemDecryption_Click(object sender, EventArgs e)
        {
            EnableDecription();
        }

        private void toolStripMenuItemGenerateCode_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void toolStripMenuItemStart_Click(object sender, EventArgs e)
        {
            Start();
        }

        private void toolStripMenuItemStop_Click(object sender, EventArgs e)
        {
            Stop();
        }

        private void toolStripMenuItemOptions_Click(object sender, EventArgs e)
        {
            OptionForm.ShowDialog();
        }

        public void CryptThreadActive()
        {
            int byteOfOriginFile;
            int byteOfKeyFile;
            int byteOfCrypteFile;
            Random randomByteValue = new Random();

            if (switcherEnDeCryption == 0)  //Зашифровка
            {
                try { readingStrim = new FileStream(originFilePath, FileMode.Open); }
                catch
                {
                    Stop();
                    MessageBox.Show
                        (
                        "Unable to access the Origin file. Check the path to the file or run the program as administrator.",
                        "Error"
                        );
                }

                string extensionOfOriginFile = Path.GetExtension(originFilePath);

                try { keyWritingStrim = new FileStream(keyFilePath + @"\" + keyFileName, FileMode.OpenOrCreate); }
                catch
                {
                    Stop();
                    MessageBox.Show
                        (
                        "Unable to access Key directory. Check the directory path or run the program as administrator.",
                        "Error"
                        );
                }

                if (optionsSwitcherCustomExtension == 0)
                {
                    try { crypteWritingStrim = new FileStream(crypteFilePath + @"\" + cryptedFileName + extensionOfOriginFile, FileMode.OpenOrCreate); }
                    catch
                    {
                        Stop();
                        MessageBox.Show
                            (
                            "Unable to access Crypte directory. Check the directory path or run the program as administrator.",
                            "Error"
                            );
                    }
                }
                else
                {
                    try { crypteWritingStrim = new FileStream(crypteFilePath + @"\" + cryptedFileName + extensionOfOriginFile + "." + optionsCustomExtension, FileMode.OpenOrCreate); }
                    catch
                    {
                        Stop();
                        MessageBox.Show
                            (
                            "Unable to access Crypte directory. Check the directory path or run the program as administrator.",
                            "Error"
                            );
                    }
                }

                var sizeOfOriginFile = new FileInfo(originFilePath).Length;
                var sizeOfKeyFile = sizeOfOriginFile * keyLengthPercent / 100;

                if (sizeOfKeyFile < 1) sizeOfKeyFile = 1;

                progressBarMaxValue = sizeOfKeyFile + sizeOfOriginFile;

                ProgressBarThread = new Thread(new ThreadStart(ProgressBarThreadActive));
                ProgressBarThread.Start();

                for (long i = 0; i < sizeOfKeyFile; i++) //Создание ключа
                {
                    byteOfKeyFile = randomByteValue.Next(0, 255);
                    keyWritingStrim.WriteByte((byte)byteOfKeyFile);
                    progressBarValue++;
                }
                keyWritingStrim.Close();

                readingKeyStrim = new FileStream(keyFilePath + @"\" + keyFileName, FileMode.Open);
                while (true)    //Создание крипта
                {
                    byteOfOriginFile = readingStrim.ReadByte();
                    byteOfKeyFile = readingKeyStrim.ReadByte();
                    if (byteOfKeyFile == -1)
                    {
                        readingKeyStrim.Position = 0;
                        byteOfKeyFile = readingKeyStrim.ReadByte();
                    }
                    byteOfCrypteFile = byteOfOriginFile ^ byteOfKeyFile;

                    progressBarValue++;

                    if (byteOfOriginFile == -1) break;
                    else crypteWritingStrim.WriteByte((byte)byteOfCrypteFile);
                }
            }

            else   //Дешифровка
            {
                try { crypteReadungStrim = new FileStream(crypteFilePath, FileMode.Open); }
                catch
                {
                    Stop();
                    MessageBox.Show
                        (
                        "Unable to access the Crypte file. Check the path to the file or run the program as administrator.",
                        "Error"
                        );
                }

                var sizeOfCrypteFile = new FileInfo(crypteFilePath).Length;
                string partNameOfCrypteFile = GetPartNameOfCrypteFile(crypteFilePath);  //--------------------------------------------------------------------

                try { keyReadingStrim = new FileStream(keyFilePath, FileMode.Open); }
                catch
                {
                    Stop();
                    MessageBox.Show
                        (
                        "Unable to access the Key file. Check the path to the file or run the program as administrator.",
                        "Error"
                        );
                }
                try { writingStrim = new FileStream(originFilePath + @"\" + originFileName + partNameOfCrypteFile, FileMode.OpenOrCreate); }
                catch
                {
                    Stop();
                    MessageBox.Show
                        (
                        "Unable to access Origin directory. Check the directory path or run the program as administrator.",
                        "Error"
                        );
                }

                progressBarMaxValue = sizeOfCrypteFile;

                ProgressBarThread = new Thread(new ThreadStart(ProgressBarThreadActive));
                ProgressBarThread.Start();

                while (true)
                {
                    byteOfKeyFile = keyReadingStrim.ReadByte();
                    if (byteOfKeyFile == -1)
                    {
                        keyReadingStrim.Position = 0;
                        byteOfKeyFile = keyReadingStrim.ReadByte();
                    }
                    byteOfCrypteFile = crypteReadungStrim.ReadByte();
                    byteOfOriginFile = byteOfKeyFile ^ byteOfCrypteFile;

                    progressBarValue = progressBarValue + 1;

                    if (byteOfCrypteFile == -1) break;
                    else writingStrim.WriteByte((byte)byteOfOriginFile);
                }
            }

            if (readingKeyStrim != null) readingKeyStrim.Dispose();
            if (crypteWritingStrim != null) crypteWritingStrim.Dispose();
            if (keyWritingStrim != null) keyWritingStrim.Dispose();
            if (readingStrim != null) readingStrim.Dispose();
            if (crypteReadungStrim != null) crypteReadungStrim.Dispose();
            if (keyReadingStrim != null) keyReadingStrim.Dispose();
            if (writingStrim != null) writingStrim.Dispose();

            if (CryptThread.IsAlive) CryptThread.Abort();
        }

        public void EnableUI()
        {
            progressBarValue = 0;
            progressBar.Value = 0;
            labelPercent.Text = "0";
            buttonStart.Enabled = true;
            buttonStop.Enabled = false;
            buttonPath1.Enabled = true;
            buttonPath2.Enabled = true;
            buttonPath3.Enabled = true;
            textPath1.Enabled = true;
            textPath2.Enabled = true;
            textPath3.Enabled = true;
            toolStripMenuItemStart.Enabled = true;
            toolStripMenuItemStop.Enabled = false;
            toolStripMenuItemReset.Enabled = true;
            toolStripMenuItemOrigin.Enabled = true;
            toolStripMenuItemKey.Enabled = true;
            toolStripMenuItemCrypte.Enabled = true;
            toolStripMenuItemEncryption.Enabled = true;
            toolStripMenuItemDecryption.Enabled = true;

            if (switcherEnDeCryption == 0)
            {
                textName1.Enabled = false;
                textName2.Enabled = true;
                textName3.Enabled = true;
            }
            else
            {
                textName1.Enabled = true;
                textName2.Enabled = false;
                textName3.Enabled = false;
            }
        }

        public void ProgressBarThreadActive()
        {
            while (progressBarValue < progressBarMaxValue)
            {
                Invoke((MethodInvoker)delegate ()
                {
                    progressBar.Value = (int)Math.Round((double)progressBarValue / progressBarMaxValue * progressBar.Maximum);
                    labelPercent.Text = Math.Round((double)progressBarValue / progressBarMaxValue * progressBar.Maximum / 100, 1).ToString();
                });
                Thread.Sleep(10);
            }

            Invoke((MethodInvoker)delegate ()
            { EnableUI(); });

            try { ProgressBarThread.Abort(); } catch { }
        }

        public void FormLoad()
        {
            //Дизайн Общий
            this.Width = 494;
            this.Height = 220;
            labelPercent.BackColor = Color.FromArgb(1, Color.Transparent);

            Reset();
            
            //Базовые значения переменных
            progressBar.Maximum = 10000;
            switcherEnDeCryption = 0;
        }

        public void EnableEncryption()
        {
            TryLoadOption();

            textName1.Enabled = false;
            textName2.Enabled = true;
            textName3.Enabled = true;
            switcherEnDeCryption = 0;
            textPath1.Text = "";
            textPath2.Text = optionsPathToKeyFile;
            textPath3.Text = optionsPathToCrypteFile;
        }

        public void EnableDecription()
        {
            TryLoadOption();

            textName1.Enabled = true;
            textName2.Enabled = false;
            textName3.Enabled = false;
            switcherEnDeCryption = 1;
            textPath1.Text = optionsPathToOriginFile;
            textPath2.Text = "";
            textPath3.Text = "";
    }

        public void SetOriginPath()
        {
            if (switcherEnDeCryption == 0)
            {
                using (var ofd1 = new OpenFileDialog())
                {
                    if (ofd1.ShowDialog() == DialogResult.OK)
                        textPath1.Text = ofd1.FileName;
                }
            }
            else
            {
                using (var ofd1 = new FolderBrowserDialog())
                {
                    if (ofd1.ShowDialog() == DialogResult.OK)
                        textPath1.Text = ofd1.SelectedPath;
                }
            }
        }

        public void SetKeyPath()
        {
            if (switcherEnDeCryption == 0)
            {
                using (var ofd2 = new FolderBrowserDialog())
                {
                    if (ofd2.ShowDialog() == DialogResult.OK)
                        textPath2.Text = ofd2.SelectedPath;
                }
            }
            else
            {
                using (var ofd2 = new OpenFileDialog())
                {
                    if (ofd2.ShowDialog() == DialogResult.OK)
                        textPath2.Text = ofd2.FileName;
                }
            }
        }

        public void SetCryptePath()
        {
            if (switcherEnDeCryption == 0)
            {
                using (var ofd3 = new FolderBrowserDialog())
                {
                    if (ofd3.ShowDialog() == DialogResult.OK)
                        textPath3.Text = ofd3.SelectedPath;
                }
            }
            else
            {
                using (var ofd3 = new OpenFileDialog())
                {
                    if (ofd3.ShowDialog() == DialogResult.OK)
                        textPath3.Text = ofd3.FileName;
                }
            }
        }

        public void DisableUI()
        {
            buttonStart.Enabled = false;
            buttonStop.Enabled = true;
            toolStripMenuItemStart.Enabled = false;
            toolStripMenuItemStop.Enabled = true;
            toolStripMenuItemReset.Enabled = false;
            textPath1.Enabled = false;
            textPath2.Enabled = false;
            textPath3.Enabled = false;
            textName1.Enabled = false;
            textName2.Enabled = false;
            textName3.Enabled = false;
            buttonPath1.Enabled = false;
            buttonPath2.Enabled = false;
            buttonPath3.Enabled = false;
            toolStripMenuItemOrigin.Enabled = false;
            toolStripMenuItemKey.Enabled = false;
            toolStripMenuItemCrypte.Enabled = false;
            toolStripMenuItemEncryption.Enabled = false;
            toolStripMenuItemDecryption.Enabled = false;
        }

        public void Start()
        {
            TryLoadOption();

            keyLengthPercent = (int)OptionForm.numericPercentOfKeyLength.Value;
            originFilePath = textPath1.Text;
            keyFilePath = textPath2.Text;
            crypteFilePath = textPath3.Text;
            originFileName = textName1.Text;
            keyFileName = textName2.Text;
            cryptedFileName = textName3.Text;
            progressBarValue = 0;

            DisableUI();

            CryptThread = new Thread(new ThreadStart(CryptThreadActive));
            CryptThread.Start();
        }

        public void Stop()
        {
            if (CryptThread.IsAlive) CryptThread.Abort();
            if (ProgressBarThread.IsAlive) ProgressBarThread.Abort();

            Invoke((MethodInvoker)delegate ()
             { EnableUI(); });

            if (readingKeyStrim != null) readingKeyStrim.Dispose();
            if (crypteWritingStrim != null) crypteWritingStrim.Dispose();
            if (keyWritingStrim != null) keyWritingStrim.Dispose();
            if (readingStrim != null) readingStrim.Dispose();
            if (crypteReadungStrim != null) crypteReadungStrim.Dispose();
            if (keyReadingStrim != null) keyReadingStrim.Dispose();
            if (writingStrim != null) writingStrim.Dispose();
        }

        public void Reset()
        {
            TryLoadOption();

            if (switcherEnDeCryption == 0)
            {
                textPath1.Text = "";
                textPath2.Text = optionsPathToKeyFile;
                textPath3.Text = optionsPathToCrypteFile;
            }
            else
            {
                textPath1.Text = optionsPathToOriginFile;
                textPath2.Text = "";
                textPath3.Text = "";
            }

            if (optionsSwitcherRandomValue == 1)
            {
                int randomeValue = new Random().Next(1000000, 9999999);
                textName1.Text = optionsNameOfOriginFile;
                textName2.Text = optionsNameOfKeyFile + randomeValue.ToString();
                textName3.Text = optionsNameOfCryptedFile + randomeValue.ToString();
            }
            else
            {
                textName1.Text = optionsNameOfOriginFile;
                textName2.Text = optionsNameOfKeyFile;
                textName3.Text = optionsNameOfCryptedFile;
            }
        }

        public void LoadOption()
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

        public void SaveDefaltOption()
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

        public void TryLoadOption()
        {
            try { LoadOption(); }
            catch
            {
                SaveDefaltOption();
                LoadOption();
            }
        }

        public static string GetPartNameOfCrypteFile(string path)
        {
            var fileName = Path.GetFileName(path);
            var firstIndex = fileName.LastIndexOf('_');
            var lastIndex = fileName.LastIndexOf('.');
            string result = "_AugmentedNameError";

            try { result = fileName.Substring(firstIndex, lastIndex - firstIndex); }
            catch
            {
                MessageBox.Show
                (
                "The following characters are missing in the name of the Crypte file: \"_\" and/or \".\".",
                "Warning"
                );
            }

            return result;
        }
    }
}