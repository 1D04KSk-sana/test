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
    public partial class Form1 : Form
    {
        //Form親プロジェクトを保持し親のインすタンスを公開する
        private static Form1 _form1Instance;

        //Form親オブジェクトを取得、設定するためのプロパティ
        public static Form1 Form1Instance
        {
            get
            {
                return _form1Instance;
            }
            set
            {
                _form1Instance = value;
            }
        }

        private string targetStr;
        public string TargetStr
        {
            get
            {
                return targetStr;
            }
            set
            {
                targetStr = value;
            }
        }


        public Form1()
        {
            InitializeComponent();

            comboBox1.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form2 form2 = new Form2();
            form2.ShowDialog(this);
            form2.Dispose();

            this.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Form1.Form1Instance = this;
            targetStr = "aiueo";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
