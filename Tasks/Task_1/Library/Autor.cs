namespace Task_1.Library
{
    internal class Autor
    {
        private string _name;
        private string _surName;
        private DateTime _birthDate;
        private HashSet<Book> _books;

        public Autor(string name, string surName, DateTime birthDate)
        {
            _name = name;
            _surName = surName;
            _birthDate = birthDate;
        }

        public HashSet<Book> GetBooks => _books;

        public bool AddBook(Book book)
        {
            if (_books.Contains(book))
            {
                return false;
            }

            _books.Add(book);
            return true;
        }
    }
}