using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompGrafApp
{
    public partial class Form1 : Form
    {
        private Point p_inicial, p_final;
        private Bitmap bmp, bmp_copia;
        public Form1()
        {
            InitializeComponent();
            p_inicial = new Point(-1, -1);
            p_final = new Point();

            bmp = new Bitmap(pb_quadro.Width, pb_quadro.Height);
            bmp_copia = new Bitmap(bmp);
            pb_quadro.Image = bmp;
        }
        private void initPInicial()
        {
            p_inicial.X = p_inicial.Y = -1;
        }
        private int deltaX()
        {
            return Math.Abs(p_final.X - p_inicial.X);
        }
        private int difX()
        {
            return p_final.X - p_inicial.X;
        }
        private int deltaY()
        {
            return Math.Abs(p_final.Y - p_inicial.Y);
        }
        private int difY()
        {
            return p_final.Y - p_inicial.Y;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void rb_retas_CheckedChanged(object sender, EventArgs e)
        {
            //equação real da reta
            //initRbRetas();
           // rb_eqreta.Checked = true;
        }
        private void initRbRetas()
        {
            rb_eqreta.Checked = false;
            rb_dda.Checked = false;
            rb_bresenham.Checked = false;
        }

        private void pb_soltou(object sender, MouseEventArgs e)
        {
            pb_quadro.Image = bmp_copia;
            if (rb_eqreta.Checked)
                eqRealReta();
            else if (rb_dda.Checked)
                dda();
            else if (rb_bresenham.Checked)
                bresenham(p_inicial,p_final);
            initPInicial();
        }

        private void pb_clicou(object sender, MouseEventArgs e)
        {
            p_inicial.X = e.X; p_inicial.Y = e.Y;
        }

        private void pb_quadro_Click(object sender, EventArgs e)
        {

        }

        private void pb_pressionado(object sender, MouseEventArgs e)
        {
            if (p_inicial.X != -1 && e.X>0 && e.X<pb_quadro.Width && e.Y>0 && e.Y<pb_quadro.Height)
            {
                p_final.X = e.X;
                p_final.Y = e.Y;
                bmp = new Bitmap(bmp_copia);
                pb_quadro.Image = bmp;
                if (rb_eqreta.Checked)
                    eqRealReta();
                else if (rb_dda.Checked)
                    dda();
                else if (rb_bresenham.Checked)
                    bresenham(p_inicial,p_final);
            }
        }
        private void bresenham(Point p1, Point p2)
        {
            int dx = p2.X - p1.X;
            int dy = p2.Y - p1.Y;
            int declive, incE, incNE, d, y, x;
            if (Math.Abs(dx) > Math.Abs(dy))
            {
                if(p1.X > p2.X)
                    bresenham(p2, p1);
                else
                {
                    declive = 1;
                    if (dy < 0)
                    {
                        declive = -1;
                        dy = -dy;
                    }
                    incE = 2 * dy;
                    incNE = incE - 2 * dx;
                    d = incE - dx;
                    y = p1.Y;
                    for(x = p1.X; x <= p2.X; x++)
                    {
                        ((Bitmap)pb_quadro.Image).SetPixel(x, y, Color.Black);
                        if (d <= 0)
                            d += incE;
                        else
                        {
                            d += incNE;
                            y += declive;
                        }
                    }
                }
            }
            else
            {
                if (p1.Y > p2.Y)
                    bresenham(p2, p1);
                else
                {
                    declive = 1;
                    if (dx < 0)
                    {
                        declive = -1;
                        dx = -dx;
                    }
                    incE = 2 * dx;
                    incNE = incE - 2 * dy;
                    d = incE - dy;
                    x = p1.X;
                    for (y = p1.Y; y <= p2.Y; y++)
                    {
                        ((Bitmap)pb_quadro.Image).SetPixel(x, y, Color.Black);
                        if (d <= 0)
                            d += incE;
                        else
                        {
                            d += incNE;
                            x += declive;
                        }
                    }
                }
            }
        }
        private void dda()
        {
            int tam;
            double x, y, xinc, yinc;
            tam = Math.Max(deltaY(), deltaX());

            xinc = (double)difX() / tam;
            yinc = (double)difY() / tam;

            x = p_inicial.X; y = p_inicial.Y;
            for(int i=0; i<tam; i++)
            {
                ((Bitmap)pb_quadro.Image).SetPixel((int)Math.Round(x), (int)Math.Round(y),Color.Black);
                x += xinc;
                y += yinc;
            }
        }
        private void eqRealReta()
        {
            Console.WriteLine("Equação Real");
            int inc, yi, xi; ;
            double m;

            m = difX();
            m = m == 0 ? 0 : difY() / m;

            if (deltaX() > deltaY())
            {
                double y;
                if (difX() < 0)//x2 < x1
                {
                    inc = -1;
                    yi = p_final.Y;
                    xi = p_final.X;
                }
                else
                {
                    inc = 1;
                    yi = p_inicial.Y;
                    xi = p_inicial.X;
                }
                for (int x = p_inicial.X; x != p_final.X; x += inc)
                {
                    y = yi + m * (x - xi);
                    ((Bitmap)pb_quadro.Image).SetPixel(x, (int)Math.Round(y), Color.Black);
                }
            }
            else
            {
                double x;
                if (difY() < 0)// y2 < y1
                {
                    inc = -1;
                    yi = p_final.Y;
                    xi = p_final.X;
                }
                else
                {
                    inc = 1;
                    yi = p_inicial.Y;
                    xi = p_inicial.X;
                }
                for (int y = p_inicial.Y; y != p_final.Y; y += inc)
                {
                    if (m == 0) x = xi;
                    else
                        x = xi + (y - yi) / m;
                    ((Bitmap)pb_quadro.Image).SetPixel((int)Math.Round(x), y, Color.Black);
                }
            }
            
        }

    }
}
