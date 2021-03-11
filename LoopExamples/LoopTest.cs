using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace LoopExamples
{
    [TestClass]
    public class LoopTest
    {
        [TestMethod]
        public void WhileLoops()
        {
            //Just for setup...
            int total = 1;

            //Please keep running as long as total isn't 10
            while (total != 10)
            {
                Console.WriteLine(total);
                total = total + 1;
            }

            total = 0;

            while (true)
            {
                if (total == 10)
                {
                    Console.WriteLine("Goal Reached");
                    break;
                }

                total++;

            }

            Random random = new Random();

            int someCount;
            bool keepLooping = true;

            while (keepLooping)
            {

                someCount = random.Next(0, 20);

                if (someCount == 6 || someCount == 10)
                {
                    continue;
                }
                Console.WriteLine(someCount);

                if (someCount == 15)
                {
                    keepLooping = false;
                }
            }

        }


        [TestMethod]
        public void ForLoops()
        {
            int studentCount = 21;

            //Initialization Conditional increment
            for (int i = 0; i < studentCount; i++)
            {
                Console.WriteLine(i);
            }

            string[] students = { "Adam", "Justin", "Joshua", "Amanda", "Danielle", "Ingeborg" };

            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine($"Welcome to the class {students[i]} !");
            }
        }
        [TestMethod]
        public void ForeachLoops()
        {
            string[] students = { "Adam", "Justin", "Joshua", "Amanda", "Danielle", "Ingeborg" };

            foreach (string student in students)
            {
                Console.WriteLine(student + " is a student in the class");
            }

            //String is an array of char
            string MyName = "Terry Eugene Edward Brown";
            foreach (char letter in MyName)
            {
                if (letter != ' ')
                {
                    Console.WriteLine(letter);
                }
            }
        }

        [TestMethod]
        public void DoWhileLoops()
        {
            int iterator = 0;

            //I always run at least once!!!!!
            do
            {
                Console.WriteLine("Hello");
                iterator++;

            }
            while (iterator < 5);

            do
            {
                Console.WriteLine("My do while condition is False!!!");
            } while (false);


        }
    }
}

