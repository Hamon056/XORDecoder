namespace XOR1._1
{
    partial class Form1
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
            btnEncrypt = new Button();
            btnDecrypt = new Button();
            btnFileMode = new Button();
            txtKey = new TextBox();
            txtOutput = new TextBox();
            txtInput = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnExit = new Button();
            SuspendLayout();
            // 
            // btnEncrypt
            // 
            btnEncrypt.Location = new Point(23, 128);
            btnEncrypt.Name = "btnEncrypt";
            btnEncrypt.Size = new Size(122, 38);
            btnEncrypt.TabIndex = 0;
            btnEncrypt.Text = "зашифровать";
            btnEncrypt.UseVisualStyleBackColor = true;
            btnEncrypt.Click += btnEncrypt_Click;
            // 
            // btnDecrypt
            // 
            btnDecrypt.Location = new Point(23, 190);
            btnDecrypt.Name = "btnDecrypt";
            btnDecrypt.Size = new Size(122, 38);
            btnDecrypt.TabIndex = 1;
            btnDecrypt.Text = "расшифровать";
            btnDecrypt.UseVisualStyleBackColor = true;
            btnDecrypt.Click += btnDecrypt_Click;
            // 
            // btnFileMode
            // 
            btnFileMode.Location = new Point(23, 248);
            btnFileMode.Name = "btnFileMode";
            btnFileMode.Size = new Size(122, 40);
            btnFileMode.TabIndex = 2;
            btnFileMode.Text = "загрузить файл";
            btnFileMode.UseVisualStyleBackColor = true;
            btnFileMode.Click += btnFileMode_Click;
            // 
            // txtKey
            // 
            txtKey.Location = new Point(190, 363);
            txtKey.Name = "txtKey";
            txtKey.Size = new Size(160, 23);
            txtKey.TabIndex = 3;
            // 
            // txtOutput
            // 
            txtOutput.Location = new Point(502, 102);
            txtOutput.Multiline = true;
            txtOutput.Name = "txtOutput";
            txtOutput.ReadOnly = true;
            txtOutput.Size = new Size(286, 233);
            txtOutput.TabIndex = 4;
            // 
            // txtInput
            // 
            txtInput.Location = new Point(190, 105);
            txtInput.Multiline = true;
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(285, 233);
            txtInput.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(190, 345);
            label1.Name = "label1";
            label1.Size = new Size(74, 15);
            label1.TabIndex = 6;
            label1.Text = "ввод ключа:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(190, 87);
            label2.Name = "label2";
            label2.Size = new Size(81, 15);
            label2.TabIndex = 7;
            label2.Text = "вывод текста:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(502, 84);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 8;
            label3.Text = "результат:";
            // 
            // btnExit
            // 
            btnExit.Location = new Point(680, 398);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(108, 40);
            btnExit.TabIndex = 9;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnExit);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtInput);
            Controls.Add(txtOutput);
            Controls.Add(txtKey);
            Controls.Add(btnFileMode);
            Controls.Add(btnDecrypt);
            Controls.Add(btnEncrypt);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEncrypt;
        private Button btnDecrypt;
        private Button btnFileMode;
        private TextBox txtKey;
        private TextBox txtOutput;
        private TextBox txtInput;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnExit;
    }
}
