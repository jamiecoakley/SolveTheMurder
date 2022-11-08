using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

    public class Warrants
    {
        SolveMurder solveMurder = new SolveMurder();
        public void WarrantOptions(List<Suspect> suspects)
    {

    Console.Clear();
    
        while (true)
        {
            System.Console.WriteLine($"Suspect 1:  {suspects[0].Name}, age {suspects[0].Age}, {suspects[0].Occupation}; {suspects[0].Relationship} of Stuart McCormick.\n" +
                                    $"Suspect 2:  {suspects[1].Name}, age {suspects[1].Age}, {suspects[1].Occupation};  {suspects[1].Relationship} of Stuart McCormick.\n" +
                                    $"Suspect 3:  {suspects[2].Name}, age {suspects[2].Age}, {suspects[2].Occupation};  {suspects[2].Relationship} of Stuart McCormick.\n");

            Console.WriteLine(
            "------------Options-----------\n" +
            "1. Try to get a Warrant for Suspect 1\n" +
            "2. Try to get a Warrant for Suspect 2\n" +
            "3. Try to get a Warrant for Suspect 3\n" +
            "4. Solve the Murder!\n" +
            "0. Return to previous menu"
            );
        
        string selection = Console.ReadLine() ?? "";
        switch (selection)
        {
            case "1":
                    if (RandomNumber.Between(0, 1) == 0)
                    {
                        Console.Clear();
                        System.Console.WriteLine($"Success! You obtained a warrant for {suspects[0].Name}'s home and mobile phone!\n");
                        System.Console.WriteLine(suspects[0].WarrantInfo[0]);
                        System.Console.WriteLine(suspects[0].WarrantInfo[1]);
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine($"You failed to get warrant to look into {suspects[0].Name}! \n\n");
                    }
                    Program.UserMove();
                    break;
            case "2":
                    if (RandomNumber.Between(0, 1) == 0)
                    {
                        Console.Clear();
                        System.Console.WriteLine($"Success! You obtained a warrant for {suspects[1].Name}'s home and mobile phone! \n");
                        System.Console.WriteLine(suspects[1].WarrantInfo[0]);
                        System.Console.WriteLine(suspects[1].WarrantInfo[1]);
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine($"You failed to get warrant to look into {suspects[1].Name}! \n");
                    }
                    Program.UserMove();
                    break;
            case "3":
                    if (RandomNumber.Between(0, 1) == 0)
                    {
                        Console.Clear();
                        System.Console.WriteLine($"Success! You obtained a warrant for {suspects[2].Name}'s home and mobile phone! \n");
                        System.Console.WriteLine(suspects[2].WarrantInfo[0]);
                        System.Console.WriteLine(suspects[2].WarrantInfo[1]);
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine($"You failed to get a warrant to look into {suspects[2].Name}!\n");
                    }
                    Program.UserMove();
                    break;
            case "4":
                    solveMurder.SolveTheMurder();
                    break;
            case "0":
                return;
            default:
                Console.WriteLine("Please enter a valid selection.");
                Program.PauseAndWaitForKeypress();
                Console.Clear();
                break;
        }
        }
    }   
    }
