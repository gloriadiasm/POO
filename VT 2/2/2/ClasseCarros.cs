using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_2_vt2
{
    class ClasseCarros
    {
        double novoCarro, usadoCarro, valorPagar, valorParcelas, valorTotal;
        string numParcelas;

        public ClasseCarros(double nCarro, double uCarro)
        {
            novoCarro = nCarro;
            usadoCarro = uCarro;
        }
        public double CalculaVlrPagar(string numParc)
        {
            numParcelas = numParc;

            switch (numParcelas)
            {
                case "x1":

                    valorPagar = novoCarro - usadoCarro;
                    valorPagar = valorPagar - (valorPagar * 0.03);
                    valorTotal = valorPagar;

                    break;
                case "x12":
                    valorPagar = novoCarro - usadoCarro;
                    valorPagar = valorPagar + (valorPagar * 0.15);

                    break;

                case "x24":
                    valorPagar = novoCarro - usadoCarro;
                    valorPagar = valorPagar + (valorPagar * 0.25);

                    break;


            }
            return valorPagar;
        }

        public double vlrParcelas(string parcelas)
        {
            numParcelas = parcelas;
            switch (numParcelas)
            {
                case "x1":
                    valorTotal = valorPagar;

                    break;
                case "x12":
                    valorParcelas = valorPagar / 12;
                    valorTotal = valorParcelas * 12;

                    break;

                case "x24":
                    valorParcelas = valorPagar / 24;
                    valorTotal = valorParcelas * 24;

                    break;
            }
            return valorParcelas;

        }
        public double TotalValor()
        {
            return valorTotal;
        }
    }
}
