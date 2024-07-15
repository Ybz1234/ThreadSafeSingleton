using System.Collections.Generic;
using ThreadSafeSingleton;

namespace TSSingleton.Eager
{
    public sealed class LinkedListManager
    {
        private LinkedList<Shape> shapes;
        private static readonly LinkedListManager instance = new LinkedListManager();

        private LinkedListManager()
        {
            shapes = new LinkedList<Shape>();
        }

        public static LinkedListManager GetInstance()
        {

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