namespace Collections
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal class Employee
    {
        private int _id;
        private string _name;
        private List<string> _skills;

        public Employee(int id, string name, List<string> skills)
        {
            _id = id;
            _name = name;
            _skills = skills;
        }

        public Employee(int id, string name)
        {
            _id = id;
            _name = name;
            _skills = new List<string>();
        }

        public string getName()
        { 
            return _name;
        }

        internal List<string> getSkills()
        {
            return _skills;
        }
    }
}
