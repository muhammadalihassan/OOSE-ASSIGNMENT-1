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
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();
        }

        private void btnsign_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Signup_Load(object sender, EventArgs e)
        {

        }

        private void txtsign_password_TextChanged(object sender, EventArgs e)
        {
            txt_password.PasswordChar = '*';
        }

        private void txtsign_password2_TextChanged(object sender, EventArgs e)
        {
            txt_password2.PasswordChar = '*';
        }

        private void btn_signup_Click(object sender, EventArgs e)
        {
            WindowsFormsApp2.Program.username = txt_username.Text;
            WindowsFormsApp2.Program.password = txt_password.Text;
            WindowsFormsApp2.Program.last = new int[WindowsFormsApp2.Program.password.Length];
            char[] a = txt_password.Text.ToCharArray();
            char[] b = txt_password2.Text.ToCharArray();
            int[] ascii = new int[a.Length];
            int[] aa = new int[b.Length];
            for(int i = 0; i < a.Length; i++)
            {
                ascii[i] = a[i];
            }
            for (int i = 0; i < b.Length; i++)
            {
                aa[i] = b[i];
            }
            Class1 c1 = new Class1();
            bool flag = c1.compare(ascii, aa);
            if (flag == true)
            {
                MessageBox.Show("Successfully Created.");
                for(int i = 0; i < ascii.Length; i++)
                {
                    WindowsFormsApp2.Program.last[i] = ascii[i];
                }
                Login lg = new Login();
                lg.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Password do not match!!");
        }
    }
}
