using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public int time_count = 0;//用于调整
        public int time_ = 0;//用于显示
        public int p = 120;
        

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label8.Text = p.ToString();
            double green = p * 0.4;
            double yellow = p * 0.5;
            double red = p * 0.9;
            time_count++;
            time_++;
            label5.Text = time_.ToString();
            double choose = time_count % p;
            if (choose >= 0 && choose < green)
            {
                //checkedListBox1.CheckOnClick = 0;
                label1.Text = "绿灯";
                label1.ForeColor = Color.Green;
                label3.Text = "绿灯";
                label3.ForeColor = Color.Green;
                label2.Text = "红灯";
                label2.ForeColor = Color.Red;
                label4.Text = "红灯";
                label4.ForeColor = Color.Red;
            }
            else if (choose >= green && choose < yellow)
            {
                label1.Text = "黄灯";
                label1.ForeColor = Color.Yellow;
                label3.Text = "黄灯";
                label3.ForeColor = Color.Yellow;
                label2.Text = "红灯";
                label2.ForeColor = Color.Red;
                label4.Text = "红灯";
                label4.ForeColor = Color.Red;
            }
            else if (choose >= yellow && choose < red)
            {
                label1.Text = "红灯";
                label1.ForeColor = Color.Red;
                label3.Text = "红灯";
                label3.ForeColor = Color.Red;
                label2.Text = "绿灯";
                label2.ForeColor = Color.Green;
                label4.Text = "绿灯";
                label4.ForeColor = Color.Green;
            }
            else
            {
                label1.Text = "红灯";
                label1.ForeColor = Color.Red;
                label3.Text = "红灯";
                label3.ForeColor = Color.Red;
                label2.Text = "黄灯";
                label2.ForeColor = Color.Yellow;
                label4.Text = "黄灯";
                label4.ForeColor = Color.Yellow
                    ;
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //切换周期
            timer1.Stop();
            label5.Text = 0.ToString();
            if (p == 120)
            {
                p = 60;
            }
            else
            {
                p = 120;
            }
            time_count = 0;
            time_ = 0;
            timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            切换 fo = new 切换();
            fo.ShowDialog();
            int wh = fo.which;
            if (wh == 1)
            {
                time_count = 0;
                time_ = 0;
                timer1.Start();
            }
            else if (wh == 2)
            {
                time_count = (int)(p * 0.4);
                time_ = 0;
                timer1.Start();
            }
            else
            {
                time_count = (int)(p * 0.5);
                time_ = 0;
                timer1.Start();
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
