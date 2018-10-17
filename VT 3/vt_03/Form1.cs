using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace vt_03
{
    public partial class Form1 : Form
    {
        private int quantidades = 100;
        private int indice;
        Pedido[] ObjetoPedido;
        int indiceProcurado = 0;
        public Form1()
        {
            InitializeComponent();
            ObjetoPedido = new Pedido[quantidades];

        }
        public void button1_Click(object sender, EventArgs e)
        {
                int num1 = int.Parse(textBox1.Text);
                string st2 = Convert.ToString(textBox2.Text);
                string st3 = Convert.ToString(textBox3.Text);
                ObjetoPedido[indice] = new Pedido (num1, st2, st3);
                indice++;

                if (num1.Equals(-1)) label4.Text = ("Digite um código!");
            
                else label4.Text = ("");

                if (st2.Equals("")) label5.Text = ("Digite um nome!");
                else label5.Text = ("");

                if (st3.Equals("")) label6.Text = ("Digite uma descrição!");
     
                else label6.Text = ("");

                listBox1.Items.Add(" "+num1 + " "+st2 + " "+st3);
        
        }
        
        public  void button4_Click(object sender, EventArgs e)
        {
            int cod = int.Parse(textBox4.Text);

            for (int i = 0; i < indice; i++)
            {
                if (ObjetoPedido[i].codigo() == cod)
                {
                    label8.Text = ObjetoPedido[i].nome();
                    label9.Text = ObjetoPedido[i].descricao();
                    indiceProcurado = i;
                }
            }
        }

        public void button2_Click(object sender, EventArgs e)
        {
            string st1 = Convert.ToString(textBox5.Text);
            string st2 = Convert.ToString(textBox6.Text);

            ObjetoPedido[indiceProcurado].modnome(st1);
            ObjetoPedido[indiceProcurado].moddes(st2);
           
        }
    }
}
