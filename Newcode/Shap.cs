using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Newcode
{
    abstract  public class Shap
    {
        public abstract void CalculationArea();
        
        
        }
    public class Circle:Shap
    {
        private int radius;
        private double area;
        public Circle(int radius)
        {
            this.radius = radius;
        }

        public override void CalculationArea()
        {
            area = 3.14 * radius * radius;
        }
        public override string ToString()
        {
            return $"Area of Circle is {area}";
        }

        
        
    }
}

