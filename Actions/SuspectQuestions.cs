
public class SuspectQuestions
{
    public static void AskQuestion(Suspect suspect)
    {
        Console.Clear();
        
        while (true)
        {
            
            System.Console.WriteLine($"Ask {suspect.Name} a question!\n" +
                                "1. Tell me about your alibi for the night of the crime.\n " +
                                "2. Do you have any grudges against Stuart McCormick?\n " +
                                "3. Did you notice anything suspicious around the time that Stuart McCormick fell off of his stool?\n " +
                                "4. Did you notice any weird interactions Stuart McCormick had with the other suspects?\n " +
                                "0. Return to previous menu");

            string selection = Console.ReadLine() ?? "";
            switch (selection)
            {
                case "1":
                    Console.Clear();
                    System.Console.WriteLine("You asked: Tell me about your alibi for the night of the crime. \n");
                    System.Console.WriteLine($"{suspect.Name}: {suspect.SuspectResponses[0]}");
                    Program.UserMove();
                    break;
                case "2":
                    Console.Clear();
                    System.Console.WriteLine("You asked: Do you have any grudges against Stuart McCormick?\n");
                    System.Console.WriteLine($"{suspect.Name}: {suspect.SuspectResponses[1]}");
                    Program.UserMove();
                    break;
                case "3":
                    Console.Clear();
                    System.Console.WriteLine("You asked: Did you notice anything suspicious around the time that Stuart McCormick fell off of his stool?\n");
                    System.Console.WriteLine($"{suspect.Name}: {suspect.SuspectResponses[2]}");
                    Program.UserMove();
                    break;
                case "4":
                    Console.Clear();
                    System.Console.WriteLine("You asked: Did you notice any weird interactions Stuart McCormick had with the other suspects?\n");
                    System.Console.WriteLine($"{suspect.Name}: {suspect.SuspectResponses[3]}");
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


    //System.Console.WriteLine($"________Which question would you like to ask {}?__________");
    // Console.Clear();
    
    //     while (true)
    //     {
    //         Console.WriteLine(
    //         $"________Which question would you like to ask {}?__________\n\n" +
    //         "1. Where were you on the night of the incident?\n" +
    //         "2. Did you hold a grudge against (victim)?\n" +
    //         "3. Did you see anything suspicious around the time that (victim) fell off his stool?\n" +
    //         "4. Did you see any of (victim)'s interactions with other suspects?/n");
        
    //     string selection = Console.ReadLine() ?? "";
    //     switch (selection)
    //     {
    //         case "1":
                
    //             break;
    //         case "2":
    //             //
    //             break;
    //         case "3":
    //             //
    //             break;
    //         case "4":
    //             //
    //             break;
    //         case "0":
    //             return;
    //         default:
    //             Console.WriteLine("Please enter a valid selection.");
    //             Program.PauseAndWaitForKeypress();
    //             break;
    //     }
    //     }
    // }   