namespace CsTasks
{
    internal class Program
    {

        static void Main(string[] args)
        {

            //1.Napisz program, który sprawdzi ile jest liczb pierwszych w zakresie 0 – 100.

            for (int i = 2; i <= 100; i++)
            {
                if (i == 2 || i == 3 || i == 5 || i == 7)
                {
                    Console.WriteLine(i);
                }

                if (i % 2 == 0 || i % 3 == 0 || i % 5 == 0 || i % 7 == 0)
                {
                    continue;
                }
                else
                {
                    Console.WriteLine(i);
                }
            }


            //2.Napisz program, w którym za pomocą pętli do…while znajdziesz wszystkie liczby parzyste z
            //zakresu 0 – 1000.

            int i = 0;

            do
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }

                i++;

            } while (i <= 1000);


            //3.Napisz program, który zaimplementuje ciąg Fibonacciego i wyświetli go na ekranie.


            int a = 0;
            int b = 1;
            int c = 0;

            for (int i = 1; i <= 10; i++)
            {

                c = a + b;
                a = b;
                b = c;

                Console.Write(c);
                Console.Write(" ");
            }



            //4.Napisz program, który po podaniu liczby całkowitej wyświetli piramidę liczb od 1 do podanej
            //liczby w formie jak poniżej:
            //1
            //2 3
            //4 5 6
            //7 8 9 10


            int current = 1;
            int jump = 2;

            int amount = Int32.Parse(Console.ReadLine());

            for (int i = 1; i <= amount; i++)
            {
                if (i == 1)
                {
                    Console.WriteLine(i);
                    continue;
                }

                if (i == current + jump)
                {
                    Console.Write(i);
                    Console.WriteLine();
                    current = i;
                    jump++;
                }
                else
                {
                    Console.Write(i);
                    Console.Write(" ");
                }
            }


            //5.Napisz program, który dla liczb od 1 do 20 wyświetli na ekranie ich 3 potęgę.


            for (int i = 1; i <= 20; i++)
            {
                Console.WriteLine($"Dla liczby {i}, trzecia potęga wynosi: {i * i * i}");
            }


            //6.Napisz program, który dla liczb od 0 do 20 obliczy sumę wg wzoru:
            //1 + ½ +1 / 3 + ¼ itd.


            double i = 0;
            double result = 0;

            while (i <= 20)
            {
                result = i + i / 2 + i / 3 + i / 4;

                Console.WriteLine($"Wynik dla liczby {i} wynosi: {result}");

                i++;
            }


            //7.Napisz program, który dla liczby zadanej przez użytkownika narysuje diament o krótszej
            //przekątnej o długości wprowadzonej przez użytkownika i wg wzoru:

