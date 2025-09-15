using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Geometry
{
    public class Triangle : Rectangle
    {
        private double _c;
        private double _h;
      
        public Triangle(string name, double a, double b, double c, double h) : base(name, b, a)
        {
            C = c;
            H = h;
        }
        public double C
        {
            get => _c;
            set => _c = ValidateC(value);
        }
        public double H
        {
            get => _h;
            set => _h = ValidateH(value);
        }
        public override double GetArea() => B * H / 2;
        public override double GetPerimeter() => A + B + C;
        private double ValidateC(double c)
        {
            if (c <= 0)
            {
                throw new Exception($"El lado debe ser mayor a cero.");
            }
            return c;
        }
        private double ValidateH(double h)
        {
            if (h <= 0)
            {
                throw new Exception($"Pon el mensaje que quieras de error pero en ingles");
            }
            return h;
        }
    }
}