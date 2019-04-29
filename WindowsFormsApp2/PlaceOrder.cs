using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary2;

namespace WindowsFormsApp2
{
    public partial class PlaceOrder : Form
    {

        public PlaceOrder()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void PlaceOrder_Load(object sender, EventArgs e)
        {
            lblusername.Text = WindowsFormsApp2.Program.username;

            math.Text = WindowsFormsApp2.Program.Mathematics.ToString();
            dsa.Text = WindowsFormsApp2.Program.DSA.ToString();
            oose.Text = WindowsFormsApp2.Program.OOSE.ToString();
            java.Text = WindowsFormsApp2.Program.Java.ToString();
            eng.Text = WindowsFormsApp2.Program.English.ToString();
            cvt.Text = WindowsFormsApp2.Program.CVT.ToString();
            isl.Text = WindowsFormsApp2.Program.Islamiat.ToString();

            math.Enabled = false;
            dsa.Enabled = false;
            oose.Enabled = false;
            java.Enabled = false;
            eng.Enabled = false;
            cvt.Enabled = false;
            isl.Enabled = false;

            qtymath.Enabled = false;
            qtydsa.Enabled = false;
            qtyoose.Enabled = false;
            qtyjava.Enabled = false;
            qtyeng.Enabled = false;
            qtycvt.Enabled = false;
            qtyisl.Enabled = false;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void chkapple_CheckedChanged(object sender, EventArgs e)
        {
            if (cmath.Checked == true)
            {
                qtymath.Enabled = true;
                qtymath.Text = "0";
            }
        }

        private void chksamsung_CheckedChanged(object sender, EventArgs e)
        {
            if (cdsa.Checked == true)
            {
                qtydsa.Enabled = true;
                qtydsa.Text = "0";
            }
        }

        private void chkhuawei_CheckedChanged(object sender, EventArgs e)
        {
            if (coose.Checked == true)
            {
                qtyoose.Enabled = true;
                qtyoose.Text = "0";
            }
        }

        private void chkvivo_CheckedChanged(object sender, EventArgs e)
        {
            if (cjava.Checked == true)
            {
                qtyjava.Enabled = true;
                qtyjava.Text = "0";
            }
        }

        private void chksony_CheckedChanged(object sender, EventArgs e)
        {
            if (ceng.Checked == true)
            {
                qtyeng.Enabled = true;
                qtyeng.Text = "0";
            }
        }

        private void chkmotorolla_CheckedChanged(object sender, EventArgs e)
        {
            if (ccvt.Checked == true)
            {
                qtycvt.Enabled = true;
                qtycvt.Text = "0";
            }
        }

        private void chkoneplus_CheckedChanged(object sender, EventArgs e)
        {
            if (cisl.Checked == true)
            {
                qtyisl.Enabled = true;
                qtyisl.Text = "0";
            }
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnplaceorder_Click(object sender, EventArgs e)
        {
            Reciept r = new Reciept();
            if (cmath.Checked == true)
                WindowsFormsApp2.Program.qmaths = Convert.ToInt32(qtymath.Text);
            if (cdsa.Checked == true)
                WindowsFormsApp2.Program.qdsa = Convert.ToInt32(qtydsa.Text);
            if (coose.Checked == true)
                WindowsFormsApp2.Program.qoose = Convert.ToInt32(qtyoose.Text);
            if (cjava.Checked == true)
                WindowsFormsApp2.Program.qjava = Convert.ToInt32(qtyjava.Text);
            if (ceng.Checked == true)
                WindowsFormsApp2.Program.qenglish = Convert.ToInt32(qtyeng.Text);
            if (ccvt.Checked == true)
                WindowsFormsApp2.Program.qcvt = Convert.ToInt32(qtycvt.Text);
            if (cisl.Checked == true)
                WindowsFormsApp2.Program.qisl = Convert.ToInt32(qtyisl.Text);
            Class1 c = new Class1();
            WindowsFormsApp2.Program.total = c.total(WindowsFormsApp2.Program.qmaths, WindowsFormsApp2.Program.qdsa, WindowsFormsApp2.Program.qoose, WindowsFormsApp2.Program.qjava, WindowsFormsApp2.Program.qenglish, WindowsFormsApp2.Program.qcvt, WindowsFormsApp2.Program.qisl, WindowsFormsApp2.Program.Mathematics, WindowsFormsApp2.Program.DSA, WindowsFormsApp2.Program.OOSE, WindowsFormsApp2.Program.Java, WindowsFormsApp2.Program.English, WindowsFormsApp2.Program.CVT, WindowsFormsApp2.Program.Islamiat);
            qtymath.Enabled = false;
            qtydsa.Enabled = false;
            qtyoose.Enabled = false;
            qtyjava.Enabled = false;
            qtyeng.Enabled = false;
            qtycvt.Enabled = false;
            qtyisl.Enabled = false;
            r.Show();
            this.Hide();

            
        }

        private void txtqtyapple_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
