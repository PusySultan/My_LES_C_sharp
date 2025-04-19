namespace Task_1
{
    using System;
    using System.Collections.Generic;
    using Task_1.Library;

    internal static class ReadWriter
    {
        private static readonly string _autorsPath = "Data/Autors.txt";
        private static readonly string _booksPath = "Data/Books.txt";

        public static IEnumerable<Autor> GetAutors()
        {
            string readData = string.Empty;

            using (StreamReader sr = new StreamReader(_autorsPath))
            {
                readData = sr.ReadToEnd();
            }

            throw new Exception(" ");
        }

        public static IEnumerable<Book> GetBooks()
        {
            string readData = string.Empty;

            using (StreamReader sr = new StreamReader(_booksPath))
            {
                readData = sr.ReadToEnd();
            }

            throw new Exception(" ");
        }

        public static bool AddAutor(Autor autor)
        {
            string autorJSON = Parser.GetAutorJSON(autor);

            using (StreamWriter streamWriter = new StreamWriter(_autorsPath, true))
            {
                streamWriter.Write(autorJSON);
            }

            return true;
        }

        public static bool AddBook()
        {
            throw new Exception(" ");
        }
    }
}
