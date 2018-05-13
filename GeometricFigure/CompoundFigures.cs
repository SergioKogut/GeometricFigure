using System;
using System.Collections.Generic;
using System.Linq;

namespace GeometricFigure
{
    class CompoundFigures :List<IFigure>,IFigure 
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
}
