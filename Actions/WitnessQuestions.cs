using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class WitnessQuestions
{
    public static void AskQuestion(Witness witness)
    {
        while (true)
        {
            System.Console.WriteLine($"Ask {witness.Name} a question!\n" +
                                    "1. Did you happen to see Carol McComick interacting with Stuart McCormick at any point?\n" +
                                    "2. Did you happen to see Angela Everwood interacting with Stuart McCormick at any point?\n" +
                                    "3. Did you happen to see Rusty Shackleford interacting with Stuart McCormick at any point?\n" +
                                    "4. Anything you happen to remember that stands out to you? Even something small?\n" +
                                    "0. Return to previous menu");


            string selection = Console.ReadLine() ?? "";
            switch (selection)
            {
                case "1":
                    Console.Clear();
                    System.Console.WriteLine("You asked: Did you happen to see Carol McComick interacting with Stuart McCormick at any point?\n");
                    System.Console.WriteLine($"{witness.Name}: {witness.WitnessResponses[0]}\n");
                    Program.UserMove();
                    break;
                case "2":
                    Console.Clear();
                    System.Console.WriteLine("You asked: Did you happen to see Angela Everwood interacting with Stuart McCormick at any point?\n");
                    System.Console.WriteLine($"{witness.Name}: {witness.WitnessResponses[1]}\n");
                    Program.UserMove();
                    break;
                case "3":
                    Console.Clear();
                    System.Console.WriteLine("You asked: Did you happen to see Rusty Shackleford interacting with Stuart McCormick at any point?\n");
                    System.Console.WriteLine($"{witness.Name}: {witness.WitnessResponses[2]}");
                    Program.UserMove();
                    break;
                case "4":
                    Console.Clear();
                    System.Console.WriteLine("You asked: Anything you happen to remember that stands out to you? Even something small?\n");
                    System.Console.WriteLine($"{witness.Name}: {witness.WitnessResponses[3]}");
                    Program.UserMove();
                    break;
                case "0":
                    Console.Clear();
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
