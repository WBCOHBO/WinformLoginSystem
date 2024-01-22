using System;
using System.Windows.Forms;
using System.Drawing;
using Login.Classes;

namespace Login
{
    public partial class Form2_createAccount : Form
    {
        public Form2_createAccount()
        {
            InitializeComponent();
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            regAccount();
        }

        private void btnReturnToLogin_Click(object sender, EventArgs e)
        {
            switchPage();
        }

        void regAccount()
        {
            string name = textCreateAccount.Text;
            string pwd = textCreatePWD.Text;
            string pwd_again = textCreatePWD_again.Text;

            if(name == "" || pwd == "")
            {
                MessageBox.Show("請輸入要建立的帳號密碼");
                textCreatePWD.Clear();
                textCreatePWD_again.Clear();
            }else if(pwd != "" && pwd_again == "")
            {
                MessageBox.Show("請確認密碼");
            }

            while (name != "" && pwd != "" && pwd_again != "")
            {
                if (pwd != pwd_again || pwd_again != pwd)
                {
                    MessageBox.Show("請再重新確認密碼");
                    textCreatePWD.Clear();
                    textCreatePWD_again.Clear();
                    break;
                }
                else
                {
                    Login.Classes.Login check = new Login.Classes.Login();
                    if (check.checkAccount(name) == true)
                    {
                        MessageBox.Show("帳號重複，請重新輸入");
                        textCreateAccount.Clear();
                        textCreatePWD.Clear();
                        textCreatePWD_again.Clear();
                        break;
                    }
                    else
                    {
                        Login.Classes.Login login = new Login.Classes.Login();
                        login.createAccount(name, pwd);
                        MessageBox.Show("註冊成功 !");
                        textCreateAccount.Clear();
                        textCreatePWD.Clear();
                        textCreatePWD_again.Clear();
                        switchPage();
                        break;
                    }
                }
            }
        }

        void switchPage()
        {
            Form1_Login login = new Form1_Login();
            this.Visible = false;
            login.Visible = true;
        }

    }
}
