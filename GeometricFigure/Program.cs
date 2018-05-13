using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GeometricFigure
{



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
             IFigure BFigures = new CompoundFigures(Figures);
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
