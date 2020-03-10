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
    public partial class 切换 : Form
    {
        public int which;
        public 切换()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                which = 1;
            }
            else if (radioButton2.Checked)
            {
                which = 2;
            }
            else
            {
                which = 3;
            }
            this.Close();
        }
    }
}
