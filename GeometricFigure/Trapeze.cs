using System;

namespace GeometricFigure
{
    class Trapeze : IFigure
    {
        private double a, b, h;

        public Trapeze(double a, double b, double h)
        {
            this.a = a;
            this.b = b;
            this.h = h;
        }

        public double GetArea()
        {
            return Math.Round(0.5 *(a +b)*h,2);
        }

        public double GetPerimetr()
        {
            return 2 * a + 2 * b;
        }

        public override string ToString()
        {
            return $" Trapeze: a={a}cm, b={b}cm, h={h}cm\n Perimetr trapeze:{GetPerimetr()}cm\n Area trapeze:{GetArea()}cm2\n";
        }
    }
}
