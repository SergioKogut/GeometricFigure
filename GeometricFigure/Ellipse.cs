using System;

namespace GeometricFigure
{
    class Ellipse : IFigure
    {
        private double a,b;

        public Ellipse(double a, double b)
        {
            this.a = a;
            this.b = b;

        }

        public double GetArea()
        {
            return Math.Round(Math.PI * a * b,2);
        }

        public double GetPerimetr()
        {
            return Math.Round(2 * Math.PI*Math.Sqrt(0.5*(a*a+b*b)),2);
        }

        public override string ToString()
        {
            return $" Ellipse: small semiosphere ellipse a={a}cm, large semiosphere ellipse b={b}cm \n Lenght ellipse:{GetPerimetr()}cm\n Area ellipse:{GetArea()}cm2\n";
        }
    }
}
