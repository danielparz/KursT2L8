using System;
using System.Text;

namespace KursT2L8
{
    class Program
    {
        static void Main(string[] args)
        {
          
        }
        public static void Q1()
        {
            //Napisz program, który sprawdzi ile jest liczb pierwszych w zakresie 0 – 100.

            Console.WriteLine("Zad. 1");

            int counter = 0;

            for (int i = 2; i < 100;)
            {
               if(IsSimpleNumber(i))
                {
                    Console.Write($" {i} ");
                    counter++;
                }
                if (i == 2) i++;
                else i += 2;
            }

        }
        public static void Q2()
        {
            //Napisz program, w którym za pomocą pętli do…while znajdziesz wszystkie liczby parzyste z zakresu 0 – 1000.

            Console.WriteLine("Zad. 2");

            int num = 0;

            do
            {
                if (num % 2 == 0)
                    Console.WriteLine(num);
                num++;
            } while (num <= 1000);
        }
        public static void Q3()
        {
            //Napisz program, który zaimplementuje ciąg Fibonacciego i wyświetli go na ekranie.

            Console.WriteLine("Zad. 3");

            int count;
            Console.WriteLine("Podaj, ile wyrazów ciągu Fibonacciego chcesz wypisać: ");
            Int32.TryParse(Console.ReadLine(), out count);

            for(int i = 1; i <= count; i++)
                Console.Write(Fibonacci(i));
        }
        public static void Q4()
        {
            //Napisz program, który po podaniu liczby całkowitej wyświetli piramidę liczb od 1 do podanej liczby w formie jak poniżej: 
            //    1 
            //    2 3 
            //    4 5 6 
            //    7 8 9 10

            Console.WriteLine("Zad. 4");

            int line = 1;
            int count;
            int counter = 0;
            
            Console.WriteLine("Podaj, ile kolejnych liczb wyświetlić: ");
            Int32.TryParse(Console.ReadLine(), out count);

            for(int i = 1; i <= count; i++)
            {
                Console.Write($"{i} ");
                counter++;
                if (counter == line)
                {
                    Console.Write("\r\n");
                    counter = 0;
                    line++;
                }                
            }
        }
        public static void Q5()
        {
            //Napisz program, który dla liczb od 1 do 20 wyświetli na ekranie ich 3 potęgę.

            Console.WriteLine("Zad. 5");

            for(int i = 1; i <= 20; i++)
            {
                Console.WriteLine($"{i*i*i} ");
            }
        }
        public static void Q6()
        {
            //Napisz program, który dla liczb od 0 do 20 obliczy sumę wg wzoru:
            //1 + ½ +1 / 3 + ¼ itd.

            Console.WriteLine("Zad. 6");

            double sum = 0;

            for (int i = 1; i <= 20; i++)
                sum += (1 / i);
            Console.WriteLine($"Suma ciągu wynosi: {sum}");
        }
        public static void Q7()
        {
            //Napisz program, który dla liczby zadanej przez użytkownika narysuje diament 
            //o krótszej przekątnej o długości wprowadzonej przez użytkownika

            Console.WriteLine("Zad. 7");

            int d;
            Console.WriteLine("Podaj długość krótszej przekątnej diamentu: ");
            Int32.TryParse(Console.ReadLine(), out d);

            for(int i = 1; i <= d; i++)
            {
                // wcięcie
                for (int j = d - i; j > 0; j--)
                    Console.Write(" ");
                // gwiazdki
                for (int j = i; j > 0; j--)
                    Console.Write("* ");
                Console.WriteLine();
            }
            for(int i = d - 1; i > 0; i--)
            {
                for (int j = d - i; j > 0; j--)
                    Console.Write(" ");
                for (int j = i; j > 0; j--)
                    Console.Write("* ");
                Console.WriteLine();
            }

        }
        public static void Q8()
        {
            //            Napisz program, który odwróci wprowadzony przez użytkownika ciąg znaków. Np.
            //Testowe dane:
            //Abcdefg
            //Rezultat
            //Gfedcba

            Console.WriteLine("Zad. 8");

            Console.WriteLine("Podaj ciąg znaków: ");
            string input = Console.ReadLine();
            StringBuilder sb = new StringBuilder();
            for (int i = 1; i <= input.Length; i++)
                sb.Append(input[input.Length - i]);
            Console.WriteLine($"Wprowadzony ciąg znaków: {input}");
            Console.WriteLine($"odwrócony ciąg znaków: {sb.ToString()}");
        }
        public static void Q9()
        {
            //Napisz program, który zamieni liczbę dziesiętną na liczbę binarną.

            Console.WriteLine("Zad. 9");

            int number10;
            Console.WriteLine("Podaj liczbę w systemie dziesiętnym: ");
            Int32.TryParse(Console.ReadLine(), out number10);

            StringBuilder sb = new StringBuilder();

            while((double)number10 / 2 > 0)
            {
                sb.Append(number10 % 2);
                number10 /= 2;
            }
            string number2 = sb.ToString();
            sb.Clear();
            for (int i = 1; i <= number2.Length; i++)
                sb.Append(number2[number2.Length - i]);
            Console.WriteLine($"Liczba {number10} w systemie binarnym wygląda tak: {sb.ToString()}");
        }
        public static void Q10()
        {
            //Napisz program, który znajdzie najmniejszą wspólną wielokrotność dla zadanych 2 liczb.

            Console.WriteLine("Zad. 10");

            int a;
            int b;
            Console.WriteLine("Podaj pierwszą liczbę całkowitą: ");
            Int32.TryParse(Console.ReadLine(), out a);
            Console.WriteLine("Podaj drugą liczbę całkwitą: ");
            Int32.TryParse(Console.ReadLine(), out b);

            Console.WriteLine($"Najmniejsza wspólna wielokrotność licz {a} i {b} wynosi: {(a * b) / NWD(a, b)}");
        }
        public static int NWD(int a, int b)
        {
            int c;
            //if (a < b)
            //{
            //    c = a;
            //    a = b;
            //    b = c;
            //}
            while(b != 0)
            {
                c = a % b;
                a = b;
                b = c;
            }
            return a;
        }
        public static int Fibonacci(int n)
        {
            if (n == 1) return 0;
            if (n <= 3) return 1;
            else return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
        public static bool IsSimpleNumber(int a)
        {
            if (a == 2) return true;
            for (int i = 2; i <= Math.Sqrt(a); i++)            
                if (a % i == 0) return false;
            return true;
        }

    }
}