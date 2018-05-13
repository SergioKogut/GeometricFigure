namespace GeometricFigure
{
    class Rectangle : IFigure
    {
        private double a, b;

        public Rectangle(double a, double b)
        {
            this.a = a;
            this.b = b;
        }

        public double GetArea()
        {
            return a * b;
        }

        public double GetPerimetr()
        {
            return 2 * a + 2 * b;
        }

        public override string ToString()
        {
            return $" Rectangle: a={a}cm, b={b}cm\n Perimetr rectangle:{GetPerimetr()}cm\n Area rectangle:{GetArea()}cm2\n";
        }
    }
}
