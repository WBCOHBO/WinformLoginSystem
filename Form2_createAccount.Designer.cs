namespace Login
{
    partial class Form2_createAccount
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
            label1 = new Label();
            textCreateAccount = new TextBox();
            label2 = new Label();
            textCreatePWD = new TextBox();
            label3 = new Label();
            textCreatePWD_again = new TextBox();
            btnCreateAccount = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 9);
            label1.Name = "label1";
            label1.Size = new Size(154, 23);
            label1.TabIndex = 0;
            label1.Text = "請建立使用者帳號";
            // 
            // textCreateAccount
            // 
            textCreateAccount.Location = new Point(40, 35);
            textCreateAccount.Name = "textCreateAccount";
            textCreateAccount.Size = new Size(150, 30);
            textCreateAccount.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 97);
            label2.Name = "label2";
            label2.Size = new Size(118, 23);
            label2.TabIndex = 2;
            label2.Text = "請輸入新密碼";
            // 
            // textCreatePWD
            // 
            textCreatePWD.Location = new Point(40, 123);
            textCreatePWD.Name = "textCreatePWD";
            textCreatePWD.PasswordChar = '*';
            textCreatePWD.Size = new Size(150, 30);
            textCreatePWD.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 170);
            label3.Name = "label3";
            label3.Size = new Size(100, 23);
            label3.TabIndex = 4;
            label3.Text = "請確認密碼";
            // 
            // textCreatePWD_again
            // 
            textCreatePWD_again.Location = new Point(40, 196);
            textCreatePWD_again.Name = "textCreatePWD_again";
            textCreatePWD_again.PasswordChar = '*';
            textCreatePWD_again.Size = new Size(150, 30);
            textCreatePWD_again.TabIndex = 5;
            // 
            // btnCreateAccount
            // 
            btnCreateAccount.Location = new Point(132, 251);
            btnCreateAccount.Name = "btnCreateAccount";
            btnCreateAccount.Size = new Size(112, 34);
            btnCreateAccount.TabIndex = 6;
            btnCreateAccount.Text = "註冊";
            btnCreateAccount.UseVisualStyleBackColor = true;
            btnCreateAccount.Click += btnCreateAccount_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(266, 251);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(112, 34);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "取消";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnReturnToLogin_Click;
            // 
            // createAccount
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(428, 323);
            Controls.Add(btnCancel);
            Controls.Add(btnCreateAccount);
            Controls.Add(textCreatePWD_again);
            Controls.Add(label3);
            Controls.Add(textCreatePWD);
            Controls.Add(label2);
            Controls.Add(textCreateAccount);
            Controls.Add(label1);
            Name = "createAccount";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "建立使用者帳號";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textCreateAccount;
        private Label label2;
        private TextBox textCreatePWD;
        private Label label3;
        private TextBox textCreatePWD_again;
        private Button btnCreateAccount;
        private Button btnCancel;
    }
}