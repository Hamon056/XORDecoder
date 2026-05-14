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
            SuspendLayout();
            // 
            // txtFileContent
            // 
            txtFileContent.Location = new Point(126, 53);
            txtFileContent.Multiline = true;
            txtFileContent.Name = "txtFileContent";
            txtFileContent.Size = new Size(328, 289);
            txtFileContent.TabIndex = 0;
            // 
            // txtFileResult
            // 
            txtFileResult.Location = new Point(460, 53);
            txtFileResult.Multiline = true;
            txtFileResult.Name = "txtFileResult";
            txtFileResult.Size = new Size(328, 289);
            txtFileResult.TabIndex = 1;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(9, 72);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(111, 38);
            btnLoad.TabIndex = 2;
            btnLoad.Text = "загрузить";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(9, 237);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(111, 38);
            btnSave.TabIndex = 3;
            btnSave.Text = "сохранить";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnEncrypt
            // 
            btnEncrypt.Location = new Point(9, 127);
            btnEncrypt.Name = "btnEncrypt";
            btnEncrypt.Size = new Size(108, 38);
            btnEncrypt.TabIndex = 4;
            btnEncrypt.Text = "зашифровать";
            btnEncrypt.UseVisualStyleBackColor = true;
            btnEncrypt.Click += btnEncrypt_Click;
            // 
            // btnDecrypt
            // 
            btnDecrypt.Location = new Point(12, 181);
            btnDecrypt.Name = "btnDecrypt";
            btnDecrypt.Size = new Size(108, 38);
            btnDecrypt.TabIndex = 5;
            btnDecrypt.Text = "расшифровать";
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
            btnBack.Text = "назад";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnExit_Click;
            // 
            // FileForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBack);
            Controls.Add(btnDecrypt);
            Controls.Add(btnEncrypt);
            Controls.Add(btnSave);
            Controls.Add(btnLoad);
            Controls.Add(txtFileResult);
            Controls.Add(txtFileContent);
            Name = "FileForm";
            Text = "FileForm";
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
    }
}