namespace pt1

{

    public class TeamMember {

        public string Name {get; set;}

        public int SkillLevel {get; set;}

        public double CourageFactor {get; set;}

        public void ShowStats() {
           
            Console.WriteLine($"************************");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Skill Level: {SkillLevel}");
            Console.WriteLine($"Courage Factor: {CourageFactor}");
        }

}
}



