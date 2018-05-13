namespace GeometricFigure
{
    class Rhomb : IFigure
    {
        private double a,h;

        public Rhomb(double a, double h)
        {
            this.a = a;
            this.h = h;
        }

        public double GetArea()
        {
            return a * h;
        }

        public double GetPerimetr()
        {
            return 4*a;
        }

        public override string ToString()
        {
            return $" Rhomb: a={a}cm, h={h}cm\n Perimetr rhomb:{GetPerimetr()}cm\n Area rhomb:{GetArea()}cm2\n";
        }
    }
}
