namespace XOR1._1
{
    partial class FileForm
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
            txtFileContent = new TextBox();
            txtFileResult = new TextBox();
            btnLoad = new Button();
            btnSave = new Button();
            btnEncrypt = new Button();
            btnDecrypt = new Button();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            btnBack = new Button();
            label1 = new Label();
            label2 = new Label();
            menuStrip1 = new MenuStrip();
            оПрограммеToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // txtFileContent
            // 
            txtFileContent.Location = new Point(126, 72);
            txtFileContent.Multiline = true;
            txtFileContent.Name = "txtFileContent";
            txtFileContent.Size = new Size(328, 289);
            txtFileContent.TabIndex = 0;
            // 
            // txtFileResult
            // 
            txtFileResult.Location = new Point(460, 72);
            txtFileResult.Multiline = true;
            txtFileResult.Name = "txtFileResult";
            txtFileResult.ReadOnly = true;
            txtFileResult.Size = new Size(328, 289);
            txtFileResult.TabIndex = 1;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(9, 110);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(111, 38);
            btnLoad.TabIndex = 2;
            btnLoad.Text = "Загрузить файл";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(9, 302);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(111, 38);
            btnSave.TabIndex = 3;
            btnSave.Text = "Сохранить файл";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnEncrypt
            // 
            btnEncrypt.Location = new Point(12, 174);
            btnEncrypt.Name = "btnEncrypt";
            btnEncrypt.Size = new Size(108, 38);
            btnEncrypt.TabIndex = 4;
            btnEncrypt.Text = "Зашифровать";
            btnEncrypt.UseVisualStyleBackColor = true;
            btnEncrypt.Click += btnEncrypt_Click;
            // 
            // btnDecrypt
            // 
            btnDecrypt.Location = new Point(12, 237);
            btnDecrypt.Name = "btnDecrypt";
            btnDecrypt.Size = new Size(108, 38);
            btnDecrypt.TabIndex = 5;
            btnDecrypt.Text = "Расшифровать";
            btnDecrypt.UseVisualStyleBackColor = true;
            btnDecrypt.Click += btnDecrypt_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
            // 
            // saveFileDialog1
            // 
            saveFileDialog1.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
            // 
            // btnBack
            // 
            btnBack.Location = new Point(680, 398);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(108, 40);
            btnBack.TabIndex = 10;
            btnBack.Text = "Назад";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnExit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(126, 54);
            label1.Name = "label1";
            label1.Size = new Size(206, 15);
            label1.TabIndex = 11;
            label1.Text = "Содержимое файла (Ключ + Текст):";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(460, 54);
            label2.Name = "label2";
            label2.Size = new Size(125, 15);
            label2.TabIndex = 12;
            label2.Text = "Результат обработки:";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { оПрограммеToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 13;
            menuStrip1.Text = "menuStrip1";
            // 
            // оПрограммеToolStripMenuItem
            // 
            оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            оПрограммеToolStripMenuItem.Size = new Size(94, 20);
            оПрограммеToolStripMenuItem.Text = "О программе";
            оПрограммеToolStripMenuItem.Click += оПрограммеToolStripMenuItem_Click;
            // 
            // FileForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnBack);
            Controls.Add(btnDecrypt);
            Controls.Add(btnEncrypt);
            Controls.Add(btnSave);
            Controls.Add(btnLoad);
            Controls.Add(txtFileResult);
            Controls.Add(txtFileContent);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MainMenuStrip = menuStrip1;
            Name = "FileForm";
            Text = "FileForm";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtFileContent;
        private TextBox txtFileResult;
        private Button btnLoad;
        private Button btnSave;
        private Button btnEncrypt;
        private Button btnDecrypt;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private Button btnBack;
        private Label label1;
        private Label label2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem оПрограммеToolStripMenuItem;
    }
}