using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VT_2___exe_3
{
    public partial class Form1 : Form
    {
        CorrenteM ObjCM;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            double n1, n2, n3;

            n1 = Convert.ToDouble(textBox1.Text);
            n2 = Convert.ToDouble(textBox2.Text);
            n3 = Convert.ToDouble(textBox3.Text);

            ObjCM = new CorrenteM(n1, n2, n3);

            label4.Text = Convert.ToString(ObjCM.CalCorrenteM()); //If `method to group` to object --> put the "()" after the function
        }
    }
}
