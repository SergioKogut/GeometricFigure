using System;

namespace GeometricFigure
{
    class Triangle : IFigure     
    {
        private double a, b, c;

        public Triangle(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

       public double GetArea()
        {
            double p = (a + b + c) / 2;
            return Math.Round(Math.Sqrt(p * (p - a) * (p - b) * (p - c)),2); 
        }

        public double  GetPerimetr()
        {
            return a+b+c;
        }
        
        public override string ToString()
        {
            return $" Triangle: a={a}cm, b={b}cm, c={c}cm\n Perimetr triangle:{GetPerimetr()}cm\n Area triangle:{GetArea()}cm2\n";
        }
    }
}
