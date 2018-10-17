using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio_2_vt2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double carroNovo, carroUsado, valorPagar;
            string parcelas;
            parcelas = parcelaBox.SelectedItem.ToString();
            carroNovo = Convert.ToDouble(carroNovoBox.Text);
            carroUsado = Convert.ToDouble(carroUsadoBox.Text);

            ClasseCarros carro = new ClasseCarros(carroNovo, carroUsado);
            carro.CalculaVlrPagar(parcelas);
            valorPagar = carro.vlrParcelas(parcelas);

            pagarLabel.Text = Convert.ToString(carro.TotalValor());
            parcelaLabel.Text = Convert.ToString(carro.vlrParcelas(parcelas));
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
