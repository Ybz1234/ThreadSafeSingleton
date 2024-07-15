using System.Collections.Generic;
using ThreadSafeSingleton;

namespace TSSingleton.Lazy
{
    internal sealed class LinkedListManager
    {
        private LinkedList<Shape> shapes;
        private static LinkedListManager instance;
        private static readonly object obj = new object();

        private LinkedListManager()
        {
            shapes = new LinkedList<Shape>();
        }

        public static LinkedListManager GetInstance()
        {
            if (instance == null)
            {
                lock (obj)
                {
                    if (instance == null)
                        instance = new LinkedListManager();
                }
            }
            return instance;
        }

        public void AddToList(Shape shape)
        {
            this.shapes.AddLast(shape);
        }

        public override string ToString()
        {
            string str = "";
            foreach (Shape shape in this.shapes)
                str += shape.ToString() + "\n";
            return str;
        }
    }
}