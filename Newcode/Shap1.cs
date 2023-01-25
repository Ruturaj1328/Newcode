using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Newcode
{
    abstract public class Shap1
    {
        public abstract void CalculationArea();


    }
    public class Triangle : Shap
    {
        private int Base;
        private double area;
        private int hight;
        public Triangle(int Base, int hight)
        {
            this.Base = Base;
            this.hight = hight;
        }

        public override void CalculationArea()
        {
            area =0.5 * Base * hight;
        }
            
        public override string ToString()
        {
            return $"Area of Triangle is {area}";
        }


    }
}
