namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Witaj, jak masz na imię?!");
            string name = Console.ReadLine();
            Console.Write("Podaj wiek: ");
            string sAge = Console.ReadLine();
            int age = Convert.ToInt32(sAge);

            Console.WriteLine($"Witaj {name}, masz {age} lat ");

            int currentYear = DateTime.Now.Year;

            Console.WriteLine($"Urodziłeś się w {currentYear - age} roku");
            Console.WriteLine("Naciśnij dowolny klawisz aby zakończyć...");
            Console.ReadKey();
        }
    }
}
