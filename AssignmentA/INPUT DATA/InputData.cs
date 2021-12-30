using System;

namespace AssignmentA
{
    public class InputData
    {
        MyDatabase db = new MyDatabase();

        public static void MainMenu()
        {

            string input;
            do
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("INPUT DATA");
                Console.ResetColor();
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("CHOOSE ONE OF THE FOLLOWING");
                Console.WriteLine();
                Console.WriteLine("1 - COURSE");
                Console.WriteLine("2 - STUDENT");
                Console.WriteLine("3 - TRAINER");
                Console.WriteLine("4 - ASSIGNMENT");

                Console.Write("CHOOSE: ");
                input = Console.ReadLine().ToLower();
                Console.ResetColor();
                Console.Clear();

                switch (input)
                {
                    case "1": Console.WriteLine("Input Course"); break;
                    case "2": Console.WriteLine("Input Student"); break;
                    case "3": Console.WriteLine("Input Trainer"); break;
                    case "4": Console.WriteLine("Input Assignment"); break;
                    case "e": Console.WriteLine("Exit"); break;
                    default:
                        break;
                }
            } while (input != "e");
            


        }

        public static 
    }

   
}



 


  

