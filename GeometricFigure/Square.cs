namespace GeometricFigure
{
    class Square : IFigure
    {
        private double a;

        public Square(double a)
        {
            this.a = a;
        }

        public double GetArea()
        {
            return a*a;
        }

        public double GetPerimetr()
        {
            return 4*a;
        }

        public override string ToString()
        {
            return $" Square: a={a}cm\n Perimetr square:{GetPerimetr()}cm\n Area square:{GetArea()}cm2\n";
        }
    }
}
