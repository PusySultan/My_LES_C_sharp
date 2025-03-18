using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_DS_2
{
    internal class Car : IVehicle
    {
        bool _IsActive = false;
        int _Speed = 0;
        public int Speed
        { 
            get =>_Speed;
            set 
            {
                _Speed = value;
                if (_Speed != 0)
                {
                    _IsActive = true;
                }
            }
                
        }
        public bool IsActive
        { 
            get => _IsActive; 
        }

        public void drive()
        {
            if (!_IsActive)
            {
                Console.WriteLine("Car is do not drive");
                return;
            }

            if (_Speed > 0)
            {
                Console.WriteLine("The car is going straight at a speed of {0} km/h", _Speed);
                return;
            }

            Console.WriteLine("The car is going backwards at a speed of {0} km/h", _Speed * -1);
            return;
        }
    }
}
