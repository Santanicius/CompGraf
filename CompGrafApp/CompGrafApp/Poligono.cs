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
        private bool foodfill, scanline;
        private Color cor;
        private List<Point> semente, semente_original;
        public Poligono(List<Point> lpontos)
        {
            Foodfill = Scanline = false;
            pontos = new List<Point>(lpontos);
            p_originais = new List<Point>(lpontos);
            ma = new double[3, 3] { { 1, 0, 0 }, { 0, 1, 0 }, { 0, 0, 1 } };
            Semente = new List<Point>();
            Semente_original = new List<Point>();
            calcCentro();
        }
        public Poligono() : this(new List<Point>())
        {
        }
        public List<Point> Pontos { get => pontos; set => pontos = value; }
        public double Cx { get => cx; }
        public double Cy { get => cy; }
        public bool Foodfill { get => foodfill; set => foodfill = value; }
        public bool Scanline { get => scanline; set => scanline = value; }
        public Color Cor { get => cor; set => cor = value; }
        public List<Point> Semente { get => semente; set => semente = value; }
        public List<Point> Semente_original { get => semente_original; set => semente_original = value; }

        public double maxY()
        {
            double max = pontos[0].Y;
            foreach(Point p in pontos)
            {
                max = Math.Max(p.Y, max);
            }
            return max;
        }
        public double minY()
        {
            double min = pontos[0].Y;
            foreach (Point p in pontos)
            {
                min = Math.Min(p.Y, min);
            }
            return min;
        }
        public void inserir(Point p)
        {
            pontos.Add(p);
            p_originais.Add(p);
        }
        public void inserirSemente(Point s)
        {
            Semente_original.Add(s);
            Semente.Add(s);
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
            double[,] mr = new double[3, 3] { {Math.Cos(radianos(graus)),-Math.Sin(radianos(graus)),0},{Math.Sin(radianos(graus)),Math.Cos(radianos(graus)),0},{0,0,1} };

            atualizar_pontos(mr);
        }
        public void reflexaoX()
        {
            Console.WriteLine("Reflexao x");
            double[,] mr = new double[3, 3] { { 1, 0, 0 }, { 0, -1, 0 }, { 0, 0, 1 } };
            atualizar_pontos(mr);
        }
        public void reflexaoY()
        {
            Console.WriteLine("Reflexao y");
            double[,] mr = new double[3, 3] { { -1, 0, 0 }, { 0, 1, 0 }, { 0, 0, 1 } };
            atualizar_pontos(mr);
        }
        public void cisalhamentoY(double a)
        {
            double[,] mc = new double[3, 3] { { 1, 0, 0 }, { a, 1, 0 }, { 0, 0, 1 } };
            atualizar_pontos(mc);
        }
        public void cisalhamentoX(double b)
        {
            double[,] mc = new double[3, 3] { { 1, b, 0 }, { 0, 1, 0 }, { 0, 0, 1 } };
            atualizar_pontos(mc);
        }
        public void escala(double sx, double sy)
        {
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
            double[,] mtemp;
            ma = mult(mt, ma);

            for (int i = 0; i < pontos.Count; i++)
            {
                mtemp = new double[3, 1] { { p_originais[i].X }, { p_originais[i].Y }, { 1 } };
                mtemp = mult(ma, mtemp);
                pontos[i] = new Point((int)Math.Round(mtemp[0, 0]), (int)Math.Round(mtemp[1, 0]));
            }        
        }
        public void atualizar_semente()
        {
            if (foodfill)
            {
                double[,] mtemp;
                for (int i=0; i<Semente.Count; i++)
                {
                   mtemp = new double[3, 1] { { Semente_original[i].X }, { Semente_original[i].Y }, { 1 } };
                   mtemp = mult(ma, mtemp);
                   Semente[i] = new Point((int)Math.Round(mtemp[0, 0]), (int)Math.Round(mtemp[1, 0]));
                }
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
