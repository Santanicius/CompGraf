using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompGrafApp
{
    class Poligono
    {
        private List<Point> pontos;
        private List<Point> p_originais;
        private double[,] ma;
        private double cx, cy;
        public Poligono(List<Point> lpontos)
        {
            pontos = new List<Point>(lpontos);
            p_originais = new List<Point>(lpontos);
            ma = new double[3, 3] { { 1, 0, 0 }, { 0, 1, 0 }, { 0, 0, 1 } };
            calcCentro();
        }
        public Poligono() : this(new List<Point>())
        {
        }
        public List<Point> Pontos { get => pontos; set => pontos = value; }
        public double Cx { get => cx; }
        public double Cy { get => cy; }
        public void inserir(Point p)
        {
            pontos.Add(p);
            p_originais.Add(p);
        }
        public void calcCentro()
        {
            double somax = 0, somay = 0;
            foreach (Point p in pontos)
            {
                somax += p.X;
                somay += p.Y;
            }
            this.cx = somax; this.cy = somay;

            if (pontos.Count > 0)
            {

                this.cx = this.cx / pontos.Count;
                this.cy = this.cy / pontos.Count;
            }
        }
        public double radianos(double graus)
        {
            return graus * (Math.PI / 180);
        }
        public void rotacionar(double graus)
        {
            double[,] mtemp;
            double[,] mr = new double[3, 3] { {Math.Cos(radianos(graus)),-Math.Sin(radianos(graus)),0},{Math.Sin(radianos(graus)),Math.Cos(radianos(graus)),0},{0,0,1} };

            atualizar_pontos(mr);
        }

        public void escala(double sx, double sy)
        {
            double[,] mtemp;
            Console.WriteLine("sx: " + sx + " sy: " + sy);
            double[,] me = new double[3, 3] { { sx, 0, 0 }, { 0, sy, 0}, { 0, 0, 1 } };

            atualizar_pontos(me);
        }
        public void transladar(double tx, double ty)
        {
            double[,] mtemp;
            double[,] mt = new double[3, 3] { { 1, 0, tx }, { 0, 1, ty }, { 0, 0, 1 } };

            atualizar_pontos(mt);
        }
        private void atualizar_pontos(double [,] mt)
        {
            Console.WriteLine("Matriz escala: ");
            exibirMat(mt);
            double[,] mtemp;
            ma = mult(mt, ma);
            for (int i = 0; i < pontos.Count; i++)
            {
                mtemp = new double[3, 1] { { p_originais[i].X }, { p_originais[i].Y }, { 1 } };
                mtemp = mult(ma, mtemp);
                pontos[i] = new Point((int)Math.Round(mtemp[0, 0]), (int)Math.Round(mtemp[1, 0]));
            }
        }
        private double[,] mult(double[,] A, double[,] B)
        {
            double[,] C = new double[A.GetLength(0), B.GetLength(1)];
            for (int i = 0; i < A.GetLength(0); i++)
                for (int j = 0; j < B.GetLength(1); j++)
                    for (int k = 0; k < A.GetLength(1); k++)
                        C[i, j] = C[i, j] + A[i, k] * B[k, j];
            return C;
        }
        public void exibirMat(double[,] mat){
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                    Console.Write(mat[i, j]+" ");
                Console.WriteLine();
            }
        }

    }
}
