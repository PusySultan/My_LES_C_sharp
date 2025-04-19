using Task_1.Library;

namespace Task_1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Autor a_1 = new Autor("Alexandr", "Pushkin", new DateTime(1799, 6, 6));
            Book book_1 = new Book("Kapitanskay dochka", a_1, new DateTime(1836, 1, 1));
        }
    }
}
