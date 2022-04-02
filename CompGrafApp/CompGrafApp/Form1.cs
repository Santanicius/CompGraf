using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static CompGrafApp.Poligono;

namespace CompGrafApp
{
    public partial class Form1 : Form
    {
        private Point p_inicial, p_final;
        private Bitmap bmp, bmp_copia;
        private bool op_poli, p_clique;
        private List<Poligono> poligonos;
        private Poligono poli;
        public Form1()
        {
            InitializeComponent();
            p_inicial = new Point(-1, -1);
            p_final = new Point();

            bmp = new Bitmap(pb_quadro.Width, pb_quadro.Height);
            bmp_copia = new Bitmap(bmp);
            pb_quadro.Image = bmp;

            p_clique = true;
            rb_bresenham.Checked = true;

            poligonos = new List<Poligono>();
            initPInicial();
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
        }
        private void pb_soltou(object sender, MouseEventArgs e)
        {
            
            if (!op_poli)
            {
                pb_quadro.Image = bmp_copia;
                if (rb_elipse.Checked)
                    elipse();
                else if (rb_eqcirc.Checked)
                    eqCirc();
                else if (rb_pontomedio.Checked)
                    pontoMedio();
                else if (rb_eqtrig.Checked)
                    eqTrig();
                else if (rb_eqreta.Checked)
                    EqRealReta(Color.Black);
                else if (rb_dda.Checked)
                    dda(Color.Black);
                else if (rb_bresenham.Checked)
                    bresenham(p_inicial, p_final, Color.Black);
                initPInicial();
            }
        }

        private void pb_pressionou(object sender, MouseEventArgs e)
        {
            if (!op_poli)
            {
                p_inicial.X = e.X; 
                p_inicial.Y = e.Y;
            }
        }

        private void pb_quadro_Click(object sender, EventArgs e)
        {

        }

