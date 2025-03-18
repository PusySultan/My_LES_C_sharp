namespace Delegate_2
{
    internal class Program
    {
        delegate double MathOperation(double a, double b);
        static void Main(string[] args)
        {
            double a, b;

            Console.Write("Input first number: ");
            a = GetNum();

            Console.Write("Input second number: ");
            b = GetNum();

            Console.Write("Input operator: ");
            switch (Console.ReadLine())
            {
                case "+": GetResulte(Plus, a, b); break;
                case "-": GetResulte(Minus, a, b); break;
                case "*": GetResulte(Multiplex, a, b); break;
                case "/": GetResulte(Devide, a, b); break;

                    default: Console.WriteLine("I have not this operation"); break;

            }

        }

        private static void GetResulte(MathOperation func, double a, double b)
        { 
            Console.WriteLine(func(a, b));
        }

        private static double Plus(double a, double b)
        {
            return a + b;
        }

        private static double Minus(double a, double b)
        {
            return a - b;
        }

        private static double Devide(double a, double b)
        {
            return b != 0 ? a / b : throw new Exception("Devide by zero");
        }

        private static double Multiplex(double a, double b)
        {
            return a * b;
        }

        private static double GetNum()
        {
            do
            {
                try
                {
                    return double.Parse(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.Write("Try again: ");

                }
            } while (true);
        }
    }
}
