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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void form3button1_Click(object sender, EventArgs e)
        {
            label1.Text = Form1.Form1Instance.TargetStr;
        }
    }
}
