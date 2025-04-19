namespace Collections
{
    internal class Program
    {
        private static int[] array = { 1, 5, 7 };

        private static List<int> _list = new List<int> ( array );
        private static LinkedList<int> _linkedList = new LinkedList<int> (array);
        private static Queue<int> _queue = new Queue<int>(array);
        private static Stack<int> _stack = new Stack<int> (array);
        

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
