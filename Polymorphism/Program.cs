namespace  Polymorphism
{
    public static class Program
    {
        public static void Main()
        {
            var registry = new UniversityRegistry();

            var prof = new Professor("Dr. Smith", "P-001");
            var ugs  = new UndergraduateStudent("Alice", "U-101");
            var gs   = new GraduateStudent("Bob", "G-201");

            registry.AddMember(prof);
            registry.AddMember(ugs);
            registry.AddMember(gs);

            registry.ExecuteAllDuties();

            prof.ConductResearch("Machine Learning");

            Console.WriteLine($"Total logged actions: {registry.GetMemberStatistics()}");

            try
            {
                prof.PerformDuties(); 
                prof.PerformDuties(); 
                prof.PerformDuties(); 
                prof.PerformDuties(); 
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine($"Limit reached as expected: {ex.Message}");
            }
        }
    }
}