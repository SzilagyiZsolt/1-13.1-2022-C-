using System;
using System.Linq;

namespace rockpaperscissors 
{ 
    class Program 
    { 
        static void Main(string[] args) 
        { 
            string[] options = { "kő", "papír", "olló" }; 
            Random random = new Random(); 
            int playerscore = 0; 
            int computerscore = 0; 
            Console.WriteLine("kő-papír-olló játék"); 
            Console.WriteLine("válassz a következő opciók közül: "); 
            foreach (string option in options) 
            { 
                Console.WriteLine(option); 
            } 
            while (true) 
            { 
                Console.WriteLine("válassz egy lehetőséget: "); 
                string playerchoice = Console.ReadLine();
                if (!options.Contains(playerchoice))
                { 
                    Console.WriteLine("érvénytelen bevitel, próbáld újra");
                    Console.WriteLine(" ");
                    continue; 
                } 
                int computerchoiceindex = random.Next(0, options.Length); 
                string computerchoice = options[computerchoiceindex]; 
                Console.WriteLine("a számítógép választása: " + computerchoice); 
                if (playerchoice == "kő" && computerchoice == "olló" || playerchoice == "papír" && computerchoice == "kő" || playerchoice == "olló" && computerchoice == "papír") 
                { 
                    Console.WriteLine("nyertél!"); playerscore++; 
                } 
                else if (playerchoice == computerchoice) 
                { 
                    Console.WriteLine("döntetlen!"); 
                } 
                else 
                { 
                    Console.WriteLine("vesztettél!"); 
                    computerscore++; 
                } 
                Console.WriteLine("jelenlegi pontszám: te " + playerscore + " - " + computerscore + " számítógép");
                Console.WriteLine(" ");
            } 
        } 
    } 
}
