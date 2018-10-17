using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vt_5
{
    class ClassAlunos
    {
        public int [] quantidade;       
        public int indice = 0;
        public int Vetorcorte;
        
        

        public ClassAlunos()
        {
            quantidade =new int [30];
            indice = 0;
            

        }
        public ClassAlunos(int quantidadeAlunos)
        {
            quantidade =new int [quantidadeAlunos];
            indice = 0;
            

        }
        public int Receber(int nota)
        {
            
            for (int i = 0; i < 50; i++)
            {
                if (quantidade[i] == 0)
                {
                    quantidade[indice] = nota;
                    i = 50;

                }
                
            }
            
                indice++;
                        
            return nota;
        }

        public int quantidadenotas(int alunos)
        {
            alunos++;
            return alunos;
        }
        public int FuncaoCorte(int corte)
        {
            Vetorcorte = corte;
            return corte;
        }
       public int Funcaomedia(int media)
       {
            int cont = 0;
            for(int i = 0; i < indice; i++)
            {
                media +=  quantidade[i];
                cont++;

            }
            media = (media /cont);
            return media;
        }


        public int funcaomediaMaior(int mediamaior)
        {
            int cont=0;
            for (int i = 0; i < indice; i++)
            {
                if (quantidade[i] > Vetorcorte) { 
                 mediamaior += quantidade[i];
                    cont++;
                }
            }

            mediamaior = (mediamaior / cont);

            return mediamaior;
        }

    }


   
}

