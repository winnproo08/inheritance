﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Geometry
{
    public class Rhombus : Square
    {
        private double _d1;
        private double _d2;
        public double D1
        {
            get => _d1;
            set => _d1 = ValidateD1(value);
        }
        public double D2
        {
            get => _d2;
            set => _d2 = ValidateD2(value);
        }
        public override double GetArea() => (D1 * D2) / 2;
        public override double GetPerimeter() => 4 * A;
         
        public Rhombus(string name, double a, double d1, double d2) : base(name, a)
        {
            D1 = d1;
            D2 = d2;
        }
        private double ValidateD1(double d1)
        {
            if (d1 <= 0)
            {
                throw new Exception($"La diagonal 1 debe ser mayor a cero.");
            }
            return d1;
        }
        private double ValidateD2(double d2)
        {
            if (d2 <= 0)
            {
                throw new Exception($"La diagonal 2 debe ser mayor a cero.");
            }
            return d2;
        }
    }
}