            Console.Write("Podaj długość przekątnej: ");
            int x = Int32.Parse(Console.ReadLine());
            int y = x;
            char[,] chars = new char[x + 1, y + 1];

            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    chars[i, j] = ' ';
                }
            }


            int a = 0;
            for (int i = 0; i < x / 2; i++)
            {

                chars[i, y / 2] = '*';
                chars[i, y / 2 + a] = '*';
                chars[i, y / 2 - a] = '*';

                for (int j = y / 2; j < y / 2 + a; j++)
                    chars[i, j] = '*';

                for (int j = y / 2; j > y / 2 - a; j--)
                    chars[i, j] = '*';

                a++;
            }


            for (int i = 0; i < y; i++)
            {
                chars[x / 2, i] = '*';
            }


            int b = 0;
            for (int i = x - 1; i >= x / 2 + 1; i--)
            {
                chars[i, y / 2] = '*';

                chars[i, y / 2 - b] = '*';
                chars[i, y / 2 + b] = '*';

                for (int j = y / 2; j < y / 2 + b; j++)
                    chars[i, j] = '*';

                for (int j = y / 2; j > y / 2 - b; j--)
                    chars[i, j] = '*';

                b++;
            }


            for (int i = 0; i < chars[i, 0]; i++)
            {
                for (int j = 0; j < chars[i, j]; j++)
                {
                    Console.Write(chars[i, j]);
                }
                Console.WriteLine();
            }


            //8.Napisz program, który odwróci wprowadzony przez użytkownika ciąg znaków.Np.
            //Testowe dane:
            //Abcdefg
            //Rezultat
            //Gfedcba

            Console.Write("Wprowadź jakiś tekst:");
            string text = Console.ReadLine();

            Console.WriteLine(text);

            for (int i = text.Length - 1; i >= 0; i--)
            {
                Console.Write(text[i]);
            }

            //9.Napisz program, który zamieni liczbę dziesiętną na liczbę binarną.

            Console.Write("Podaj liczbę:");
            int decimalNumber = Int32.Parse(Console.ReadLine());

            string binaryNumber = "";

            for (int i = decimalNumber; i >= 1; i = i / 2)
            {
                if (i % 2 == 0)
                {
                    binaryNumber = binaryNumber + "0";
                }
                else
                {
                    i = i - 1;
                    binaryNumber = binaryNumber + "1";
                }
            }

            Console.Write($"{decimalNumber} w systemie binarnym: ");
            for (int i = binaryNumber.Length - 1; i >= 0; i--)
            {
                Console.Write(binaryNumber[i]);
            }


            //10.Napisz program, który znajdzie najmniejszą wspólną wielokrotność dla zadanych 2 liczb.


        

                Console.Write("Podaj liczbę A:");
                int a = Int32.Parse(Console.ReadLine());
                Console.Write("Podaj liczbę B:");
                int b = Int32.Parse(Console.ReadLine());

                List<int> divA = new List<int>();
                List<int> divB = new List<int>();

                Console.WriteLine("Liczba A:");
                divA = DivideByMaxValue(a);
                Console.WriteLine();
                Console.WriteLine("Liczba B:");
                divB = DivideByMaxValue(b);

                Console.WriteLine($"Dzielniki A:");
                foreach (int i in divA)
                {
                    Console.WriteLine(i);
                }

                Console.WriteLine($"Dzielniki B:");
                foreach (int i in divB)
                {
                    Console.WriteLine(i);
                }

                List<int> pairs = new List<int>();

                //Bierzemy większą ilość dzielników, mamy pewność że żadnego nie pominiemy 
                if (divA.Count > divB.Count)
                {
                    pairs = DrawThePairs(divB, divA);
                }
                else
                {
                    pairs = DrawThePairs(divA, divB);
                }
                Console.WriteLine();
                Console.WriteLine("Pary liczb:");
                foreach (int i in pairs)
                {
                    Console.WriteLine(i);
                }

                List<int> noPairsA = new List<int>();
                List<int> noPairsB = new List<int>();

                noPairsA = IsolateNoPair(pairs, divA);
                noPairsB = IsolateNoPair(pairs, divB);

                Console.WriteLine();
                Console.WriteLine("Bez pary liczby A:");
                foreach (int i in noPairsA)
                {
                    Console.WriteLine(i);
                }
                Console.WriteLine("Bez pary liczby B:");
                foreach (int i in noPairsB)
                {
                    Console.WriteLine(i);
                }
                Console.WriteLine();
                Console.WriteLine();

                List<int> summary = pairs.Concat(noPairsA).Concat(noPairsB).ToList();

                int nWW = 1;

                foreach (int i in summary)
                {
                    nWW = nWW * i;
                }

                Console.WriteLine($"NWW: {nWW}");
            
            //Funkcje do zadania 10
            //Ta funkcja znajduje nam najmniejszy możliwy dzielnik dla danej liczby i zapisuje do listy
            static List<int> DivideByMaxValue(int num)
            {

                int[] primeNumbers = { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97 };
                List<int> divisor = new List<int>();

                Console.WriteLine(num);
                while (num > 1)
                {

                    for (int i = primeNumbers[0]; num >= i; i++)
                    {
                        if (num % 2 == 0)
                        {
                            divisor.Add(2);
                            num = num / 2;

                        }
                        else if (num % 3 == 0)
                        {
                            divisor.Add(3);
                            num = num / 3;
                        }
                        else
                        {
                            if (num % i == 0)
                            {
                                divisor.Add(i);
                                num = num / i;
                            }
                            else
                            {
                                continue;
                            }
                        }

                        Console.WriteLine(num);
                    }

                }

                Console.WriteLine();

                return divisor;
            }

            //Teraz chcemy uzyskać pary liczb występujących w obu dzielnikach, jak już mamy to dopisujemy 0, aby nie dodawało tego 	samego 	dzielnika(na tej samej pozycji) do listy
            //W funkcjach są tworzone listy tymczasowe, aby nie zmodyfikować wartości w liście,w której nie chcemy
            static List<int> DrawThePairs(List<int> m, List<int> n)
            {
                List<int> pairsOfDivisors = new List<int>();
                List<int> nTemp = new List<int>();
                nTemp.AddRange(n);

                for (int i = 0; i <= m.Count - 1; i++)
                {
                    for (int j = 0; j <= nTemp.Count - 1; j++)
                    {
                        if (m[i] == nTemp[j])
                        {
                            pairsOfDivisors.Add(m[i]);
                            nTemp[j] = 0;
                            break;
                        }

                    }
                }

                return pairsOfDivisors;
            }

            //Pozostało jedynie wyodrębić dzielniki pozostawione bez pary
            static List<int> IsolateNoPair(List<int> pair, List<int> divisors)
            {
                List<int> rest = new List<int>();

                List<int> p = new List<int>();
                p.AddRange(pair);

                for (int i = 0; i <= p.Count - 1; i++)
                {
                    for (int j = 0; j <= divisors.Count - 1; j++)
                    {

                        if (divisors[j] == p[i])
                        {
                            p[i] = 0;
                            divisors[j] = 0;
                            break;

                        }
                    }
                }

                for (int i = 0; i <= divisors.Count - 1; i++)
                {
                    if (divisors[i] != 0)
                    {
                        rest.Add(divisors[i]);
                    }
                }

                return rest;
            }

        }

    }
}