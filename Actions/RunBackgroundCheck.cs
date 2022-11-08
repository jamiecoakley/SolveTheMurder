public class RunBackgroundCheck
{
    SolveMurder solveMurder = new SolveMurder();
    public void Background(List<Suspect> suspects)
    {

        Victim victim = new Victim();


        Console.Clear();

        while (true)
        {
            System.Console.WriteLine($"Suspect 1:  {suspects[0].Name}, age {suspects[0].Age}, {suspects[0].Occupation}; {suspects[0].Relationship} of Stuart McCormick.\n" +
                                    $"Suspect 2:  {suspects[1].Name}, age {suspects[1].Age}, {suspects[1].Occupation};  {suspects[1].Relationship} of Stuart McCormick.\n" +
                                    $"Suspect 3:  {suspects[2].Name}, age {suspects[2].Age}, {suspects[2].Occupation};  {suspects[2].Relationship} of Stuart McCormick.\n" +
                                    $"Victim:     {victim.Name}, age {victim.Age}, {victim.Occupation}\n");
            Console.WriteLine(
            "------------Options-----------\n" +
            "1. Run Background Check on Suspect 1\n" +
            "2. Run Background Check on Suspect 2\n" +
            "3. Run Background Check on Suspect 3\n" +
            "4. Run Background Check on Victim\n" +
            "5. Solve the Murder!\n" +
            "0. Return to previous menu"
            );

            string selection = Console.ReadLine() ?? "";
            switch (selection)
            {
                case "1":
                    Console.Clear();
                    System.Console.WriteLine($"{suspects[0].Name} Criminal History\n" + 
                                            "____________________\n");
                    ShowCriminalData(suspects[0]);
                    Program.UserMove();
                    break;
                case "2":
                    Console.Clear();
                    System.Console.WriteLine($"{suspects[1].Name} Criminal History\n" + 
                                            "____________________\n");
                    ShowCriminalData(suspects[1]);
                    Program.UserMove();
                    break;
                case "3":
                    Console.Clear();
                    System.Console.WriteLine($"{suspects[2].Name} Criminal History\n" + 
                                            "____________________\n");
                    ShowCriminalData(suspects[2]);
                    Program.UserMove();
                    break;
                case "4":
                    Console.Clear();
                    System.Console.WriteLine($"{victim.Name} Criminal History\n" + 
                                            "____________________\n");
                    VictimBackgroundCheck(victim);
                    Program.UserMove();
                    break;
                case "5":
                    Console.Clear();
                    solveMurder.SolveTheMurder();
                    break;
                case "0":
                    return;
                default:
                    Console.WriteLine("Please enter a valid selection.");
                    Program.PauseAndWaitForKeypress();
                    break;
            }


        }

    }
    public void ShowCriminalData(Suspect suspect)
    {
        if (suspect.Crimes == null)
        {
            System.Console.WriteLine("NO CRIMINAL HISTORY\n" + 
                                    "____________________\n");
        }
        else
        {
            foreach (var crime in suspect.Crimes)
            {
                System.Console.WriteLine(crime + "\n");
            }
        }
    }

        public void VictimBackgroundCheck(Victim victim)
    {
        if (victim.Crimes == null)
        {
            System.Console.WriteLine("NO CRIMINAL HISTORY\n" + 
                                    "____________________\n");
        }
        else
        {
            foreach (var crime in victim.Crimes)
            {
                System.Console.WriteLine(crime + "\n");
            }
        }
    }
}