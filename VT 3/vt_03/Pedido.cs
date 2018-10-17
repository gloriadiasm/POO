using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace vt_03
{
    class Pedido
    {
        private String  s1, s2;
        int n1;

        public Pedido(int num1, string st1, string st2)
        {
            n1 = num1;
            s1 = st1;
            s2 = st2;
        }

        public string descricao()
        {
            return s2;
        }

        public string nome()
        {
            return s1;
        }

        public int codigo()
        {
            return n1;
        }

        public void modnome(string x)
        {
            s1 = x;
        }

        public void moddes(string y)
        {
            s2 = y;
        }
        

    }
}
