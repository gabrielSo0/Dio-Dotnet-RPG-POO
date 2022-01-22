using POO.src.Entities;

namespace POO
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Hero> heroes = new List<Hero>()
            {
                new Knight("Arus", 22, "Knight", 100, 10),
                new Ninja("Wedge", 16, "Ninja", 80, 15),
                new WhiteWizard("Jenica", 30, "White Wizard", 50, 100),
                new BlackWizard("Topapa", 42, "Black Wizard", 60, 100)
            };

            foreach (var hero in heroes)
            {
                System.Console.WriteLine(hero);
            }
            
        }
    }
}