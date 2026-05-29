using System.Text;

namespace XOR1._1
{
    public partial class XORCipher : Form
    {
        public XORCipher()
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
            if (string.IsNullOrEmpty(txtKey.Text))
            {
                MessageBox.Show("Пожалуйста, введите ключ шифрования!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(txtInput.Text))
            {
                MessageBox.Show("Нет текста для шифрования!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            txtOutput.Text = XorCipher.Encrypt(txtInput.Text, txtKey.Text);
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtKey.Text))
            {
                MessageBox.Show("Пожалуйста, введите ключ шифрования!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(txtInput.Text))
            {
                MessageBox.Show("Нет текста для расшифровки!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            txtOutput.Text = XorCipher.Decrypt(txtInput.Text, txtKey.Text);
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm about = new AboutForm();
            about.ShowDialog();
        }

        private void btnLoadFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
                openFileDialog.Title = "Выберите файл для загрузки";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txtInput.Text = File.ReadAllText(openFileDialog.FileName, Encoding.UTF8);
                }
            }
        }

        private void btnSaveFile_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtOutput.Text))
            {
                MessageBox.Show("Нет данных для сохранения! Сначала выполните шифрование или расшифровку.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
                saveFileDialog.Title = "Сохранить результат как";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(saveFileDialog.FileName, txtOutput.Text, Encoding.UTF8);
                    MessageBox.Show("Файл успешно сохранен!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtOutput.Text))
            {
                Clipboard.SetText(txtOutput.Text);
                MessageBox.Show("Текст успешно скопирован!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnGenerateKey_Click(object sender, EventArgs e)
        {
            const string validChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890!@#$%^&*";
            Random random = new Random();
            char[] key = new char[random.Next(10, 25)];

            for (int i = 0; i < key.Length; i++)
            {
                key[i] = validChars[random.Next(validChars.Length)];
            }

            txtKey.Text = new string(key);
        }

        // Drag & Drop
        private void txtInput_DragEnter(object sender, DragEventArgs e)
        {
            // Проверяем, что перетаскивают именно файлы
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
        }

        private void txtInput_DragDrop(object sender, DragEventArgs e)
        {
            // Получаем пути ко всем перетаскиваемым файлам
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (files.Length > 0)
            {
                // Читаем только первый файл из списка
                txtInput.Text = File.ReadAllText(files[0], Encoding.UTF8);
            }
        }

        // дизайн белая и черная тема

        private void белаяТемаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetTheme(false);
        }

        private void чернаяТемаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetTheme(true);
        }

        private void SetTheme(bool isDark)
        {
            // Палитра цветов для темной и светлой темы
            Color backColor = isDark ? Color.FromArgb(30, 30, 30) : Color.FromKnownColor(KnownColor.Control);
            Color textColor = isDark ? Color.White : Color.Black;
            Color textBoxBack = isDark ? Color.FromArgb(45, 45, 48) : Color.White;
            Color buttonBack = isDark ? Color.FromArgb(63, 63, 70) : Color.FromKnownColor(KnownColor.Window);

            // Красим саму форму
            this.BackColor = backColor;
            this.ForeColor = textColor;

            // Запускаем автоматический перебор ВСЕХ элементов на форме
            UpdateControls(this.Controls, backColor, textColor, textBoxBack, buttonBack, isDark);
        }

        private void UpdateControls(Control.ControlCollection controls, Color backColor, Color textColor, Color textBoxBack, Color buttonBack, bool isDark)
        {
            foreach (Control control in controls)
            {
                // textBox
                if (control is TextBox)
                {
                    control.BackColor = textBoxBack;
                    control.ForeColor = textColor;
                }
                // button
                else if (control is Button btn)
                {
                    btn.BackColor = buttonBack;
                    btn.ForeColor = textColor;
                    btn.FlatStyle = isDark ? FlatStyle.Flat : FlatStyle.Standard; // В темной теме плоские, в светлой - обычные
                }
                // lable 
                else if (control is Label)
                {
                    control.ForeColor = textColor;
                }
                // menuStrip 
                else if (control is MenuStrip menuStrip)
                {
                    menuStrip.BackColor = backColor;
                    menuStrip.ForeColor = textColor;

                    // Включаем кастомную отрисовку для темной темы (защита от белых пятен) или отключаем для светлой
                    menuStrip.Renderer = isDark ? new ToolStripProfessionalRenderer(new DarkThemeColorTable()) : null;

                    // mainItem in menuStrip
                    foreach (ToolStripMenuItem mainItem in menuStrip.Items)
                    {
                        ColorMenuStripItem(mainItem, backColor, textColor);
                    }
                }

                // Если элементы лежат внутри каких-то контейнеров (панелей), проверяем их тоже
                if (control.HasChildren)
                {
                    UpdateControls(control.Controls, backColor, textColor, textBoxBack, buttonBack, isDark);
                }
            }
        }

        // Вспомогательный метод для рекурсивной покраски выпадающих списков меню
        private void ColorMenuStripItem(ToolStripMenuItem item, Color backColor, Color textColor)
        {
            item.BackColor = backColor;
            item.ForeColor = textColor;

            foreach (ToolStripItem subItem in item.DropDownItems)
            {
                if (subItem is ToolStripMenuItem subMenu)
                {
                    ColorMenuStripItem(subMenu, backColor, textColor);
                }
                else
                {
                    subItem.BackColor = backColor;
                    subItem.ForeColor = textColor;
                }
            }
        }
        public class DarkThemeColorTable : ProfessionalColorTable
        {
            public override Color ToolStripDropDownBackground => Color.FromArgb(30, 30, 30);
            public override Color MenuItemSelected => Color.FromArgb(63, 63, 70);
            public override Color MenuItemSelectedGradientBegin => Color.FromArgb(63, 63, 70);
            public override Color MenuItemSelectedGradientEnd => Color.FromArgb(63, 63, 70);
            public override Color MenuItemPressedGradientBegin => Color.FromArgb(45, 45, 48);
            public override Color MenuItemPressedGradientEnd => Color.FromArgb(45, 45, 48);
            public override Color MenuBorder => Color.FromArgb(60, 60, 60);
            public override Color MenuItemBorder => Color.Transparent;
        }

    }

}
