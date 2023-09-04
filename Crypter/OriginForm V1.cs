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
    public partial class OriginForm : Form
    {
        public OriginForm()
        {
            InitializeComponent();
        }

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
            this.Width = 210;
            this.Height = 114;
            buttonMenu1.Location = new Point(12, 12);
            buttonMenu2.Location = new Point(12, 41);
            buttonMenuBack.Location = new Point(12, 12);
            textPath1.Location = new Point(12, 41);
            textPath2.Location = new Point(12, 67);
            textPath3.Location = new Point(12, 93);
            textName1.Location = new Point(290, 41);
            textName2.Location = new Point(290, 67);
            textName3.Location = new Point(290, 93);
            buttonPath1.Location = new Point(397, 39);
            buttonPath2.Location = new Point(397, 65);
            buttonPath3.Location = new Point(397, 91);
            buttonStart.Location = new Point(12, 119);
            radioButton1.Location = new Point(64, 15);
            radioButton2.Location = new Point(145, 15);
            numericUpDown1.Location = new Point(227, 15);
            label1.Location = new Point(273, 19);
            progressBar1.Location = new Point(188, 119);
        }

        private void buttonMenu1_Click(object sender, EventArgs e)
        {
            this.Width = 500;
            this.Height = 192;
            buttonMenu1.Hide();
            buttonMenu2.Hide();
            buttonMenuBack.Show();
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
            numericUpDown1.Show();
            label1.Show();
            progressBar1.Show();
        }

        private void buttonMenuBack_Click(object sender, EventArgs e)
        {
            this.Width = 210;
            this.Height = 114;
            buttonMenu1.Show();
            buttonMenu2.Show();
            buttonMenuBack.Hide();
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
            numericUpDown1.Hide();
            label1.Hide();
            progressBar1.Hide();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                textName1.Enabled = false;
                textName2.Enabled = true;
                textName3.Enabled = true;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                textName1.Enabled = true;
                textName2.Enabled = false;
                textName3.Enabled = false;
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown1.Value > 100) numericUpDown1.Value = 100;
            if (numericUpDown1.Value < 1) numericUpDown1.Value = 1;
        }

        public void buttonStart_Click(object sender, EventArgs e)
        {
            int byteOfOriginFile;
            int byteOfKeyFile;
            int byteOfCrypteFile;
            int percentOfKeyLength = (int)numericUpDown1.Value;
            string pathToOriginFile = textPath1.Text;
            string pathToKeyFile = textPath2.Text;
            string pathToCrypteFile = textPath3.Text;
            string nameOfOriginFile = textName1.Text;
            string nameOfKeyFile = textName2.Text;
            string nameOfCryptedFile = textName3.Text;
            Random randomByteValue = new Random();
            if (radioButton1.Checked == true)
            {
                FileStream readingStrim = new FileStream(pathToOriginFile, FileMode.Open);
                FileStream keyWritingStrim = new FileStream(pathToKeyFile + @"\" + nameOfKeyFile, FileMode.OpenOrCreate);
                FileStream crypteWritingStrim = new FileStream(pathToCrypteFile + @"\" + nameOfCryptedFile, FileMode.OpenOrCreate);
                var sizeOfOriginFile = new FileInfo(pathToOriginFile).Length;
                if (sizeOfOriginFile * percentOfKeyLength / 100 < 1) sizeOfOriginFile = 1;
                for (int i = 0; i < (sizeOfOriginFile * percentOfKeyLength / 100); i++)
                {
                    byteOfKeyFile = randomByteValue.Next(0, 255);
                    keyWritingStrim.WriteByte((byte)byteOfKeyFile);
                }
                keyWritingStrim.Close();
                FileStream readingKeyStrim = new FileStream(pathToKeyFile + @"\" + nameOfKeyFile, FileMode.Open);
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
                    if (byteOfOriginFile == -1) break;
                    else  crypteWritingStrim.WriteByte((byte)byteOfCrypteFile);
                }
                readingKeyStrim.Close();
                crypteWritingStrim.Close();
                keyWritingStrim.Close();
                readingStrim.Close();
            }

            if (radioButton2.Checked == true)
            {
                FileStream writingStrim = new FileStream(pathToOriginFile + @"\" + nameOfOriginFile, FileMode.OpenOrCreate);
                FileStream keyReadingStrim = new FileStream(pathToKeyFile, FileMode.Open);
                FileStream crypteReadungStrim = new FileStream(pathToCrypteFile, FileMode.Open);
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
                    if (byteOfCrypteFile == -1) break;
                    else writingStrim.WriteByte((byte)byteOfOriginFile);
                }
                crypteReadungStrim.Close();
                keyReadingStrim.Close();
                writingStrim.Close();
            }
        }
    }
}