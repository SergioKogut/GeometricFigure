namespace GeometricFigure
{
    class Parallelogram : IFigure
    {
        private double a, b,h;

        public Parallelogram(double a, double b, double h)
        {
            this.a = a;
            this.b = b;
            this.h = h;
        }

        public double GetArea()
        {
            return a * h;
        }

        public double GetPerimetr()
        {
            return 2 * a + 2 * b;
        }

        public override string ToString()
        {
            return $" Parallelogram: a={a}cm, b={b}cm, h={h}cm\n Perimetr parallelogram:{GetPerimetr()}cm\n Area parallelogram:{GetArea()}cm2\n";
        }
    }
}
