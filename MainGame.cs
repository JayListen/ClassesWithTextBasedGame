using System;

namespace ClassesWithTextGame
{
    class MainGame
    {
        static void Main(string[] args)
        {
            intro introduction = new intro();
            charInfo profile = new charInfo();
            
            // Start the game with an introduction!
            Console.WriteLine(introduction.heythere);
            Console.Write(introduction.askname);

            // store the name into charInfo.cs
            profile.name = Console.ReadLine(); 

            // verify name
            Console.Write("\nSo your name is " + profile.name + "? (y or n) "); 
            bool nameVerify = Console.ReadLine().ToLower() == "y" || Console.ReadLine().ToLower() == "yes";

            // cycle verification of name until name = true
            while(nameVerify != true)
            {
                Console.Write("Then what is your name? ");
                profile.name = Console.ReadLine();

                Console.Write("Is " + profile.name + " your correct name? (y or n) "); 
                nameVerify = Console.ReadLine() == "y";

            }

            Console.WriteLine("\nHmm... I see,");
            Console.ReadKey();
            Console.WriteLine("\nWelcome, " + profile.name);

            


            
        }
    }
}
