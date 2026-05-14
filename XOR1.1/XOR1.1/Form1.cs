using System.Text;

namespace XOR1._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static class XorCipher
        {
            // Общий метод для обработки текста
            public static string Encrypt(string text, string key)
            {
                byte[] data = Encoding.UTF8.GetBytes(text);
                byte[] result = Process(data, key);
                // Возвращаем Base64, чтобы зашифрованный текст можно было отобразить и сохранить в TXT
                return Convert.ToBase64String(result);
            }

            public static string Decrypt(string base64Text, string key)
            {
                try
                {
                    byte[] data = Convert.FromBase64String(base64Text);
                    byte[] result = Process(data, key);
                    return Encoding.UTF8.GetString(result);
                }
                catch { return "Ошибка: Некорректные данные или ключ."; }
            }

            private static byte[] Process(byte[] data, string key)
            {
                byte[] keyBytes = Encoding.UTF8.GetBytes(key);
                byte[] result = new byte[data.Length];
                for (int i = 0; i < data.Length; i++)
                {
                    result[i] = (byte)(data[i] ^ keyBytes[i % keyBytes.Length]);
                }
                return result;
            }
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            txtOutput.Text = XorCipher.Encrypt(txtInput.Text, txtKey.Text);
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            txtOutput.Text = XorCipher.Decrypt(txtInput.Text, txtKey.Text);
        }

        private void btnFileMode_Click(object sender, EventArgs e)
        {
            FileForm fileForm = new FileForm();
            fileForm.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
