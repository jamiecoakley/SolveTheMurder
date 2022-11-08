using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

    public class SolveMurder
    {
        
    public void SolveTheMurder()
    {
        string forensics = "CORONER REPORT: Stuart McCormick's stomach contents contained a mixture of your typical salad and casserole ingrdients, but with an abundance of daffodil remains.\n" +
                            "CONCLUSION: Stuart McCormick succumbed to lycorine poisoning, due to the consumption of daffodil bulbs and leaves.";
        
        string youLose = "You are incorrect and have lost the bet. You owe your Lieutenant 50 theoretical dollars.\n\n" + 
                                        "Thanks for playing! Please try again.\n\n";

        while (true)
        {
            Console.Clear();
            System.Console.WriteLine("Choose the person you think is guilty of the murder!\n" +
                                $"1. Suspect 1: Carol McCormick\n" +
                                $"2. Suspect 2: Angela Everwood\n" +
                                $"3. Suspect 3: Rusty Shackleford\n " +
                                "4. No one is guilty, he died of natural causes...\n ");

            string selection = Console.ReadLine() ?? "";
            
            switch (selection)
            {
                case "1":
                    Console.Clear();
                    System.Console.WriteLine(forensics + "\n");
                    Drama();
                    System.Console.WriteLine("Congratulations, Detective! You solved the case and won your bet of 50 theoretical dollars.\n");
                    System.Environment.Exit(1);
                    break;
                case "2":
                    Console.Clear();
                    System.Console.WriteLine(forensics + "\n");
                    Drama(); 
                    System.Console.WriteLine(youLose);
                    System.Environment.Exit(1);
                    break;
                case "3":
                    Console.Clear();
                    System.Console.WriteLine(forensics + "\n");
                    Drama();  
                    System.Console.WriteLine(youLose);
                    System.Environment.Exit(1);
                    break;
                case "4":
                    Console.Clear();
                    System.Console.WriteLine(forensics + "\n");
                    Drama();  
                    System.Console.WriteLine(youLose);
                    System.Environment.Exit(1);
                    break;
                default:
                    Console.WriteLine("Please enter a valid selection.");
                    Program.PauseAndWaitForKeypress();
                    break;
            }
        }
        
    }
    public void Drama()
        {
            Thread.Sleep(1000);
            System.Console.WriteLine(".");
            Thread.Sleep(1000);
            System.Console.WriteLine(".");
            Thread.Sleep(1000);
            System.Console.WriteLine(".\n");
            Thread.Sleep(1000); 
        }
    }