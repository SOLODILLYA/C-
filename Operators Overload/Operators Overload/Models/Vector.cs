namespace Operators_Overload.Models
{
    internal class Vector
    {
        private double _x;
        private double _y;
        
        public Vector(double x, double y)
        {
            _x = x;
            _y = y;
        }

        public override string ToString()
        {
            return $"({_x}; {_y})";
        }
        
        public static Vector operator +(Vector a, Vector b)
        {
            return new Vector(a._x + b._x, a._y + b._y);
        }
        
        public static Vector operator -(Vector a, Vector b)
        {
            return new Vector(a._x - b._x, a._y - b._y);
        }
        
        public static double operator *(Vector a, Vector b)
        {
            return a._x * b._x + a._y * b._y;
        }
        
        public static Vector operator *(Vector a, double b)
        {
            return new Vector(a._x * b , a._y * b);
        }
    }
}