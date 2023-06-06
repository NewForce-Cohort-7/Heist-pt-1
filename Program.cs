namespace pt1
{

class Program
{
    static void Main(string[] args)
    {
        List<TeamMember> HeistTeam = new List<TeamMember>();

      

        Console.WriteLine("Plan Your Heist!");
        Console.WriteLine("--------------------------");
        Console.WriteLine("Enter the bank difficulty level ( 0-150 )");
    
           int BankDifficulty = int.Parse(Console.ReadLine());

        Console.WriteLine("Assemble your Crew");

        while(true){

        Console.WriteLine("Add Memeber, What's their name? ");

        string name = Console.ReadLine();

        if(name == ""){
            break;
        }

        Console.WriteLine("What's their Skill Level? ");
        int a;
        string skillLevel;
        while(true)
        {
        skillLevel = Console.ReadLine();
        if(int.TryParse(skillLevel, out a))
        {
        
        break;

        } 
        else
        {
            Console.WriteLine("Please enter a number ");
          
        }
        }

        Console.WriteLine("What's their Courage Factor? ");

        string courageFactor = Console.ReadLine();


        TeamMember newMember = new TeamMember(){
            Name = name,
            SkillLevel = int.Parse(skillLevel),
            CourageFactor = double.Parse(courageFactor)
        };

        HeistTeam.Add(newMember);

        Console.WriteLine($"{newMember.Name} has joined the team. you now have {HeistTeam.Count} members");

        Console.WriteLine("*************************");

        }
        int totalSkill = HeistTeam.Sum(x => x.SkillLevel);
        Console.WriteLine("How many trial attempts?");

        int trials = int.Parse(Console.ReadLine());

        int wins = 0;
        int losses = 0;

        for(int i = 0 ; i < trials; i++ ){

       
        int randomLuckValue = new Random().Next(-10, 10);
       int totalDifficulty = BankDifficulty + randomLuckValue;

        // Console.WriteLine();
        // Console.WriteLine($"Your team's skill level is {totalSkill} and the bank's difficulty level is {totalDifficulty}");

        if(totalSkill >= totalDifficulty){
            // Console.WriteLine("Congratulations, the heist was a success!");
            wins++;
        }
        else
        {
            // Console.WriteLine("Looks like something went wrong, the heist was a failure.");
            losses++;
        }

      
        }
             Console.WriteLine($"The heist was successful {wins} times and failed { losses } times.");


    }
}
}

// Phase Six
// The program should be updated to...

// At the beginning of the program, prompt the user to enter the difficulty level of the bank.
// At the end of the program, display a report showing the number of successful runs and the number of failed runs.