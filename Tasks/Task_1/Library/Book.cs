namespace Task_1.Library
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal class Book
    {
        private string _title;
        private Autor _autor;
        private DateTime _dateOfWriting;

        public Book(string title, Autor autor, DateTime dateOfWriting)
        {
            _title = title;
            _autor = autor;
            _dateOfWriting = dateOfWriting;
        }
    }
}
