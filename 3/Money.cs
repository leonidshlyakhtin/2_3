
using ConsoleApp18;
using PairClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using _3;

namespace ConsoleApp18
{
    internal class Money : IPair
    {
        private long rub;
        private byte kop;

        public Money(long rubles, byte kopecks)
        {
            rub = rubles;
            kop = kopecks;
        }

        public IPair Add(Object value)
        {
            if (value is Money)
            {
                Money moneyValue = (Money)value;
                long rubles = rub + moneyValue.rub;
                byte kopecks = (byte)(kop + moneyValue.kop);
                if (kopecks >= 100)
                {
                    rubles++;
                    kopecks -= 100;
                }
                return new Money(rubles, kopecks);
            }
            else
            {
                throw new ArgumentException("арг об");
            }
        }

        public IPair Sub(Object value)
        {
            if (value is Money)
            {
                Money moneyValue = (Money)value;
                long rubles = this.rub - moneyValue.rub;
                byte kopecks = (byte)(kop - moneyValue.kop);
                if (kopecks < 0)
                {
                    rubles--;
                    kopecks += 100;
                }
                if (rubles < 0)
                {
                    throw new ArgumentOutOfRangeException("не отрц");
                }
                return new Money(rubles, kopecks);
            }
            else
            {
                throw new ArgumentException("арг маней");
            }
        }

        public IPair Mult(double value)
        {
            long totalKopecks = (long)(rub * 100 + kop);
            totalKopecks = (long)(totalKopecks * value);
            long rubles = totalKopecks / 100;
            byte kopecks = (byte)(totalKopecks % 100);
            return new Money(rubles, kopecks);
        }

        public Money Div(double value)
        {
            long totalKopecks = (long)(rub * 100 + kop);
            totalKopecks = (long)(totalKopecks / value);
            long rubles = totalKopecks / 100;
            byte kopecks = (byte)(totalKopecks % 100);
            return new Money(rubles, kopecks);
        }

        public bool CompareTo(Object obj)
        {
            if (obj is Money)
            {
                Money money = (Money)obj;

                if (rub > money.rub)
                {
                    return true;
                }
                else if (rub < money.rub)
                {
                    return false;
                }
                else if (kop > money.kop)
                {
                    return true;
                }
                else if (kop < money.kop)
                {
                    return false;
                }
                else
                {
                    return false;
                }
            }

            else
            {
                throw new ArgumentException("арг маней");
            }
        }


    public override string? ToString()
        {
            return $"{rub},{kop:00} rub.";
        }

    }
}