using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary1;

namespace WindowsFormsApp2
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (txt_username.Text == WindowsFormsApp2.Program.username)
            {
                char[] a = txt_password.Text.ToCharArray();
                int[] pass = new int[a.Length];
                for(int i = 0; i < a.Length; i++)
                {
                    pass[i] = Convert.ToInt32(a[i]);
                }
                Class1 c = new Class1();
                bool flag = c.compare(WindowsFormsApp2.Program.last, pass);
                if (flag == false)
                    MessageBox.Show("Enter correct password!!");
                else
                {
                    MessageBox.Show("Login Successful.");
                    PlaceOrder po = new PlaceOrder();
                    po.Show();
                    this.Hide();
                }
            }
            else
                MessageBox.Show("Enter valid username.");
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lnklbl_signup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Signup sign = new Signup();
            this.Hide();
            sign.Show();
        }

        private void txt_password_TextChanged(object sender, EventArgs e)
        {
            txt_password.PasswordChar = '*';
        }
    }
}
