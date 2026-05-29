namespace XOR1._1
{
    partial class XORCipher
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XORCipher));
            btnEncrypt = new Button();
            btnDecrypt = new Button();
            txtKey = new TextBox();
            txtOutput = new TextBox();
            txtInput = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            menuStrip1 = new MenuStrip();
            выходToolStripMenuItem = new ToolStripMenuItem();
            оПрограммеToolStripMenuItem = new ToolStripMenuItem();
            настройкиToolStripMenuItem = new ToolStripMenuItem();
            выборТемыToolStripMenuItem = new ToolStripMenuItem();
            белаяТемаToolStripMenuItem = new ToolStripMenuItem();
            чернаяТемаToolStripMenuItem = new ToolStripMenuItem();
            btnLoadFile = new Button();
            btnSaveFile = new Button();
            btnCopy = new Button();
            btnGenerateKey = new Button();
            label4 = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // btnEncrypt
            // 
            btnEncrypt.BackColor = SystemColors.Window;
            btnEncrypt.Location = new Point(12, 400);
            btnEncrypt.Name = "btnEncrypt";
            btnEncrypt.Size = new Size(122, 38);
            btnEncrypt.TabIndex = 0;
            btnEncrypt.Text = "Зашифровать";
            btnEncrypt.UseVisualStyleBackColor = false;
            btnEncrypt.Click += btnEncrypt_Click;
            // 
            // btnDecrypt
            // 
            btnDecrypt.BackColor = SystemColors.Window;
            btnDecrypt.Location = new Point(140, 400);
            btnDecrypt.Name = "btnDecrypt";
            btnDecrypt.Size = new Size(122, 38);
            btnDecrypt.TabIndex = 1;
            btnDecrypt.Text = "Расшифровать";
            btnDecrypt.UseVisualStyleBackColor = false;
            btnDecrypt.Click += btnDecrypt_Click;
            // 
            // txtKey
            // 
            txtKey.Location = new Point(12, 356);
            txtKey.Name = "txtKey";
            txtKey.Size = new Size(206, 23);
            txtKey.TabIndex = 3;
            // 
            // txtOutput
            // 
            txtOutput.BackColor = SystemColors.Window;
            txtOutput.Location = new Point(410, 39);
            txtOutput.Multiline = true;
            txtOutput.Name = "txtOutput";
            txtOutput.ReadOnly = true;
            txtOutput.ScrollBars = ScrollBars.Vertical;
            txtOutput.Size = new Size(378, 340);
            txtOutput.TabIndex = 4;
            // 
            // txtInput
            // 
            txtInput.AllowDrop = true;
            txtInput.Location = new Point(12, 41);
            txtInput.Multiline = true;
            txtInput.Name = "txtInput";
            txtInput.ScrollBars = ScrollBars.Vertical;
            txtInput.Size = new Size(378, 286);
            txtInput.TabIndex = 5;
            txtInput.DragDrop += txtInput_DragDrop;
            txtInput.DragEnter += txtInput_DragEnter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 338);
            label1.Name = "label1";
            label1.Size = new Size(75, 15);
            label1.TabIndex = 6;
            label1.Text = "Ввод ключа:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 24);
            label2.Name = "label2";
            label2.Size = new Size(73, 15);
            label2.TabIndex = 7;
            label2.Text = "Ввод текста:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(410, 24);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 8;
            label3.Text = "Результат:";
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.Menu;
            menuStrip1.Items.AddRange(new ToolStripItem[] { выходToolStripMenuItem, оПрограммеToolStripMenuItem, настройкиToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 10;
            menuStrip1.Text = "menuStrip1";
            // 
            // выходToolStripMenuItem
            // 
            выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            выходToolStripMenuItem.Size = new Size(53, 20);
            выходToolStripMenuItem.Text = "Выход";
            выходToolStripMenuItem.Click += выходToolStripMenuItem_Click;
            // 
            // оПрограммеToolStripMenuItem
            // 
            оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            оПрограммеToolStripMenuItem.Size = new Size(94, 20);
            оПрограммеToolStripMenuItem.Text = "О программе";
            оПрограммеToolStripMenuItem.Click += оПрограммеToolStripMenuItem_Click;
            // 
            // настройкиToolStripMenuItem
            // 
            настройкиToolStripMenuItem.BackColor = SystemColors.Control;
            настройкиToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { выборТемыToolStripMenuItem });
            настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            настройкиToolStripMenuItem.Size = new Size(79, 20);
            настройкиToolStripMenuItem.Text = "Настройки";
            // 
            // выборТемыToolStripMenuItem
            // 
            выборТемыToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { белаяТемаToolStripMenuItem, чернаяТемаToolStripMenuItem });
            выборТемыToolStripMenuItem.Name = "выборТемыToolStripMenuItem";
            выборТемыToolStripMenuItem.Size = new Size(180, 22);
            выборТемыToolStripMenuItem.Text = "Выбор темы ";
            // 
            // белаяТемаToolStripMenuItem
            // 
            белаяТемаToolStripMenuItem.Name = "белаяТемаToolStripMenuItem";
            белаяТемаToolStripMenuItem.Size = new Size(180, 22);
            белаяТемаToolStripMenuItem.Text = "Светлая тема ";
            белаяТемаToolStripMenuItem.Click += белаяТемаToolStripMenuItem_Click;
            // 
            // чернаяТемаToolStripMenuItem
            // 
            чернаяТемаToolStripMenuItem.Name = "чернаяТемаToolStripMenuItem";
            чернаяТемаToolStripMenuItem.Size = new Size(180, 22);
            чернаяТемаToolStripMenuItem.Text = "Тёмная тема";
            чернаяТемаToolStripMenuItem.Click += чернаяТемаToolStripMenuItem_Click;
            // 
            // btnLoadFile
            // 
            btnLoadFile.BackColor = SystemColors.Window;
            btnLoadFile.Location = new Point(284, 400);
            btnLoadFile.Name = "btnLoadFile";
            btnLoadFile.Size = new Size(122, 38);
            btnLoadFile.TabIndex = 11;
            btnLoadFile.Text = "Загрузить файл";
            btnLoadFile.UseVisualStyleBackColor = false;
            btnLoadFile.Click += btnLoadFile_Click;
            // 
            // btnSaveFile
            // 
            btnSaveFile.BackColor = SystemColors.Window;
            btnSaveFile.Location = new Point(412, 400);
            btnSaveFile.Name = "btnSaveFile";
            btnSaveFile.Size = new Size(122, 38);
            btnSaveFile.TabIndex = 12;
            btnSaveFile.Text = "Сохранить файл";
            btnSaveFile.UseVisualStyleBackColor = false;
            btnSaveFile.Click += btnSaveFile_Click;
            // 
            // btnCopy
            // 
            btnCopy.BackColor = SystemColors.Window;
            btnCopy.Location = new Point(666, 393);
            btnCopy.Name = "btnCopy";
            btnCopy.Size = new Size(122, 45);
            btnCopy.TabIndex = 13;
            btnCopy.Text = "Копировать результат ";
            btnCopy.UseVisualStyleBackColor = false;
            btnCopy.Click += btnCopy_Click;
            // 
            // btnGenerateKey
            // 
            btnGenerateKey.BackColor = SystemColors.Window;
            btnGenerateKey.Location = new Point(261, 352);
            btnGenerateKey.Name = "btnGenerateKey";
            btnGenerateKey.Size = new Size(122, 28);
            btnGenerateKey.TabIndex = 14;
            btnGenerateKey.Text = "сгенерировать";
            btnGenerateKey.UseVisualStyleBackColor = false;
            btnGenerateKey.Click += btnGenerateKey_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(270, 334);
            label4.Name = "label4";
            label4.Size = new Size(107, 15);
            label4.TabIndex = 15;
            label4.Text = "Генерация ключа:";
            // 
            // XORCipher
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuBar;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(btnGenerateKey);
            Controls.Add(btnCopy);
            Controls.Add(btnSaveFile);
            Controls.Add(btnLoadFile);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtInput);
            Controls.Add(txtOutput);
            Controls.Add(txtKey);
            Controls.Add(btnDecrypt);
            Controls.Add(btnEncrypt);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "XORCipher";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "XORCipher";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEncrypt;
        private Button btnDecrypt;
        private TextBox txtKey;
        private TextBox txtOutput;
        private TextBox txtInput;
        private Label label1;
        private Label label2;
        private Label label3;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem оПрограммеToolStripMenuItem;
        private Button btnLoadFile;
        private Button btnSaveFile;
        private ToolStripMenuItem выходToolStripMenuItem;
        private Button btnCopy;
        private Button btnGenerateKey;
        private Label label4;
        private ToolStripMenuItem настройкиToolStripMenuItem;
        private ToolStripMenuItem выборТемыToolStripMenuItem;
        private ToolStripMenuItem белаяТемаToolStripMenuItem;
        private ToolStripMenuItem чернаяТемаToolStripMenuItem;
    }
}
