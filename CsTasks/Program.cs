namespace CsTasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Zadania - Typy danych
            //zad.1
            string name = "Jan";
            string surname = "Nowak";
            int age = 55;
            char sex = 'm';
            long pesel = 12345678901;
            long emp_nr = 2509324094;

            //zad.2
            string name2 = "Jerzyk";
            int price = 20;
            char sign = 'm';

            Console.WriteLine(sign);
            Console.WriteLine(price);
            Console.WriteLine(name2);

            //zad.3
            Console.WriteLine("Length diagonal of rectangle.");
            double length = 6;
            double width = 4;
            double diagonal = 0;

            diagonal = Math.Sqrt(Math.Pow(length, 2) + Math.Pow(width, 2));

            Console.WriteLine(diagonal);


            //zadd. 4
            int num1 = 10;
            string name3 = "Szkola Dotneta";
            double num2 = 12.5;
            Console.WriteLine(num1);
            Console.WriteLine(name);
            Console.WriteLine(num2);

            //zad5.
            Console.Write("Podaj imie: ");
            string name4 = Console.ReadLine();
            Console.Write("Podaj nazwisko: ");
            string surname2 = Console.ReadLine();
            Console.Write("Podaj numer: ");
            int number = Int32.Parse(Console.ReadLine());
            Console.Write("Podaj adres: ");
            string address = Console.ReadLine();
            Console.Write("Podaj wzrost: ");
            double height = Double.Parse(Console.ReadLine());
            Console.Write("Podaj wage: ");
            double weight = Double.Parse(Console.ReadLine());

            Console.WriteLine($"Your name is {name4}.");
            Console.WriteLine($"Your surname is {surname2}.");
            Console.WriteLine($"Your number is {number}.");
            Console.WriteLine($"Your address is {address}.");
            Console.WriteLine($"Your height is {height} cm.");
            Console.WriteLine($"Your weight is {weight} kg.");
        }
    }
}