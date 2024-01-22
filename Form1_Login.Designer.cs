namespace Login
{
    partial class Form1_Login
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
            label1 = new Label();
            textName = new TextBox();
            label2 = new Label();
            textPWD = new TextBox();
            btnReg = new Button();
            btnLogin = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 24);
            label1.Name = "label1";
            label1.Size = new Size(82, 23);
            label1.TabIndex = 0;
            label1.Text = "帳號名稱";
            // 
            // textName
            // 
            textName.Location = new Point(12, 70);
            textName.Name = "textName";
            textName.Size = new Size(150, 30);
            textName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 137);
            label2.Name = "label2";
            label2.Size = new Size(46, 23);
            label2.TabIndex = 2;
            label2.Text = "密碼";
            // 
            // textPWD
            // 
            textPWD.Location = new Point(12, 176);
            textPWD.Name = "textPWD";
            textPWD.PasswordChar = '*';
            textPWD.Size = new Size(150, 30);
            textPWD.TabIndex = 3;
            // 
            // btnReg
            // 
            btnReg.Location = new Point(50, 238);
            btnReg.Name = "btnReg";
            btnReg.Size = new Size(112, 34);
            btnReg.TabIndex = 4;
            btnReg.Text = "註冊";
            btnReg.UseVisualStyleBackColor = true;
            btnReg.Click += btnReg_Click;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(177, 238);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(112, 34);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "登入";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // Form1_Login
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(358, 300);
            Controls.Add(btnLogin);
            Controls.Add(btnReg);
            Controls.Add(textPWD);
            Controls.Add(label2);
            Controls.Add(textName);
            Controls.Add(label1);
            Name = "Form1_Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "登入系統";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textName;
        private Label label2;
        private TextBox textPWD;
        private Button btnReg;
        private Button btnLogin;
    }
}
