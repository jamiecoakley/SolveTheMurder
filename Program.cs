using System.Security.Cryptography;


public class Program
{
    public static void Main()
    {


        Suspect suspect1 = new Suspect("Carol McCormick",
                                        35,
                                        "Homemaker",
                                        "Wife",
                                        false,
                                        true,
                                        new List<string>{
                                "I was at home seething... Stuart went out to the bar again! I was home alone, washing the dishes after having cooked an extravagent casserole and salad dinner. Someone has to clean up and it certainly wasn’t going to be him.\n\n",
                                "He’s a good-for-nothing scoundrel who goes out to the bar too much! There’s no way he’s not cheating on me, gone until all hours of the night.\n\n",
                                "Nope, wasn’t there.\n\n",
                                "Nope, I wasn’t there....\n\n"},
                                        null,
                                        new List<string> {
                                "CAROL McCORMICK'S PHONE:\n" + 
                                "Last text message to Stuart McCormick: 'Whatever. I know you won’t be coming home tonight. Hope you enjoyed your dinner!' \n" +
                                "Voicemail from florist: 'Hi Mrs. McCormick! This is Jamie from Efflorescence. Just wanted to make sure all those daffodils were to your satisfaction! Normally I wouldn't worry about this, but with the quantity, I just wanted to warn you to keep them away from your pets because they can be toxic. Have a good day!'\n\n",
                                "STUART & CAROL McCORMICK's HOME:\n" + 
                                "Daffodil blooms everywhere - in glasses, vases, on the counters, in the garbage... who needs this many daffodils??\n\n" });
        Suspect suspect2 = new Suspect("Angela Everwood",
                                        47,
                                        "Software Engineer",
                                        "Co-Worker",
                                        false,
                                        false,
                                        new List<string>{
                                "I was at the bar, sitting a few seats down from Stuart trying to ignore him! I wish there was any other bar to go to in this town where I could go to drown my sorrows… I don’t know why the boss gave Stuart the promotion after that crap he pulled a couple years ago. My friend, Sharon, met me there after work.\n\n",
                                "The boss gave Stuart the promotion I worked so hard for, even after his check fraud incident and coming into work drunk!\n\n",
                                "He was wobbly because he’s a stupid drunk! This is the only bar in this town! I couldn’t avoid him!\n\n",
                                "I was trying to ignore him. I don’t remember seeing his wife there. There’s no way he would bring her, they can’t stand each other.\n\n"
                                        },
                                        null,
                                        new List<string> {
                                "ANGELA EVERWOOD'S PHONE:\n" + 
                                "Text message to Sharon Marsh: 'I overheard that jerk on the phone with his wife. She sounded even more pissed than I am.'\n" +
                                "Notepad: 'I HATE HIM I HATE HIM I HATE HIM! Maybe I’ll find a way to 'make him” quit.'\n\n",
                                "ANGELA EVERWOOD'S HOME:\n" +
                                "Stuart McCormick’s permanent employee record, with his wife crossed out as the emergency contact.\n"+  
                                "Stuart McCormick’s picture on a dart board with several holes.\n\n" });

        Suspect suspect3 = new Suspect("Rusty Shackleford",
                                        69,
                                        "Exterminator",
                                        "Town crazy/acquanitance",
                                        true,
                                        false,
                                        new List<string>{
                                "I was trying to get Stu to buy me another beer. He bought me one last time! The bouncer kicked me out, so I was panhandling outside the bar to see if someone would give me beer money. I was just trying to get Stuart to buy me a beer by any means necessary!\n\n",
                                "We kinda got into it a year or so ago when I just wanted another beer the last time he bought me a beer. He could afford it! I saw all that cash in his wallet!\n\n",
                                "I didn’t do nothin’.\n\n",
                                "I’d have remembered seeing Carol in the bar! Angela pointed and whispered to the person sitting next to him… we made eye contact when Stu bought me a beer.\n\n"
                                        },

                                        new List<Crime>
                                        {
                                new Crime("Assault","Felony",new DateTime(2021,10,24),"Middle Park","Colorado"),

                                new Crime("Public Nuisance","Misdemeanor",new DateTime(2021,10,04),"Middle Park","Colorado"),

                                new Crime("Assault","Felony",new DateTime(2021,02,24),"Middle Park","Colorado"),

                                new Crime("Public Intoxication","Misdemeanor",new DateTime(2021,02,04),"Middle Park","Colorado"),
                                        },
                                        new List<string> {
                                "RUSTY SHACKLEFORD'S PHONE:\n" + 
                                "No phone to check; he has strong opinions on mainstream technology.\n\n",
                                "RUSTY SHACKLEFORD'S HOME:\n" + 
                                "Stuart McCormick’s business card with woman’s name and phone number on the back.\n" + 
                                "List of names entitled 'People who have bought me beers' with some names, including Stuart’s, underlined\n\n" });

        Witness witness1 = new Witness("Moe Szyslak", 62, "Bartender", "Served Stuart McCormick was ended up being his last beer.",
                                        new List<string>{"Nope, I didn’t see Carol. I used to call her to come get Stuart, but at this point, she won’t come get him anymore.\n\n",
                                                "I couldn’t help but overhear Angela talking to Sharon about how much she hated her co-worker who got the promotion she was supposed to get, and how the boss said if Stuart quits, she’ll backfill him, but that’s not good enough, blah blah blah.... \n\n",
                                                "I warned Stuart not to buy Rusty a beer… he didn’t listen. Rusty is crazy.\n\n",
                                                "Actually, yes, now that you mention it. It sure seemed like Stuart had to go to the bathroom a lot. At the time, I didn’t think anything of it because he could’ve pre-gamed for all I know; but in hindsight, maybe he was a bit sickly looking?\n\n"}
                                        );
        Witness witness2 = new Witness("Sharon Marsh", 42, "Receptionist", "Tried to help Stuart McCormick when he fell.",
                                        new List<string>{"No, there wasn’t a woman with him, but I couldn’t help but notice he was having a pretty animated phone conversation for a minute there… maybe it was her?\n\n",
                                                "I was there with Angela – we’re friends. Angela talked crap about Stuart all night, but didn’t want to go anywhere near him. She cringed every time Stuart walked past to go to the bathroom, which was quite a lot now that I think about it.\n\n",
                                                "I saw him buy that scruffy guy a beer, and he got mad when Stuart wouldn’t buy him another one. The bouncer ended up kicking him out.\n\n",
                                                "A dude keeling over and dying was pretty weird. He was my friend’s arch-nemesis and all, but I couldn’t just not try to help.\n\n"});
        Witness witness3 = new Witness("Blade Jaggart", 31, "Bouncer", "Was working in the bar when Stuart McCormick died.",
                                        new List<string>{"I literally have to talk to every single person when they come in; I don’t remember.\n\n",
                                                "My back was to them; didn’t see anything.\n\n",
                                                "Ugh, that guy… you buy him a beer once, and you’ll never hear the end of it! He was harassing the dead guy to buy him another beer, but he kept running off to the bathroom. I didn't want to have to break up another one of his fights, so I kicked him out. Unfortunately, I can’t make him stop asking people outside for beer money.\n\n",
                                                "What weirdo would tease a guy by buyin’ him a beer, and say no to keepin’ the buzz goin’?! That’s weird I tell ya!\n\n"});

        List<Suspect> suspects = new List<Suspect>() { suspect1, suspect2, suspect3 };
        List<Witness> witnesses = new List<Witness>() { witness1, witness2, witness3 };


        SuspectInterview suspectInterview = new SuspectInterview();
        WitnessInterview witnessInterview = new WitnessInterview();
        RunBackgroundCheck runBackgroundCheck = new RunBackgroundCheck();
        Forensics forensics = new Forensics();
        Warrants warrants = new Warrants();
        Unlawful unlawful = new Unlawful();

        SolveMurder solveMurder = new SolveMurder();
        

        Console.Clear();
        System.Console.WriteLine(@"   
 /   _____/ _____ _____  |  | |  |         \__    ___/_____  _  ______     /     \  __ _________  __| _/___________    /     \ ___.__. _______/  |_  ___________ ___.__.
 \_____  \ /     \\__  \ |  | |  |    ______ |    | /  _ \ \/ \/ /    \   /  \ /  \|  |  \_  __ \/ __ |/ __ \_  __ \  /  \ /  <   |  |/  ___/\   __\/ __ \_  __ <   |  |
 /        \  Y Y  \/ __ \|  |_|  |__ /_____/ |    |(  <_> )     /   |  \ /    Y    \  |  /|  | \/ /_/ \  ___/|  | \/ /    Y    \___  |\___ \  |  | \  ___/|  | \/\___  |
/_______  /__|_|  (____  /____/____/         |____| \____/ \/\_/|___|  / \____|__  /____/ |__|  \____ |\___  >__|    \____|__  / ____/____  > |__|  \___  >__|   / ____|
        \/      \/     \/                                            \/          \/                  \/    \/                \/\/         \/            \/       \/   ");
        System.Console.WriteLine("You are a Detective Clouseau, a small-town detective who’s just been assigned to a murder scene: the local bar, Skeeter's Bar and Cocktails. A long-time local resident, Stuart McCormick, had just finished a beer, when he suddenly fell off of his stool. Fellow patrons rushed to help him back up thinking the habitual drinker had merely lost his balance - only to find that he was dead! Your job is to prove yourself with old-fashioned detective work, and fast! \n\n\n");

        System.Console.WriteLine("Your Challenge: You have 10 moves to make to solve this case. You've narrowed it down to three suspects, and you need to come to a conclusion before the forensics come back - you've got a bet, and your pride, riding on this!");

        PauseAndWaitForKeypress();

        bool continueToRun = true;

        while (continueToRun)
        {
            Console.Clear();
            Console.WriteLine(
            "---Investigate The Murder!---\n" +
            "1. Interrogate Suspects\n" +
            "2. Interview Witnesses\n" +
            "3. Background Check(s)\n" +
            "4. Try for Warrant(s)\n" +
//            "5. Unlawful Tactics\n" +
            "5. Solve the Murder!\n" +
            "0. Exit"
            );

            string selection = Console.ReadLine() ?? "";
            switch (selection)
            {
                case "1":
                    Console.Clear();
                    suspectInterview.Suspects(suspects);
                    break;
                case "2":
                    Console.Clear();
                    witnessInterview.Witnesses(witnesses);
                    break;
                case "3":
                    Console.Clear();
                    runBackgroundCheck.Background(suspects);
                    break;
                case "4":
                    Console.Clear();
                    warrants.WarrantOptions(suspects);
                    break;
/*                 case "5":
                    unlawful.UnlawfulTactics(suspects);
                    break;
 */                case "5":
                    Console.Clear();
                    solveMurder.SolveTheMurder();
                    break;
                case "0":
                    continueToRun = false;
                    break;
                default:
                    Console.WriteLine("Please enter a valid selection.");
                    PauseAndWaitForKeypress();
                    break;
            }
        }
        Console.WriteLine("Goodbye!");

    }

    public static void PauseAndWaitForKeypress()
    {
        System.Console.WriteLine("Press enter to continue...");
        Console.ReadKey();
    }

    public static int userMoves = 100;

    public static void UserMove()
    {
        SolveMurder solveMurder = new SolveMurder();

        if (userMoves > 0)
        {
            Console.WriteLine($"You have {userMoves} moves left!\n\n");
        }
        else if (userMoves == 0)
        {
            System.Console.WriteLine("Forensic eveidence is in, make your determination!");
            PauseAndWaitForKeypress();
            solveMurder.SolveTheMurder();
        }
        else
        {
            Console.WriteLine("You lost the game, better luck next time :(");
            PauseAndWaitForKeypress();
            System.Environment.Exit(1);
        }

        userMoves--;
    }

}