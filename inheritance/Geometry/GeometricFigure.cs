namespace Geometry
{
    public abstract class GeometricFigure
    {
       
        public string Name { get; set; } = null!;
       
        public abstract double GetArea();
        public abstract double GetPerimeter();
        override public string ToString()
        {
            return $"{Name,-15} => Area......: {GetArea(),15:N5}     Perimeter: {GetPerimeter(),15:N5}";
        }
    }
}
