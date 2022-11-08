public class WitnessInterview
{
    SolveMurder solveMurder = new SolveMurder();

    public void Witnesses(List<Witness> witnesses)
        {
        Console.Clear();
    
        while (true)
        {   
            System.Console.WriteLine($"Witness 1:  {witnesses[0].Name}, age {witnesses[0].Age}, {witnesses[0].Occupation}; {witnesses[0].Role}\n" +
                                    $"Witness 2:  {witnesses[1].Name}, age {witnesses[1].Age}, {witnesses[1].Occupation}; {witnesses[1].Role}\n" +
                                    $"Witness 3:  {witnesses[2].Name}, age {witnesses[2].Age}, {witnesses[2].Occupation}; {witnesses[2].Role}\n");

            Console.WriteLine(
            "------------Options-----------\n" +
            "1. Interview Witness 1\n" +
            "2. Interview Witness 2\n" +
            "3. Interview Witness 3\n" +
            "4. Solve the Murder!\n" +
            "0. Return to previous menu"
            );
        
        string selection = Console.ReadLine() ?? "";
        Console.Clear();
        switch (selection)
        {
            case "1":
                WitnessQuestions.AskQuestion(witnesses[0]);
                Program.UserMove();
                break;
            case "2":
                WitnessQuestions.AskQuestion(witnesses[1]);
                break;
            case "3":
                WitnessQuestions.AskQuestion(witnesses[2]);
                break;
            case "4":
                solveMurder.SolveTheMurder();
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