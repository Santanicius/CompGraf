using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompGrafApp
{
    class CompET
    {
        private double xmin, ymax, incX;
        private CompET prox, ant;

        public CompET(double ymax, double xmin, double incX)
        {
            this.ymax = ymax;
            this.xmin = xmin;
            this.incX = incX;
            this.prox = this.Ant = null;
        }
        public CompET()
        {
            this.ymax = 0;
            this.xmin = 0;
            this.incX = 0;
            this.prox = this.Ant = null;
        }

        public double Xmin { get => xmin; set => xmin = value; }
        public double Ymax { get => ymax; set => ymax = value; }
        public double IncX { get => incX; set => incX = value; }
        internal CompET Prox { get => prox; set => prox = value; }
        internal CompET Ant { get => ant; set => ant = value; }
    }
}
