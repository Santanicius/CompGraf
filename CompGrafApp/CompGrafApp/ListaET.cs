using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompGrafApp
{
    class ListaET
    {
        private NoET L;

        internal NoET Lista { get => L; set => L = value; }

        public ListaET()
        {
            L = null;
        }
        public void exibir()
        {
            NoET aux = L;
            CompET auxcomp;
            while (aux != null)
            {
                Console.WriteLine(aux.Id+"");
                auxcomp = aux.Cabeca;
                while (auxcomp != null)
                {
                    Console.WriteLine("\t xmin "+auxcomp.Xmin+" ymax: "+auxcomp.Ymax+" incX: "+auxcomp.IncX);
                    auxcomp = auxcomp.Prox;
                }
                aux = aux.Prox;
            }
        }
        public void inserir(NoET no)
        {
            NoET aux;
            if (L == null)
                L = no;
            else
            {
                aux = L;
                while (aux.Prox != null)
                    aux = aux.Prox;
                aux.Prox = no;
            }
        }
        public NoET buscarNoET(double ymin)
        {
            NoET aux = L;
            while (aux != null && aux.Id != ymin)
                aux = aux.Prox;
            return aux;
        }
    }
}