        private void pb_arrastando(object sender, MouseEventArgs e)
        {
            if (p_inicial.X != -1 && e.X>0 && e.X<pb_quadro.Width && e.Y>0 && e.Y<pb_quadro.Height)
            {
                p_final.X = e.X;
                p_final.Y = e.Y;
                bmp = new Bitmap(bmp_copia);
                pb_quadro.Image = bmp;
                if (rb_elipse.Checked)
                    elipse();
                else if (rb_eqcirc.Checked)
                    eqCirc();
                else if (rb_eqtrig.Checked)
                    eqTrig();
                else if (rb_pontomedio.Checked)
                    pontoMedio();
                else if (rb_eqreta.Checked)
                    EqRealReta(Color.Black);
                else if (rb_dda.Checked)
                    dda(Color.Black);
                else if (rb_bresenham.Checked)
                    bresenham(p_inicial, p_final, Color.Black);
                    
            }
        }
        private void elipse()
        {
            int a = Math.Abs(p_final.X-p_inicial.X), b = Math.Abs(p_final.Y-p_inicial.Y);
            int x = 0, y = b;
            double d1, d2;
            d1 = b * b - a * a * b + a * a / 4.0;
            simetria4(x, y);
            while (a * a * (y - 0.5) > b * b * (x + 1))
            {
                if (d1 < 0)
                {
                    d1 = d1 + b * b * (2 * x + 3);
                    x++;
                }
                else
                {
                    d1 = d1 + b * b * (2 * x + 3) + a * a * (-2 * y + 2);
                    x++;
                    y--;
                }
                simetria4(x, y);
            }
            d2 = b * b * (x + 0.5) * (x + 0.5) + a * a * (y - 1) * (y - 1) - a * a * b * b;
            while (y > 0)
            {
                if (d2 < 0)
                {
                    d2 = d2 + b * b * (2 * x + 2) + a * a * (-2 * y + 3);
                    x++; y--;
                }
                else
                {
                    d2 = d2 + a * a * (-2 * y + 3);
                    y--;
                }
                simetria4(x, y);
            }
        }
        private void pontoMedio()
        {
            double raio = Math.Sqrt(Math.Pow(p_final.X - p_final.X, 2) + Math.Pow(p_final.Y - p_inicial.Y, 2));
            double d = 1 - raio, y = raio;
            int x = 0;
            simetria8(x, y);
            while (y > x)
            {
                if (d < 0)
                    d += 2 * x + 3;
                else
                {
                    d += 2 * (x - y) + 5;
                    y--;
                }
                x++;
                simetria8(x, y);
            }
        }
        private void eqTrig()
        {
            double raio = Math.Sqrt(Math.Pow(p_final.X - p_final.X, 2) + Math.Pow(p_final.Y - p_inicial.Y, 2));
            double perimetro = 2 * Math.PI * raio;
            double esc = perimetro / 360;
            double inc = 1 / esc;
            if (inc > 0.25)
                inc = 0.25;
            for(double a=45; a<=90; a += 0.25)
                simetria8(raio * Math.Cos(a), raio * Math.Sin(a));
        }
        private void eqCirc()
        {
            double raio = Math.Sqrt(Math.Pow(p_final.X - p_final.X,2)+Math.Pow(p_final.Y-p_inicial.Y,2));
            double raio2 = Math.Pow(raio, 2);
            for (int x = 0; x < raio / Math.Sqrt(2); x++)
                simetria8(x, Math.Abs((int)Math.Sqrt(raio2-Math.Pow(x,2))));
        }
        private void simetria8(double x, double y)
        {
            int cx = p_inicial.X, cy = p_inicial.Y;
            mySetPixel(cx + x, cy + y,Color.Black);
            mySetPixel(cx + y, cy + x, Color.Black);
            mySetPixel(cx + y, cy - x, Color.Black);
            mySetPixel(cx + x, cy - y, Color.Black);
            mySetPixel(cx - x, cy - y, Color.Black);
            mySetPixel(cx - y, cy - x, Color.Black);
            mySetPixel(cx - y, cy + x, Color.Black);
            mySetPixel(cx - x, cy + y, Color.Black);
        }
        private void simetria4(double x, double y)
        {
            int cx = p_inicial.X, cy = p_inicial.Y;
            mySetPixel(cx + x, cy + y,Color.Black);
            mySetPixel(cx + x, cy - y,Color.Black);
            mySetPixel(cx - x, cy + y,Color.Black);
            mySetPixel(cx - x, cy - y,Color.Black);
        }
        private void mySetPixel(double x, double y, Color cor)
        {
            if(x>=0 && x<pb_quadro.Width && y>=0 && y<pb_quadro.Height)
                ((Bitmap)pb_quadro.Image).SetPixel((int)x, (int)y, cor);
        }
        private void bresenham(Point p1, Point p2, Color cor)
        {
            int dx = p2.X - p1.X;
            int dy = p2.Y - p1.Y;
            int declive, incE, incNE, d, y, x;
            if (Math.Abs(dx) > Math.Abs(dy))
            {
                if(p1.X > p2.X)
                    bresenham(p2, p1,cor);
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
                        mySetPixel(x, y, cor);
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
                    bresenham(p2, p1,cor);
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
                        mySetPixel(x, y, cor);
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

        private void rb_eqcirc_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void eq_trig_CheckedChanged(object sender, EventArgs e)
        {
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {
            rb_eqreta.Checked = false;
            rb_dda.Checked = false;
            rb_bresenham.Checked = false;
            rb_elipse.Checked = false;
        }

        private void gb_primitivas_Enter(object sender, EventArgs e)
        {
            rb_eqcirc.Checked = false;
            rb_pontomedio.Checked = false;
            rb_eqtrig.Checked = false;
            rb_elipse.Checked = false;
        }
        private void initRb()
        {
            rb_eqreta.Checked = false;
            rb_dda.Checked = false;
            rb_bresenham.Checked = false;
            rb_eqcirc.Checked = false;
            rb_pontomedio.Checked = false;
            rb_eqtrig.Checked = false;
            rb_elipse.Checked = false;
        }

        private void gb_elipse_Enter(object sender, EventArgs e)
        {
            rb_eqreta.Checked = false;
            rb_dda.Checked = false;
            rb_bresenham.Checked = false;
            rb_eqcirc.Checked = false;
            rb_pontomedio.Checked = false;
            rb_eqtrig.Checked = false;
        }

        private void rb_elipse_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void pb_quadro_MouseClick(object sender, MouseEventArgs e)
        {
            if (op_poli)
            {
                if (p_clique)
                {
                    poli = new Poligono();
                    p_inicial.X = e.X; p_inicial.Y = e.Y;
                    poli.inserir(p_inicial);
                    p_clique = false;
                }
                else
                {
                    pb_quadro.Image = bmp_copia;
                    bresenham(p_inicial, p_final,Color.Black);
                    poli.inserir(p_final);
                    p_inicial.X = e.X; p_inicial.Y = e.Y;
                }
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
           
        }

        private void tabControl1_Click(object sender, EventArgs e)
        {
            op_poli = false;
            if (tabControl1.SelectedTab.Text.Equals("Polígonos"))
            {
                cb_transf.SelectedIndex = 0;
                cb_trans.SelectedIndex = 0;
                op_poli = true;
                initRb();
                rb_bresenham.Checked = true;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bt_translacao_Click(object sender, EventArgs e)
        {
            //translação
            if (tb_x.Text != "" && tb_y.Text != "")
            {
                Console.WriteLine(cb_transf.SelectedItem.ToString());
                pb_quadro.Image = bmp_copia;
                int i = lv_poligonos.SelectedItems[0].Index;
                redesenhar_selecionado(Color.White);
                if (cb_transf.SelectedItem.ToString() == "Translação")
                    poligonos[i].transladar(Double.Parse(tb_x.Text), Double.Parse(tb_y.Text));

                atualizarList();
                lv_poligonos.Items[i].Selected = true;
                redesenhar_selecionado(Color.Black);
            }
            
        }
        private void redesenhar_selecionado(Color cor)
        {
            int i = lv_poligonos.SelectedItems[0].Index;
            for (int k = 0; k < poligonos[i].Pontos.Count; k++)
            {
                if (k != (poligonos[i].Pontos.Count - 1))
                    bresenham(poligonos[i].Pontos[k], poligonos[i].Pontos[k + 1], cor);
                else
                    bresenham(poligonos[i].Pontos[k], poligonos[i].Pontos[0], cor);
            }
        }
        private void pb_quadro_DoubleClick(object sender, EventArgs e)
        {
            if (op_poli) {
                p_clique = true;
                poli.calcCentro();
                poligonos.Add(poli);
                lv_poligonos.Items.Add("P"+poligonos.Count);
                lv_poligonos.Items[poligonos.Count - 1].SubItems.Add((Math.Truncate(poli.Cx*100)/100).ToString());
                lv_poligonos.Items[poligonos.Count - 1].SubItems.Add((Math.Truncate(poli.Cy * 100) / 100).ToString());
                initPInicial();
            }
        }
        private void bt_rotacao_Click(object sender, EventArgs e)
        {
            //rotação
            //verificar campos vazios
            if (lv_poligonos.SelectedItems.Count>0) {
                Console.WriteLine("Entrei");
                pb_quadro.Image = bmp_copia;
                int i = lv_poligonos.SelectedItems[0].Index;
                redesenhar_selecionado(Color.White);
                Console.WriteLine("selecionado: " + cb_trans.SelectedItem.ToString());
                if (cb_trans.SelectedItem.ToString() == "Rotação")
                    rotacao();
                else if (cb_trans.SelectedItem.ToString() == "Escala")
                    escala();


                atualizarList();
                lv_poligonos.Items[i].Selected = true;
                redesenhar_selecionado(Color.Black);
            }
        }
        private void rotacao()
        {
            int i = lv_poligonos.SelectedItems[0].Index;
            if (rb_centro.Checked)
            {
                //transladar para a origem
                poligonos[i].transladar(-poligonos[i].Cx, -poligonos[i].Cy);
                //rotacionar
                poligonos[i].rotacionar(Double.Parse(tb_angulo.Text));
                //transladar para a posição original
                poligonos[i].transladar(poligonos[i].Cx, poligonos[i].Cy);
            }
            else
            {
                poligonos[i].rotacionar(Double.Parse(tb_angulo.Text));
            }
        }
        private void escala()
        {
            int i = lv_poligonos.SelectedItems[0].Index;
            if (rb_centro.Checked)
            {
                //transladar para a origem
                poligonos[i].transladar(-poligonos[i].Cx, -poligonos[i].Cy);
                //escala
                poligonos[i].escala(Double.Parse(tb_x2.Text), Double.Parse(tb_y2.Text));
                //transladar para a posição original
                poligonos[i].transladar(poligonos[i].Cx, poligonos[i].Cy);
            }
            else
                poligonos[i].escala(Double.Parse(tb_x2.Text), Double.Parse(tb_y2.Text));
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cb_trans_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_trans.SelectedItem.ToString() == "Rotação")
            {
                lb_x.Hide();
                lb_y.Hide();
                tb_x2.Hide();
                tb_y2.Hide();
                lb_angulo.Show();
                tb_angulo.Show();
            }
            else if(cb_trans.SelectedItem.ToString() == "Escala"){
                lb_x.Show();
                lb_y.Show();
                tb_x2.Show();
                tb_y2.Show();
                lb_angulo.Hide();
                tb_angulo.Hide();
            }
        }

        private void atualizarList()
        {
            if (op_poli)
            {
                lv_poligonos.Items.Clear();
                for(int i=0; i<poligonos.Count; i++)
                {
                    poligonos[i].calcCentro();
                    lv_poligonos.Items.Add("P" + i);
                    lv_poligonos.Items[i].SubItems.Add((Math.Truncate(poligonos[i].Cx * 100) / 100).ToString());
                    lv_poligonos.Items[i].SubItems.Add((Math.Truncate(poligonos[i].Cy * 100) / 100).ToString());
                }
            }
        }

        private void dda(Color cor)
        {
            int tam;
            double x, y, xinc, yinc;
            tam = Math.Max(deltaY(), deltaX());

            xinc = (double)difX() / tam;
            yinc = (double)difY() / tam;

            x = p_inicial.X; y = p_inicial.Y;
            for(int i=0; i<tam; i++)
            {
                ((Bitmap)pb_quadro.Image).SetPixel((int)Math.Round(x), (int)Math.Round(y),cor);
                x += xinc;
                y += yinc;
            }
        }
        private void EqRealReta(Color cor)
        {
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
                    ((Bitmap)pb_quadro.Image).SetPixel(x, (int)Math.Round(y), cor);
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
                    ((Bitmap)pb_quadro.Image).SetPixel((int)Math.Round(x), y, cor);
                }
            }
            
        }

    }
}
