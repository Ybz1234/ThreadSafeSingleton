namespace ThreadSafeSingleton
{
    public class Cylinder : Circle
    {
        public double Height { get; set; }

        public Cylinder(double radius, double height) : base(radius)
        {
            Height = height;
        }

        public double CalculateVolume()
        {
            return base.CalculateArea() * Height;
        }

        public double CalculateSurfaceArea()
        {
            return 2 * base.CalculateArea() + base.CalculatePerimeter() * Height;
        }

        public override string ToString()
        {
            return $"Cylinder: radius = {Radius}, height = {Height}";
        }
    }
}
