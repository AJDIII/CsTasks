//using System;

//namespace CsTasks
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {

//            //Warunki
//            //Zad1

//            int a = 5;
//            int b = 5;

//            if (a == b)
//            {
//                Console.WriteLine($"{a} i {b} są równe.");
//            }


//            //Zad2

//            int a = Int32.Parse(Console.ReadLine());

//            if (a % 2 == 0)
//            {
//                Console.WriteLine($"{a} jest parzyste.");
//            }
//            else
//            {
//                Console.WriteLine($"{a} nie jest parzyste.");
//            }

//            //Zad3

//            int a = Int32.Parse(Console.ReadLine());

//            if (a > 0)
//            {
//                Console.WriteLine($"{a} jest dodatnia");
//            }
//            else if (a < 0)
//            {
//                Console.WriteLine($"{a} nie jest dodatnia");
//            }
//            else
//            {
//                Console.WriteLine($"Wpisałeś {a}");
//            }


//            //Zad4

//            Console.Write("Podaj rok: ");
//            int rok = Int32.Parse((Console.ReadLine()));

//            if (rok % 4 == 0)
//            {
//                Console.WriteLine($"Podany rok {rok} jest rokiem przystępnym.");
//            }
//            else
//            {
//                Console.WriteLine($"Podany rok {rok} nie jest rokiem przystępnym.");
//            }

//            //Zad5

//            Console.Write("Podaj wiek: ");
//            int wiek = Int32.Parse(Console.ReadLine());

//            if (wiek >= 21 && wiek < 30)
//            {
//                Console.WriteLine("Możesz zostać posłem lub premierem.");
//            }
//            else if (wiek >= 30 && wiek < 35)
//            {
//                Console.WriteLine("Możesz zostać posłem lub premierem, również senatorem.");
//            }
//            else if (wiek >= 35)
//            {
//                Console.WriteLine("Możesz zostać posłem lub premierem, również senatorem.");
//                Console.WriteLine("A nawet prezydentem.");
//            }
//            else
//            {
//                Console.WriteLine("Nie możesz kandydować na żadną pozycję.");
//            }


//            //Zad6

//            Console.Write("Podaj ile masz cm wzrostu: ");
//            double wzrost = Double.Parse(Console.ReadLine());

//            if (wzrost > 50 && wzrost <= 140)
//            {
//                Console.WriteLine("Jesteś krasnoludem.");
//            }
//            else if (wzrost > 140 && wzrost <= 160)
//            {
//                Console.WriteLine("Jesteś niski.");
//            }
//            else if (wzrost > 160 && wzrost <= 175)
//            {
//                Console.WriteLine("Jesteś średniego wzrostu.");
//            }
//            else if (wzrost > 175 && wzrost <= 195)
//            {
//                Console.WriteLine("Jesteś wysoki.");
//            }
//            else if (wzrost > 195 && wzrost <= 215)
//            {
//                Console.WriteLine("Pewnie jesteś koszykarzem.");
//            }
//            else if (wzrost > 215 && wzrost <= 230)
//            {
//                Console.WriteLine("Jesteś jakimś olbrzymem!");
//            }
//            else
//            {
//                Console.WriteLine("No way...");
//            }


//            //Zad7

//            Console.Write("Podaj liczbę - a: ");
//            int a = Int32.Parse(Console.ReadLine());
//            Console.Write("Podaj liczbę - b: ");
//            int b = Int32.Parse(Console.ReadLine());
//            Console.Write("Podaj liczbę - c: ");
//            int c = Int32.Parse(Console.ReadLine());


//            if (a == b && a > c && b > c)
//            {
//                Console.WriteLine($"Liczby a:{a} i b:{b} są największe i równe sobie.");
//            }
//            else if (a == c && a > b && c > b)
//            {
//                Console.WriteLine($"Liczby a:{a} i c:{c} są największe i równe sobie.");
//            }
//            else if (b == c && b > a && c > a)
//            {
//                Console.WriteLine($"Liczby b:{b} i c:{c} są największe i równe sobie.");
//            }
//            else if (a == b && a == c && b == c)
//            {
//                Console.WriteLine($"Nie ma największej liczby, ponieważ wszystkie podane są sobie równe.");
//            }
//            else
//            {
//                if (a > b)
//                {
//                    if (a > c)
//                    {
//                        Console.WriteLine($"Liczba a: {a} jest największa.");
//                    }
//                    else
//                    {
//                        Console.WriteLine($"Liczba c: {c} jest największa.");
//                    }
//                }
//                else if (b > c)
//                {
//                    Console.WriteLine($"Liczba b: {b} jest największa.");
//                }
//                else
//                {
//                    Console.WriteLine($"Liczba c: {c} jest największa.");
//                }
//            }




//            //Zad8

//            int mat = 80;
//            int fiz = 55;
//            int chem = 55;

//            // Wynik z matematyki + wybranego przedmiotu fizyka lub chemia >= 150  
//            if (mat >= 70 && mat + chem >= 150 || mat + fiz >= 150)
//            {

//                Console.WriteLine("Kandydat dopuszczony do rekrutacji");
//            }
//            else // Wynik brany pod uwagę ze wszystkich przedmiotów, ale suma już musi wynosić >= 180
//            {
//                if (mat < 70)
//                {
//                    Console.WriteLine("Za mało procent z matematyki.");
//                }
//                else if (fiz < 55)
//                {
//                    Console.WriteLine("Za mało procent z fizyki.");
//                }
//                else if (chem < 45)
//                {
//                    Console.WriteLine("Za mało procent z chemii.");
//                }
//                else if (mat >= 70 && fiz >= 55 && chem >= 45 && mat + fiz + chem >= 180)
//                {
//                    Console.WriteLine("Kandydat może ubiegać się o miejsce na studiach.");
//                }
//                else
//                {
//                    Console.WriteLine("Suma wyników z matematyki, fizyki i chemii nie osiągenła progu kwalifikacyjnego.");
//                }

//            }




//            //Zad9

//            int temp = Int32.Parse((Console.ReadLine()));

//            if (temp < 0)
//            {
//                Console.WriteLine("Cholernie piździ!");
//            }
//            else if (temp >= 0 && temp < 10)
//            {
//                Console.WriteLine("Zimno!");
//            }
//            else if (temp >= 10 && temp < 20)
//            {
//                Console.WriteLine("chłodno!");
//            }
//            else if (temp >= 20 && temp < 30)
//            {
//                Console.WriteLine("W sam raz!");
//            }
//            else if (temp >= 30 && temp < 40)
//            {
//                Console.WriteLine("Zaczyna być słabo, bo gorąco!");
//            }
//            else
//            {
//                Console.WriteLine("A weź wyprowadzam się na Alaskę!");
//            }



//            //Zad10


//            Console.Write("Podaj bok a: ");
//            int a = Int32.Parse(Console.ReadLine());
//            Console.Write("Podaj bok b: ");
//            int b = Int32.Parse(Console.ReadLine());
//            Console.Write("Podaj bok c: ");
//            int c = Int32.Parse(Console.ReadLine());

//            if (a + b > c && a + c > b && b + c > a)
//            {
//                Console.WriteLine("Z podanych długości można zbudować trójkąt.");
//            }
//            else
//            {
//                Console.WriteLine("Z podanych długości nie można zbudować trójkąta.");
//            }


//            //Zad11

//            int ocena = Int32.Parse(Console.ReadLine());

//            switch (ocena)
//            {

//                case 1:
//                    Console.WriteLine("Niedostateczny.");
//                    break;
//                case 2:
//                    Console.WriteLine("Dopuszczający.");
//                    break;
//                case 3:
//                    Console.WriteLine("Dostateczny.");
//                    break;
//                case 4:
//                    Console.WriteLine("Dobry.");
//                    break;
//                case 5:
//                    Console.WriteLine("Bardzo dobry.");
//                    break;
//                case 6:
//                    Console.WriteLine("Celujący.");
//                    break;
//                default:
//                    Console.WriteLine("Nie ma takiej oceny.");
//                    break;

//            }

//            //Zad12
              
//            int dzien = Int32.Parse(Console.ReadLine());

//            switch (dzien)
//            {
//                case 1:
//                    Console.WriteLine("Poniedziałek");
//                    break;
//                case 2:
//                    Console.WriteLine("Wtorek");
//                    break;
//                case 3:
//                    Console.WriteLine("Środa");
//                    break;
//                case 4:
//                    Console.WriteLine("Czwartek");
//                    break;
//                case 5:
//                    Console.WriteLine("Piątek");
//                    break;
//                case 6:
//                    Console.WriteLine("Sobota");
//                    break;
//                case 7:
//                    Console.WriteLine("Niedziela");
//                    break;
//                default:
//                    Console.WriteLine("Nie ma takiego dnia");
//                    break;
//            }

//            //Zad13

//            Console.Write("Podaj pierwszą liczbe: ");
//            double a = Double.Parse(Console.ReadLine());
//            Console.Write("Podaj drugą liczbe: ");
//            double b = Double.Parse(Console.ReadLine());

//            Console.WriteLine("Wybierz numer operacji do wykonania (od 1-4).");

//            Console.WriteLine("1.Dodawanie.");
//            Console.WriteLine("2.Odejmowanie.");
//            Console.WriteLine("3.Mnożenie.");
//            Console.WriteLine("4.Dzielenie.");

//            int operacja = Int32.Parse(Console.ReadLine());
//            double wynik = 0;

//            switch (operacja)
//            {
//                case 1:
//                    wynik = a + b;
//                    break;
//                case 2:
//                    wynik = a - b;
//                    break;
//                case 3:
//                    wynik = a * b;
//                    break;
//                case 4:
//                    if (b == 0)
//                    {
//                        Console.WriteLine("Nie dzielimy przez 0!");
//                        return;
//                    }
//                    else wynik = a / b;
//                    break;
//                default:
//                    Console.WriteLine("Nie ma takiej operacji!");
//                    break;

//            }

//            Console.WriteLine($"Wynik działania to: {wynik}.");


//        }
//    }
//}