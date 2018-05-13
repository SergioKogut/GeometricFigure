using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricFigure
{
    interface IFigure
    {
        double GetPerimetr();
        double GetArea();
     
    }

    
    class Triangle: IFigure     
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

    class CompoundFigures:List<IFigure>,IFigure 
    {

        public CompoundFigures(IEnumerable<IFigure> collection) : base(collection) => Console.WriteLine($"Capacity: {this.Capacity}");

        public CompoundFigures() => Console.WriteLine($"Capacity: {this.Capacity}");

        public new void Add(IFigure figure)
        {
            this.Add(figure);
        }

        public double GetArea()
        {
            double Sum=0;
             foreach (var figure in this)
            {
              Sum+=figure.GetArea();
            }
             return Sum;

        }
        public double GetPerimetr()
        {

              double P=0;
             foreach (var figure in this)
            {
              P+=figure.GetPerimetr();
            }
             return  P;
        }

        public override string ToString()
        {
            return $" Count figures: {this.Count()}p  All area: {GetArea()}cm2 ,All Perimetr {GetPerimetr()}cm \n";
        }


    }



    class Program
    {
        static void Main(string[] args)
        {

            List<IFigure> Figures=new List<IFigure> { new Triangle(10, 15, 20),    //трикутник
                                                      new Square(5),               //квадрат
                                                      new Rectangle(5, 12),        //прямокутник
                                                      new Rhomb(10, 5),            //ромб
                                                      new Parallelogram(10, 5, 4), //паралелограм
                                                      new Trapeze(10, 5, 4),       //трапеція
                                                      new Сircle(17),              //круг
                                                      new Ellipse(10,7)};          //еліпс


             
             IFigure CFigures = new  CompoundFigures(new IFigure[] {new Triangle(10, 15, 20),
                                                new Square(5)});
             IFigure BFigures = new  CompoundFigures(Figures);
             IFigure GFigures = new CompoundFigures();
            ((List<IFigure>)GFigures).Add(new Triangle(10, 15, 20));
            
          
            foreach (var figure in ((List<IFigure>)GFigures))
            {
                Console.WriteLine(figure);

            }


            Console.WriteLine(" FIGURES:\n");

            foreach (var figure in Figures)
            {
                Console.WriteLine(figure);

            }
              Console.WriteLine(CFigures); 
              Console.WriteLine(BFigures);
              Console.ReadLine();

            
    
        }
    }
}
