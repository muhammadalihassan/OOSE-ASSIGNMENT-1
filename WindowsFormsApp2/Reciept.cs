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
    public partial class Reciept : Form
    {
        public Reciept()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Reciept_Load(object sender, EventArgs e)
        {
           
            reciepttxt.AppendText("Date:  \t" + DateTime.Now.ToLongDateString() + Environment.NewLine);
            reciepttxt.AppendText(Environment.NewLine);
            reciepttxt.AppendText("--------------------------------------------------------------------------------------------------------" + Environment.NewLine);
            reciepttxt.AppendText(Environment.NewLine);
            reciepttxt.AppendText("Books\t\tQuantity\t\tPrice Per Unit\tTotal" + Environment.NewLine);
            reciepttxt.AppendText("Mathematics\t" + WindowsFormsApp2.Program.qmaths + "\t\t" + WindowsFormsApp2.Program.Mathematics + "\t\t" + (WindowsFormsApp2.Program.qmaths * WindowsFormsApp2.Program.Mathematics) + Environment.NewLine);
            reciepttxt.AppendText("DSA\t\t" + WindowsFormsApp2.Program.qdsa + "\t\t" + WindowsFormsApp2.Program.DSA + "\t\t" + (WindowsFormsApp2.Program.qdsa * WindowsFormsApp2.Program.DSA) + Environment.NewLine);
            reciepttxt.AppendText("OOSE\t\t" + WindowsFormsApp2.Program.qoose + "\t\t" + WindowsFormsApp2.Program.OOSE + "\t\t" + (WindowsFormsApp2.Program.qoose * WindowsFormsApp2.Program.OOSE) + Environment.NewLine);
            reciepttxt.AppendText("Java\t\t" + WindowsFormsApp2.Program.qjava + "\t\t" + WindowsFormsApp2.Program.Java + "\t\t" + (WindowsFormsApp2.Program.qjava * WindowsFormsApp2.Program.Java) + Environment.NewLine);
            reciepttxt.AppendText("English\t\t" + WindowsFormsApp2.Program.qenglish + "\t\t" + WindowsFormsApp2.Program.English + "\t\t" + (WindowsFormsApp2.Program.qenglish * WindowsFormsApp2.Program.English) + Environment.NewLine);
            reciepttxt.AppendText("CVT\t\t" + WindowsFormsApp2.Program.qcvt+ "\t\t" + WindowsFormsApp2.Program.CVT + "\t\t" + (WindowsFormsApp2.Program.qcvt * WindowsFormsApp2.Program.CVT) + Environment.NewLine);
            reciepttxt.AppendText("Islamiat\t\t" + WindowsFormsApp2.Program.qisl + "\t\t" + WindowsFormsApp2.Program.Islamiat + "\t\t" + (WindowsFormsApp2.Program.qisl * WindowsFormsApp2.Program.Islamiat) + Environment.NewLine);
            reciepttxt.AppendText(Environment.NewLine);
            reciepttxt.AppendText("--------------------------------------------------------------------------------------------------------" + Environment.NewLine);
            reciepttxt.AppendText("Total\t\t\t\t\t\t" + WindowsFormsApp2.Program.total + Environment.NewLine);
        }

        private void txtclose_Click(object sender, EventArgs e)
        {
            this.Close();
            WindowsFormsApp2.Program.qmaths = 0;
            WindowsFormsApp2.Program.qdsa = 0;
            WindowsFormsApp2.Program.qoose = 0;
            WindowsFormsApp2.Program.qjava = 0;
            WindowsFormsApp2.Program.qenglish = 0;
            WindowsFormsApp2.Program.qcvt = 0;
            WindowsFormsApp2.Program.qisl = 0;
        }
    }
}
