using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkoutAssistant
{
    class Exercise
    {
        public string name { get; set; }
        public int id { get; set; }

        public Exercise()
        {

        }

        public Exercise(string name, int id)
        {
            this.name = name;
            this.id = id;
        }
    }
}