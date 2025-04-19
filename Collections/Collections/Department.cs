using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class Department
    {
        private string _name;
        private LinkedList<Employee> _employees;
        private Queue<string> _tasks;
        private HashSet<string> _skillsCatalog;

        public Department(string name, LinkedList<Employee> employees,
            Queue<string> tasks, HashSet<string> skillsCatalog)
        {
            _name = name;
            _employees = employees;
            _tasks = tasks;
            _skillsCatalog = skillsCatalog;
        }

        public Department(string name, LinkedList<Employee> employees,
           Queue<string> tasks)
        {
            _name = name;
            _employees = employees;
            _tasks = tasks;
            _skillsCatalog = new HashSet<string>();
        }

        public Department(string name, LinkedList<Employee> employees)
        {
            _name = name;
            _employees = employees;
            _tasks = new Queue<string> { };
            _skillsCatalog = new HashSet<string>();
        }

        public Department(string name)
        {
            _name = name;
            _employees = new LinkedList<Employee>();
            _tasks = new Queue<string> { };
            _skillsCatalog = new HashSet<string>();
        }

        public void addEmploye(Employee employee)
        { 
            _employees.AddLast(employee);
            AddSkills(employee.getSkills());
        }

        public void addTask(string task)
        { 
            _tasks.Enqueue(task);
        }

        public void dismissEmployeByName (string emp)
        {
            var currenMode = _employees.First;

            while (currenMode != null)
            {
                if (currenMode.Value.getName() == emp)
                {
                    _employees.Remove(currenMode);       
                }

                currenMode = currenMode.Next;
            }
        }

        private void AddSkills(List<string> newSkills)
        {
            foreach (string s in newSkills)
            {
                _skillsCatalog.Add(s);
            }
        }
    }
}
