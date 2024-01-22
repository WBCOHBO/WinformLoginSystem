using System;
using System.Windows.Forms;
using System.Drawing;
using Login.Classes;

namespace Login
{
    public partial class Form1_Login : Form
    {
        public Form1_Login()
        {
            InitializeComponent();
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            Form2_createAccount reg = new Form2_createAccount();
            this.Visible = false;
            reg.Visible = true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            loginAccount();
        }

        void loginAccount()
        {
            string name = textName.Text;
            string pwd = textPWD.Text;

            if (name == "" && pwd == "")
            {
                MessageBox.Show("�п�J�b���K�X");
                textPWD.Clear();
            }

            while(name != "" || pwd != "")
            {
                Login.Classes.Login check = new Login.Classes.Login();
                if (check.checkAccount(name, pwd) == true)
                {
                    MessageBox.Show("�n�J���\ !");
                    textName.Clear();
                    textPWD.Clear();
                    break;
                }
                else
                {
                    MessageBox.Show("�нT�{�b���αK�X�O�_���T");
                    textName.Clear();
                    textPWD.Clear();
                    break;
                }
            }

        }
    }
}
