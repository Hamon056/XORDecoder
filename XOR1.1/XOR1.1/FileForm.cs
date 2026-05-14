using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static XOR1._1.Form1;

namespace XOR1._1
{
    public partial class FileForm : Form
    {
        public FileForm()
        {
            InitializeComponent();
        }

        private string currentKey;

        private void btnLoad_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog { Filter = "Text Files|*.txt" })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    string[] lines = File.ReadAllLines(ofd.FileName);
                    if (lines.Length > 0)
                    {
                        currentKey = lines[0]; 
                        txtFileContent.Text = string.Join(Environment.NewLine, lines);
                    }
                }
            }
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(currentKey)) return;

            string data = GetTextWithoutKey(txtFileContent.Text);
            string encrypted = XorCipher.Encrypt(data, currentKey);

            txtFileResult.Text = currentKey + Environment.NewLine + encrypted;
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(currentKey)) return;

            string data = GetTextWithoutKey(txtFileContent.Text);
            string decrypted = XorCipher.Decrypt(data, currentKey);

            txtFileResult.Text = currentKey + Environment.NewLine + decrypted;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog { Filter = "Text Files|*.txt" })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(sfd.FileName, txtFileResult.Text);
                    MessageBox.Show("Файл сохранен!");
                }
            }
        }

        private string GetTextWithoutKey(string fullText)
        {
            var lines = fullText.Split(new[] { Environment.NewLine, "\n" }, StringSplitOptions.None);
            return string.Join(Environment.NewLine, lines.Skip(1));
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Form1 main = new Form1();
            main.Show();     
            this.Close();
        }
    }
}
