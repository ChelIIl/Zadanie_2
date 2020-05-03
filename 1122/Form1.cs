using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1122
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void check_Click(object sender, EventArgs e)
        {
            int n, n1, n2, re;

            n = Convert.ToInt16(num.Text);

            n1 = n / 10;
            n2 = n % 10;

            re = n1 + n2;

            if (re % 3 == 0)
                rez.Text = "Да";
            else
                rez.Text = "Нет";
        }
    }
}
