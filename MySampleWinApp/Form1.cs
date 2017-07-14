using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MySampleWinApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var resp = CalulateLogicTC1(2,5);

            label1.Text = "Done - " + resp;
        }

        public int CalulateLogicTC1(int a, int b)
        {
            return (a + b) * a;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var resp = CalulateLogicTC2(2, 5);

            label1.Text = "OK Done - " + resp;
        }

        public int CalulateLogicTC2(int a, int b)
        {
            return a + b * a ;
        }
    }
}
