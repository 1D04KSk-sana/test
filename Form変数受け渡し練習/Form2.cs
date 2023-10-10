using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form変数受け渡し練習
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void form2button1_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.ShowDialog(this);
            form3.Dispose();
        }

        private void form2button2_Click(object sender, EventArgs e)
        {
            //int cmb = ((Form1)this.Owner).comboBox1.Items.Count;
            //label1.Text = Form1.Form1Instance.TargetStr;
            label1.Text = "aiueo";
        }

        private void form2button3_Click(object sender, EventArgs e)
        {
            Form1.Form1Instance.TargetStr = "ABCDE";
            label1.Text = Form1.Form1Instance.TargetStr;
        }
    }
}
