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

            AddShapes1();
            AddShapes2();

            Parallel.Invoke(
                () => AddShapes1(),
                () => AddShapes2()
            );

            Thread thread = new Thread(() => AddShapes1());
            Thread thread2 = new Thread(() => AddShapes2());

            thread.Start();
            thread2.Start();

            Console.WriteLine(LinkedListManager.GetInstance().GetCount());
            Console.WriteLine(LinkedListManager.GetInstance());

            Thread t1 = new Thread(() => Hawk());
            Thread t2 = new Thread(() => Tuah());

            t1.Start();
            t2.Start();
        }
        static void AddShapes1()
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

        }
        static void AddShapes2()
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


        }

        public static void Hawk()
        {
            for (int i = 0; i < 1000; i++)
                Console.Write("Hawk ");
        }
        public static void Tuah()
        {
            for (int i = 0; i < 1000; i++)
                Console.Write("Tuah ");
        }
    }
}
