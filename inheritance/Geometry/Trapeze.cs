using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Geometry
{
    public class Trapeze : Triangle
    {
        private double _d;
       
        public double D
        {
            get => _d;
            set => _d = ValidateD(value);
        }
        public override double GetArea() => (B + D) * H / 2;
        public override double GetPerimeter() => A + B + C + D;
        public Trapeze(string name, double a, double d, double c, double b, double h) : base(name, a,
b, c, h)
        {
            D = d;
        }
        private double ValidateD(double d)
        {
            if (d <= 0)
            {
                throw new Exception($"Debe ser mayor a cero.");
            }
            return d;
        }
    }
}