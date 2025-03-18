namespace Delegate_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi, dear friend");
            Console.WriteLine("Tup 'esc' by exit\nTup any key by continue");

            while (true)
            {                
                if(Console.ReadKey(true).Key == ConsoleKey.Escape)
                {
                    break;
                }

                Input.getResulte();
            }
        }
    }
}
