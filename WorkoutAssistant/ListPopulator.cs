using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkoutAssistant
{
    class ListPopulator
    {
        public static List<Exercise> createExerciseList()
        {
            List <Exercise> list = new List<Exercise>();

            list.Add(new Exercise("Back", 0));
            list.Add(new Exercise("Arms", 1));
            list.Add(new Exercise("Legs", 2));
            list.Add(new Exercise("Chest", 3));
            list.Add(new Exercise("Core", 4));

            return list;
        }

        public static List<TargetedExercise> createTargetedExerciseList(int exerciseId)
        {
            List<TargetedExercise> list;

            switch (exerciseId)
            {
                case 0: list = createBackTargetedList();
                    break;
                case 1: list = createArmsTargetedList();
                    break;
                default: list = createBackTargetedList();
                    break;
            }

            return list;
        }

        public static List<TargetedExercise> createBackTargetedList()
        {
            List<TargetedExercise> list = new List<TargetedExercise>();

            list.Add(new TargetedExercise("Bent Barbell Rows", 0));
            list.Add(new TargetedExercise("Dumbbell Lat Rows", 1));
            list.Add(new TargetedExercise("Overhead Lat Pulldowns", 2));
            list.Add(new TargetedExercise("Close-Grip Lat Pulls", 3));
            list.Add(new TargetedExercise("Wide-Grip Pullups", 4));
            list.Add(new TargetedExercise("Lower Back Extensions", 5));

            return list;
        }

        public static List<TargetedExercise> createArmsTargetedList()
        {
            List<TargetedExercise> list = new List<TargetedExercise>();

            list.Add(new TargetedExercise("Dumbbell Curls", 0));
            list.Add(new TargetedExercise("Barbell Curls", 1));
            list.Add(new TargetedExercise("Hammer Curls", 2));
            list.Add(new TargetedExercise("Preacher Curls", 3));
            list.Add(new TargetedExercise("Forearm Curls", 4));
            list.Add(new TargetedExercise("Tricep Pulldowns", 5));
            list.Add(new TargetedExercise("Overhead Tricep Extensions", 6));
            list.Add(new TargetedExercise("Dumbbell Skullcrushers", 7));
            list.Add(new TargetedExercise("Tricep Dips", 8));

            return list;
        }
    }
}