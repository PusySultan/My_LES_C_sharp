using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_DS_4
{
    internal class Employee : IManager
    {
        private string _name;
        private string _surname;
        private bool _inProgress = false;
        IWorker[] _subordinates = new IWorker[0];

        public Employee(string name, string surname)
        { 
            _surname = surname;
            _name = name;
        }
        public IWorker[] subordinates
        {
            get => _subordinates;
        }

        public bool isHappy => !_inProgress;

        public bool inProgress
        { 
            get => _inProgress;
            set
            {
                _inProgress = value;
            }
        }

        public string name
        {
            get => _name;
        }
        public string sersurname
        {
            get => _surname;
        }

        public void AddSubordinates(IWorker worker)
        {
            if (_subordinates.Length > 0)
            {
                IWorker[] new_subordinates = new IWorker[_subordinates.Length + 1];

                for (int i = 0; i < new_subordinates.Length - 1; i++)
                {
                    new_subordinates[i] = _subordinates[i];
                }

                new_subordinates[new_subordinates.Length - 1] = worker;
                _subordinates = new_subordinates;
                return;
            }

            _subordinates = new IWorker[1];
            _subordinates[0] = worker;
            
        }

        public void AddSubordinates(IWorker[] workers)
        {
            foreach (IWorker worker in workers)
            {
                AddSubordinates(worker);
            }
        }

        public void Manage()
        {
            inProgress = true;
            Work();
        }

        public void RemoveSubordinates(IWorker worker)
        {
            IWorker[] new_subordinates = new IWorker[_subordinates.Length - 1];
            int counter = 0;

            for (int i = 0; i < new_subordinates.Length + 1; i++)
            {
                if (_subordinates[counter] != worker)
                {
                    new_subordinates[counter] = _subordinates[i];
                    counter++;
                }
            }

            _subordinates = new_subordinates;
        }

        public void RemoveAllSubordinates()
        {
            _subordinates = new IWorker[0];
        }

        public void RemoveSubordinates(IWorker[] workers)
        {
            foreach (IWorker worker in workers)
            {
                RemoveSubordinates(worker);
            }
        }

        public void Work()
        {

            Console.WriteLine("Manage");
        }

        public void GetInfo()
        {
            Console.WriteLine(
                "My name {0}\n" +
                "My surname {1}\n" +
                "I have {2} Subordinates\n" +
                "__________________________________________________________",
                _name, _surname, _subordinates.Length);
        }
    }
}
