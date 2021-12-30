using System;


namespace AssignmentA
{
    public class MainMenu
    {
        public static void Menu()
        {
            
            string input;

            do
            {

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("WELCOME TO PK PRIVATE SCHOOL");
                Console.ResetColor();
                Console.WriteLine();

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("CHOOSE ONE OF THE FOLLOWING OPTIONS");
                Console.ResetColor();
                Console.WriteLine();

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("1 - SYNTHETIC DATA");
                Console.WriteLine("2 - INPUT DATA");
                Console.WriteLine("E - EXIT");
                Console.ResetColor();
                Console.WriteLine();
                Console.Write("CHOOSE : ");
                input = Console.ReadLine().ToLower();
                Console.Clear();



                switch (input)
                {
                    case "1": ViewData.DataMenu(); break;
                    case "2": InputMenu.Menu(); break;                                       
                    default:
                        Console.WriteLine("GOODBYE!!!");
                        break;
                }


            } while (input != "e");
        }
    }

   
}



 


  

