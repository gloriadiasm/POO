using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VT_2___exe_3
{
    class CorrenteM // Corrente media do diodo
    {
        double TST;
        double Rcarga;
        double vmax;
        double vt;
        double vmed;
        double imed;
        double idmed;
        double tipo;

        public CorrenteM(double n1, double n2, double n3)
        {
            TST = n1;
            Rcarga = n2;
            tipo = n3;
            if (tipo == 1)
            {
                vt = 0.2;
            }
            else vt = 0.3;
        }
        public void CalTensao()
        {
            vmax = TST * 1.414;
            vmed = (0.636 * vmax) - 2 * vt;
     
        }
      
        public void CalCorrente()
        {
            imed = vmed / Rcarga;
           
        }

        public double CalCorrenteM()
        {
            CalTensao();
            CalCorrente();
            idmed = 0.5 * imed;
            return idmed;
        }

        
    
    }
}
