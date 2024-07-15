using System;
using System.Threading;
using System.Threading.Tasks;
using TSSingleton.Lazy;

namespace ThreadSafeSingleton
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            LinkedListManager list = AddShapes1();
            list = AddShapes2();

            Parallel.Invoke(
                () => AddShapes1(),
                () => AddShapes2()
            );

            Console.WriteLine(list);
        }
        static LinkedListManager AddShapes1()
        {
            LinkedListManager list = LinkedListManager.GetInstance();

            Shape[] shapes = new Shape[]
            {
                new Circle(5),
                new Circle(3),
                new Circle(7),
                new Circle(9),

                new Rectangle(4, 6),
                new Rectangle(3, 7),

                new Triangle(4, 5, 3, 4, 5),
                new Triangle(3, 4, 2, 3, 4),

                new Cylinder(3, 8),
                new Cylinder(4, 10),
            };

            foreach (Shape shape in shapes)
                list.AddToList(shape);

            return list;
        }
        static LinkedListManager AddShapes2()
        {
            LinkedListManager list = LinkedListManager.GetInstance();

            Shape[] shapes = new Shape[]
            {
                new Circle(5),
                new Circle(3),
                new Circle(7),
                new Circle(9),

                new Rectangle(4, 6),
                new Rectangle(3, 7),

                new Triangle(4, 5, 3, 4, 5),
                new Triangle(3, 4, 2, 3, 4),

                new Cylinder(3, 8),
                new Cylinder(4, 10),
            };

            foreach (Shape shape in shapes)
                list.AddToList(shape);

            return list;
        }
    }
}
