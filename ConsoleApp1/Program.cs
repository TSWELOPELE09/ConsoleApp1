internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter Your Name");
        Console.Write("Name:");
        String  name = Console.ReadLine();
        
        Console.WriteLine("Enter Your Surname");
        Console.Write("Surname: ");
        String surname = Console.ReadLine();
        Console.WriteLine(name.ToLower());
        Console.WriteLine(surname.ToUpper());
        Char SurnameFirstLetter = surname[0];
        Console.WriteLine(SurnameFirstLetter);

        Console.WriteLine(name.ToLower()+ " " + surname.ToUpper());
        Console.WriteLine(surname);

    }
}

