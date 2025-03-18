namespace Interface_DS_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            IAnimal dog = new Dog();
            IAnimal cat = new Cat(name: "Babashka", age: 5);

            Console.WriteLine("Dog: ");
            dog.GetInfo();

            Console.WriteLine("\nCat: ");
            cat.GetInfo();

            Console.WriteLine("\n______________\n");

            Console.Write("dog ");
            dog.Sound();

            Console.Write("cat ");
            cat.Sound();


            Console.WriteLine("\n______________\n");

            Console.Write("dog ");
            dog.Eat();

            Console.Write("cat ");
            cat.Eat();


        }
    }
}
