using System;
using System.Collections.Generic;

namespace dz6
{
    abstract class Currency
    {
        public double kolvo;
        public string name;
        public Currency(double kolvo, string name)
        {
            this.kolvo = kolvo;
            this.name = name;
        }
        public virtual double Translation()
        {
            throw new NotImplementedException();
        }
    }

    class Dollar : Currency
    {
        public Dollar(double kolvo) : base(kolvo, "Dollar")
        {
        }
        public override double Translation()
        {
            return kolvo * 64.88;
        }

    }

    class Euro : Currency
    {
        public Euro(double kolvo) : base(kolvo, "Euro")
        {
        }
        public override double Translation()
        {
            return kolvo * 69.08;
        }
    }

    class Yuan : Currency
    {
        public Yuan(double kolvo) : base(kolvo, "Yuan")
        {
        }
        public override double Translation()
        {
            return kolvo * 0.48;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.Write("Введите кол-во валюты: ");
                double n;
                string R;
                do
                {
                    R = Console.ReadLine();
                    if (double.TryParse(R, out n))
                    {
                        break;
                    }
                    Console.Write("Неправильно! Введите число:");
                } while (true);
                if (n < 0)
                {
                    Console.WriteLine("Видимо вы случайно поставили знак минуса, поэтому я сделал число положительным!");
                }
                double kolvo = Math.Abs(n);
                do
                {
                    Console.Write("Введите dollar, euro, yuan: ");

                    string type = Console.ReadLine();
                    if (type == "dollar")
                    {
                        var dollar = new Dollar(kolvo);
                        Console.WriteLine($"{kolvo} {type} это {dollar.Translation()} рублей");
                        break;
                    }
                    else if (type == "euro")
                    {
                        var euro = new Euro(kolvo);
                        Console.WriteLine($"{kolvo} {type} это {euro.Translation()} рублей");
                        break;
                    }
                    else if (type == "yuan")
                    {
                        var yuan = new Yuan(kolvo);
                        Console.WriteLine($"{kolvo} {type} это {yuan.Translation()} рублей");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Попробуйте снова, у вас получится.");
                    }
                } while (true);
            } while (true);
        }
    }
}
