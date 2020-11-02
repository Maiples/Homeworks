using System;
using System.Security.Cryptography.X509Certificates;

namespace Калькулятор
{
    class Program
    {
        static void Main(string[] args)
        {
        d: Console.WriteLine("Выбирите операцию которую хотите выполнить:\n" +
        "1.Сложение\n" +
        "2.Вычитание\n" +
        "3.Умножение\n" +
        "4.Деление\n" +
        "5.Возведение в степень\n" +
        "6.Факториал\n");

            int b = (Convert.ToInt32(Console.ReadLine()));
            switch (b)
            {
                case 1:
                    Sum();
                    break;
                case 2:
                    Vitch();
                    break;
                case 3:
                    Proiz();
                    break;
                case 4:
                    Chast();
                    break;
                case 5:
                    Stepen();
                    break;
                case 6:
                    Factor();
                    break;

                default:
                    Console.WriteLine("Ошибка, выбирите от 1 -6");
                    goto d;
                    break;


            }

            do
            {


            f: Console.WriteLine("Выбирите операцию которую хотите выполнить:\n" +
           "1.Сложение\n" +
           "2.Вычитание\n" +
           "3.Умножение\n" +
           "4.Деление\n" +
           "5.Возведение в степень\n" +
           "6.Факториал\n");

             int v = (Convert.ToInt32(Console.ReadLine()));


                switch (v)
                {
                    case 1:
                        Sum();
                        break;
                    case 2:
                        Vitch();
                        break;
                    case 3:
                        Proiz();
                        break;
                    case 4:
                        Chast();
                        break;
                    case 5:
                        Stepen();
                        break;
                    case 6:
                        Factor();
                        break;

                    default:
                        Console.WriteLine("Ошибка, выбирите от 1 -6");
                        goto f;
                        break;


                }
               
            }

            while (b != 6);


        }

        static void Sum()
        {
            Console.WriteLine("Введите первое число:");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите второе число:");
            double b = Convert.ToDouble(Console.ReadLine());
            double c = a + b;
            Console.WriteLine("Ответ: " + c);
            Console.ReadLine();
            Console.Clear();

        }

        static void Vitch()
        {
            Console.WriteLine("Введите первое число:");
            double l = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите второе число:");
            double m = Convert.ToDouble(Console.ReadLine());
            double v = l - m;
            Console.WriteLine("Ответ: " + v);
            Console.ReadLine();
            Console.Clear();
        }

        static void Proiz()
        {
            Console.WriteLine("Введите первое число:");
            double n = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите второе число:");
            double o = Convert.ToDouble(Console.ReadLine());
            double x = n * o;
            Console.WriteLine("Ответ: " + x);
            Console.ReadLine();
            Console.Clear();
        }

        static void Chast()
        {
        b: Console.WriteLine("Введите первое число:");
            double sd = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите второе число:");
            double vb = Convert.ToDouble(Console.ReadLine());
            if (sd == 0 || vb == 0)
            {
                Console.WriteLine("На ноль делить нельзя, попробуйте еще раз!");
                goto b;
            }
            double po = sd / vb;
            Console.WriteLine("Ответ: " + po);
            Console.ReadLine();
            Console.Clear();

        }


        static void Stepen()
        {
            Console.WriteLine("Введите число:");
            double ko = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите степень в которую хотите возвести:");
            double vm = Convert.ToDouble(Console.ReadLine());
            double res1 = Math.Pow(ko, vm);


            Console.WriteLine("Ответ: " + res1);
            Console.ReadLine();
            Console.Clear();
        }

        static void Factor()
        {
            Console.WriteLine("Введите число, факториал которого хотите найти:");
            double bn = Convert.ToDouble(Console.ReadLine());
            double res = 1;
            while (bn != 1)
            {
                res = res * bn--;
            }
            Console.WriteLine($"{res}");
            Console.ReadLine();
            Console.Clear();
        }

        static void End()
        {   Console.ReadLine();
            Console.Clear();
        }
    }
}
    

