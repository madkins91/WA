using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkoutAssistant
{
    class TargetedExercise : Exercise
    {
        public TargetedExercise(string name, int id)
        {
            this.name = name;
            this.id = id;
        }
    }
}