using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompGrafApp
{
    class NoET
    {
        private CompET cabeca;
        private NoET prox;
        private double id;

        public NoET(double id)
        {
            cabeca = null;
            prox = null;
            this.id = id;
        }
        private CompET ultimoComp()
        {
            CompET aux = cabeca;
            if (aux != null)
                while (aux.Prox != null)
                {
                    //Console.WriteLine("-> "+aux.Xmin+" "+aux.Ymax+" "+aux.IncX);
                    aux = aux.Prox;
                }
            return aux;
        }
        public void incrementarXmin()
        {
            CompET aux = cabeca;
            while (aux != null)
            {
                aux.Xmin = aux.Xmin + aux.IncX;
                aux = aux.Prox;
            }
        }
        public void ordenar()//bolha
        {
            CompET inicio, fim, aux;
            fim = ultimoComp();
            aux = fim;
            double xmin, ymax, incx;
            if(cabeca!=null)
                while (aux != cabeca)
                {
                    inicio = cabeca;
                    while (inicio != fim)
                    {
                        if (inicio.Xmin > inicio.Prox.Xmin)
                        {
                            xmin = inicio.Xmin;
                            ymax = inicio.Ymax;
                            incx = inicio.IncX;
                            inicio.Xmin = inicio.Prox.Xmin;
                            inicio.Ymax = inicio.Prox.Ymax;
                            inicio.IncX = inicio.Prox.IncX;
                            inicio.Prox.Xmin = xmin;
                            inicio.Prox.Ymax = ymax;
                            inicio.Prox.IncX = incx;
                        }
                        inicio = inicio.Prox;
                    }
                    aux = aux.Ant;
                }
        }
        public void inserir(CompET no)
        {
            if (cabeca == null)
                cabeca = no;
            else
            {
                no.Prox = cabeca;
                cabeca.Ant = no;
                cabeca = no;
            }
        }
        public void exibir()
        {
            CompET aux = cabeca;
            if (aux == null)
                Console.WriteLine("Vazia");
            while (aux != null)
            {
                Console.WriteLine(" | "+aux.Xmin+" "+aux.Ymax+" "+aux.IncX+" | ");
                aux = aux.Prox;
            }
        }
        public CompET buscar(CompET no)
        {
            CompET aux = cabeca;
            while (aux != null && aux != no)
                aux = aux.Prox;
            return aux;
        }
        public void remover(CompET no)
        {
            CompET aux = no;
            if (aux != null)
            {
                if (aux == cabeca)
                {
                    cabeca = cabeca.Prox;
                    if(cabeca!=null)
                        cabeca.Ant = null;
                }
                else
                {
                    aux.Ant.Prox = aux.Prox;
                    if(aux.Prox!=null)
                        aux.Prox.Ant = aux.Ant;
                }
            }
        }
        public double Id { get => id; set => id = value; }
        internal CompET Cabeca { get => cabeca; set => cabeca = value; }
        internal NoET Prox { get => prox; set => prox = value; }
    }
}
