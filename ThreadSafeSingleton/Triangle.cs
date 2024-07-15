namespace ThreadSafeSingleton
{
    public class Triangle : Shape
    {
        public double Base { get; set; }
        public double Height { get; set; }
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }

        public Triangle(double baseLength, double height, double sideA, double sideB, double sideC)
        {
            Base = baseLength;
            Height = height;
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        public override double CalculateArea()
        {
            return 0.5 * Base * Height;
        }

        public override double CalculatePerimeter()
        {
            return SideA + SideB + SideC;
        }

        public override string ToString()
        {
            return $"Triangle: base = {Base}, height = {Height}, side A = {SideA}, side B = {SideB}, side C = {SideC}";
        }
    }
}
