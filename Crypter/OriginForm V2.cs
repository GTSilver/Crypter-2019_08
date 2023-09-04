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

        static int percentOfKeyLength;
        static string pathToOriginFile;
        static string pathToKeyFile;
        static string pathToCrypteFile;
        static string nameOfOriginFile;
        static string nameOfKeyFile;
        static string nameOfCryptedFile;
        static bool radioButton1Value;
        static bool radioButton2Value;
        static long progressBarValue;
        static long progressBarMinValue;    //Используется!
        static long progressBarMaxValue;

        FileStream readingStrim;
        FileStream keyWritingStrim;
        FileStream crypteWritingStrim;

        FileStream writingStrim;
        FileStream keyReadingStrim;
        FileStream crypteReadungStrim;

        FileStream readingKeyStrim;

        Thread CryptThread;
        Thread UIThread;

        //Выбор пути для файлов
        private void buttonPath1_Click_1(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
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

        private void buttonPath2_Click_1(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
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

        private void buttonPath3_Click_1(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
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

        private void OriginForm_Load(object sender, EventArgs e)
        {
            //Дизайн Общий
            this.Width = 500;
            this.Height = 207;

            //Начальное автозаполнение текста
            textPath1.Text = "";
            textPath2.Text = "C:\\";
            textPath3.Text = "C:\\";

            Random rand = new Random();
            int randomeValue = rand.Next(1000000, 9999999);

            textName1.Text = "OriginFile";
            textName2.Text = "KeyFile_" + randomeValue.ToString();
            textName3.Text = "CrypteFile_" + randomeValue.ToString();

            progressBar.Maximum = 10000;
        }

        private void buttonMenu1_Click(object sender, EventArgs e)
        {
            this.Width = 500;
            this.Height = 192;
            textPath1.Show();
            textPath2.Show();
            textPath3.Show();
            textName1.Show();
            textName2.Show();
            textName3.Show();
            buttonPath1.Show();
            buttonPath2.Show();
            buttonPath3.Show();
            buttonStart.Show();
            radioButton1.Show();
            radioButton2.Show();
            numericUpDownPercent.Show();
            labelPercent.Show();
            progressBar.Show();
        }

        private void buttonMenuBack_Click(object sender, EventArgs e)
        {
            this.Width = 210;
            this.Height = 114;
            textPath1.Hide();
            textPath2.Hide();
            textPath3.Hide();
            textName1.Hide();
            textName2.Hide();
            textName3.Hide();
            buttonPath1.Hide();
            buttonPath2.Hide();
            buttonPath3.Hide();
            buttonStart.Hide();
            radioButton1.Hide();
            radioButton2.Hide();
            numericUpDownPercent.Hide();
            labelPercent.Hide();
            progressBar.Hide();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                textName1.Enabled = false;
                textName2.Enabled = true;
                textName3.Enabled = true;
                numericUpDownPercent.Enabled = true;
                labelPercent.Enabled = true;
                textPath1.Text = "";
                textPath2.Text = "C:\\";
                textPath3.Text = "C:\\";
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                textName1.Enabled = true;
                textName2.Enabled = false;
                textName3.Enabled = false;
                numericUpDownPercent.Enabled = false;
                labelPercent.Enabled = false;
                textPath1.Text = "C:\\";
                textPath2.Text = "";
                textPath3.Text = "";
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDownPercent.Value > 100) numericUpDownPercent.Value = 100;
            if (numericUpDownPercent.Value < 1) numericUpDownPercent.Value = 1;
        }

        public void buttonStart_Click(object sender, EventArgs e)
        {
            startProcedure();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            resetProcedure();
        }

        public void SecondThread()
        {
            int byteOfOriginFile;
            int byteOfKeyFile;
            int byteOfCrypteFile;
            Random randomByteValue = new Random();

            if (radioButton1Value == true)
            {
                try { readingStrim = new FileStream(pathToOriginFile, FileMode.Open); }
                catch
                {
                    MessageBox.Show
                        (
                        "Unable to access the Origin file. Check the path to the file or run the program as administrator.",
                        "Error"
                        );
                    stopProcedure();
                }

                string extensionOfOriginFile = Path.GetExtension(pathToOriginFile);

                try { keyWritingStrim = new FileStream(pathToKeyFile + @"\" + nameOfKeyFile, FileMode.OpenOrCreate); }
                catch
                {
                    MessageBox.Show
                        (
                        "Unable to access Key directory. Check the directory path or run the program as administrator.",
                        "Error"
                        );
                    stopProcedure();
                }

                try { crypteWritingStrim = new FileStream(pathToCrypteFile + @"\" + nameOfCryptedFile + extensionOfOriginFile + ".crypt", FileMode.OpenOrCreate); }
                catch
                {
                    MessageBox.Show
                        (
                        "Unable to access Crypte directory. Check the directory path or run the program as administrator.",
                        "Error"
                        );
                    stopProcedure();
                }

                var sizeOfOriginFile = new FileInfo(pathToOriginFile).Length;
                var sizeOfKeyFile = sizeOfOriginFile * percentOfKeyLength / 100;

                if (sizeOfKeyFile < 1) sizeOfKeyFile = 1;

                progressBarMaxValue = sizeOfKeyFile + sizeOfOriginFile;

                UIThread = new Thread(new ThreadStart(ThirdThread));
                UIThread.Start();

                for (int i = 0; i < sizeOfKeyFile; i++)
                {
                    byteOfKeyFile = randomByteValue.Next(0, 255);
                    keyWritingStrim.WriteByte((byte)byteOfKeyFile);
                    progressBarValue = progressBarValue + 1;
                }
                keyWritingStrim.Close();
                readingKeyStrim = new FileStream(pathToKeyFile + @"\" + nameOfKeyFile, FileMode.Open);
                while (true)
                {
                    byteOfOriginFile = readingStrim.ReadByte();
                    byteOfKeyFile = readingKeyStrim.ReadByte();
                    if (byteOfKeyFile == -1)
                    {
                        readingKeyStrim.Position = 0;
                        byteOfKeyFile = readingKeyStrim.ReadByte();
                    }
                    byteOfCrypteFile = byteOfOriginFile ^ byteOfKeyFile;

                    progressBarValue = progressBarValue + 1;

                    if (byteOfOriginFile == -1) break;
                    else crypteWritingStrim.WriteByte((byte)byteOfCrypteFile);
                }
                readingKeyStrim.Close();
                crypteWritingStrim.Close();
                keyWritingStrim.Close();
                readingStrim.Close();
            }

            if (radioButton2Value == true)
            {
                try { crypteReadungStrim = new FileStream(pathToCrypteFile, FileMode.Open); }
                catch
                {
                    MessageBox.Show
                        (
                        "Unable to access the Crypte file. Check the path to the file or run the program as administrator.",
                        "Error"
                        );
                    stopProcedure();
                }

                var sizeOfCrypteFile = new FileInfo(pathToCrypteFile).Length;
                string partNameOfCrypteFile = GetPartNameOfCrypteFile(pathToCrypteFile);

                try { keyReadingStrim = new FileStream(pathToKeyFile, FileMode.Open); }
                catch
                {
                    MessageBox.Show
                        (
                        "Unable to access the Key file. Check the path to the file or run the program as administrator.",
                        "Error"
                        );
                    stopProcedure();
                }
                try { writingStrim = new FileStream(pathToOriginFile + @"\" + nameOfOriginFile + partNameOfCrypteFile, FileMode.OpenOrCreate); }
                catch
                {
                    MessageBox.Show
                        (
                        "Unable to access Origin directory. Check the directory path or run the program as administrator.",
                        "Error"
                        );
                    stopProcedure();
                }

                progressBarMaxValue = sizeOfCrypteFile;

                UIThread = new Thread(new ThreadStart(ThirdThread));
                UIThread.Start();

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
                crypteReadungStrim.Close();
                keyReadingStrim.Close();
                writingStrim.Close();
            }
            CryptThread.Abort();
        }

        public void ThirdThread()
        {
            while (progressBarValue < progressBarMaxValue)
            {
                Invoke((MethodInvoker)delegate ()
                {
                    progressBar.Value = (int)((double)progressBarValue / (double)progressBarMaxValue * 10000);
                });
                Thread.Sleep(100);
            }

            Invoke((MethodInvoker)delegate ()
            {
                progressBarValue = 0;
                progressBar.Value = 0;
                buttonStart.Enabled = true;
                buttonStop.Enabled = false;
                buttonReset.Enabled = true;
                radioButton1.Enabled = true;
                radioButton2.Enabled = true;
                buttonPath1.Enabled = true;
                buttonPath2.Enabled = true;
                buttonPath3.Enabled = true;
                textPath1.Enabled = true;
                textPath2.Enabled = true;
                textPath3.Enabled = true;
                if (radioButton1Value == true)
                {
                    textName1.Enabled = false;
                    textName2.Enabled = true;
                    textName3.Enabled = true;
                    numericUpDownPercent.Enabled = true;
                    labelPercent.Enabled = true;
                }
                if (radioButton2Value == true)
                {
                    textName1.Enabled = true;
                    textName2.Enabled = false;
                    textName3.Enabled = false;
                    numericUpDownPercent.Enabled = false;
                    labelPercent.Enabled = false;
                }
            });
            UIThread.Abort();
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            stopProcedure();
        }

        public void stopProcedure()
        {
            try { CryptThread.Abort(); }
            catch { };
            try { UIThread.Abort(); }
            catch { };

            Invoke((MethodInvoker)delegate ()
            {
                progressBarValue = 0;
                progressBar.Value = 0;
                buttonStart.Enabled = true;
                buttonStop.Enabled = false;
                buttonReset.Enabled = true;
                radioButton1.Enabled = true;
                radioButton2.Enabled = true;
                buttonPath1.Enabled = true;
                buttonPath2.Enabled = true;
                buttonPath3.Enabled = true;
                textPath1.Enabled = true;
                textPath2.Enabled = true;
                textPath3.Enabled = true;
                if (radioButton1Value == true)
                {
                    textName1.Enabled = false;
                    textName2.Enabled = true;
                    textName3.Enabled = true;
                    numericUpDownPercent.Enabled = true;
                    labelPercent.Enabled = true;
                }
                if (radioButton2Value == true)
                {
                    textName1.Enabled = true;
                    textName2.Enabled = false;
                    textName3.Enabled = false;
                    numericUpDownPercent.Enabled = false;
                    labelPercent.Enabled = false;
                }
            });

            try { readingKeyStrim.Close(); } catch { };
            try { crypteWritingStrim.Close(); } catch { };
            try { keyWritingStrim.Close(); } catch { };
            try { readingStrim.Close(); } catch { };
            try { crypteReadungStrim.Close(); } catch { };
            try { keyReadingStrim.Close(); } catch { };
            try { writingStrim.Close(); } catch { };
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

        public void startProcedure()
        {
            percentOfKeyLength = (int)numericUpDownPercent.Value;
            pathToOriginFile = textPath1.Text;
            pathToKeyFile = textPath2.Text;
            pathToCrypteFile = textPath3.Text;
            nameOfOriginFile = textName1.Text;
            nameOfKeyFile = textName2.Text;
            nameOfCryptedFile = textName3.Text;
            radioButton1Value = radioButton1.Checked;
            radioButton2Value = radioButton2.Checked;
            progressBarValue = 0;
            progressBarMinValue = 0;

            buttonStart.Enabled = false;
            buttonStop.Enabled = true;
            buttonReset.Enabled = false;
            radioButton1.Enabled = false;
            radioButton2.Enabled = false;
            numericUpDownPercent.Enabled = false;
            textPath1.Enabled = false;
            textPath2.Enabled = false;
            textPath3.Enabled = false;
            textName1.Enabled = false;
            textName2.Enabled = false;
            textName3.Enabled = false;
            buttonPath1.Enabled = false;
            buttonPath2.Enabled = false;
            buttonPath3.Enabled = false;
            labelPercent.Enabled = false;

            CryptThread = new Thread(new ThreadStart(SecondThread));
            CryptThread.Start();
        }

        public void resetProcedure()
        {
            if (radioButton1.Checked == true)
            {
                textPath1.Text = "";
                textPath2.Text = "C:\\";
                textPath3.Text = "C:\\";

                Random rand = new Random();
                int randomeValue = rand.Next(1000000, 9999999);

                textName1.Text = "OriginFile";
                textName2.Text = "KeyFile_" + randomeValue.ToString();
                textName3.Text = "CrypteFile_" + randomeValue.ToString();
            }
            else
            {
                textPath1.Text = "C:\\";
                textPath2.Text = "";
                textPath3.Text = "";

                Random rand = new Random();
                int randomeValue = rand.Next(1000000, 9999999);

                textName1.Text = "OriginFile";
                textName2.Text = "KeyFile_" + randomeValue.ToString();
                textName3.Text = "CrypteFile_" + randomeValue.ToString();
            }
        }
    }
}