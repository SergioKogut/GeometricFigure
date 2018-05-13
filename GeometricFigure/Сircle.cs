using System;

namespace GeometricFigure
{
    class Сircle : IFigure
    {
        private double r;

        public Сircle(double r)
        {
            this.r = r;
            
        }

        public double GetArea()
        {
            return Math.Round(Math.PI*r*r,2);
        }

        public double GetPerimetr()
        {
            return Math.Round(2 * Math.PI * r,2);
        }

        public override string ToString()
        {
            return $" Сircle: radius r={r}cm\n Lenght circle:{GetPerimetr()}cm\n Area circle:{GetArea()}cm2\n";
        }
    }
}
