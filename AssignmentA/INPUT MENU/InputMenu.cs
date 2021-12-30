using System;


namespace AssignmentA
{
    public class InputMenu
    {
        public static void Menu()
        {
            
            
            string input;

            do
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("CHOOSE ONE OF THE FOLLOWING");
                Console.ResetColor();
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("1 - CREATE COURSE ");
                Console.WriteLine("2 - CREATE STUDENT ");
                Console.WriteLine("3 - CREATE TRAINER ");
                Console.WriteLine("4 - CREATE ASSIGNMENT ");
                Console.WriteLine("E - EXIT ");
                Console.WriteLine();
                Console.Write("CHOOSE: ");
                Console.ResetColor();
                input = Console.ReadLine().ToLower();
                Console.Clear();

                switch (input)
                {
                    case "1": ViewInputs.Course(); break;
                    case "2": ViewInputs.Student(); break;
                    case "3": ViewInputs.Trainer(); break;
                    case "4": ViewInputs.Assignment(); break;
                    case "e": MainMenu.Menu(); break;
                    default:Printings.Error();
                        break;
                }
            } while (input != "e");


        }
    }

   
}



 


  

