using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseOnInterfaces
{
    class Activity : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Activity is executed");
        }
    }
}
