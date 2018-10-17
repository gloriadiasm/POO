using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vt_5
{
    public partial class Form1 : Form
    {
        ClassAlunos objetoAluno;
        public static int quantidadeAlunos,notas,corte,alunos=0;
        public Form1()
        {
            
            InitializeComponent();

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void labelMediaNotasCorte_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void labelMediatotal_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBoxNotaAluno_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if(textBoxQuantidadeAlunos.Text == "")
            {
                objetoAluno = new ClassAlunos();
                
                MessageBox.Show("Inicialização realizada com sucesso!");
            }
            if (textBoxQuantidadeAlunos.Text == "0")
            {
                
                MessageBox.Show("O valor inserido nao é valido");
                return;

            }
            else
            {
                quantidadeAlunos = Convert.ToInt32(textBoxQuantidadeAlunos.Text);
                objetoAluno = new ClassAlunos(quantidadeAlunos);
                MessageBox.Show("Inicialização realizada com sucesso!");

            }



        }

        private void button3_Click(object sender, EventArgs e)
        {
            int mediacortealtas = 0, mediacorte = 0;
            corte = Convert.ToInt32(textBoxCorte.Text);
             objetoAluno.FuncaoCorte(corte);
            mediacorte = objetoAluno.Funcaomedia(mediacorte);
            labelMediatotal.Text = Convert.ToString(mediacorte);
            mediacortealtas = objetoAluno.funcaomediaMaior(mediacortealtas);
            labelMediaNotasCorte.Text = Convert.ToString(mediacortealtas);

        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (alunos < quantidadeAlunos)
            { 
            notas = Convert.ToInt32(textBoxNotaAluno.Text);
            objetoAluno.Receber(notas);
            alunos = objetoAluno.quantidadenotas(alunos);
            labelQuantidadeNotas.Text=Convert.ToString(alunos);
            }
            else
            {
                MessageBox.Show("o valor estrapolou a boca do balao");
            }

    }
    }
}




