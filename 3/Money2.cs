using ConsoleApp18;
using PairClasses;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _3;

namespace PairClasses
{
    internal class Money2: IPair
    {
        int odin;
        int dva;
        int pyat;
        int desat;
        int sto;
        int pyatsot;
        int tycha;
        int pyattych;
        double kop;
        double pyatkop;
        double desatkop;
        double pisatkop;

        double totalSumm;

        public Money2()
        {
            odin = 0;
            dva = 0;
            pyat = 0;
            desat = 0;
            sto = 0;
            pyatsot = 0;
            tycha = 0;
            pyattych = 0;
            kop = 0;
            pyatkop = 0;
            desatkop = 0;
            pisatkop = 0;

            totalSumm = 0;
        }

        public Money2(int odin, int dva, int pyat, int desat, int sto, int pyatsot, int tycha, int pyattych, double kop, double pyatkop, double desatkop, double pisatkop)
        {
            this.odin = odin;
            this.dva = dva;
            this.pyat = pyat;
            this.desat = desat;
            this.sto = sto;
            this.pyatsot = pyatsot;
            this.tycha = tycha;
            this.pyattych = pyattych;
            this.kop = kop;
            this.pyatkop = pyatkop;
            this.desatkop = desatkop;
            this.pisatkop = pisatkop;

            totalSumm = odin + dva * 2 +  pyat * 5 + desat * 10 + sto * 100
            + pyatsot * 500 + tycha * 1000 + pyattych * 5000 + kop * 0.01 + pyatkop * 0.05 + desatkop * 0.1 + pisatkop * 0.5;
            
        }

        public IPair Add(Object obj)
        {
            if (obj is Money2)
            {
                Money2 money = (Money2)obj;

                int odin = this.odin + money.odin;
                int dva = this.dva + money.dva;
                int pyat = this.pyat + money.pyat;
                int desat = this.desat + money.desat;
                int sto = this.sto + money.sto;
                int pyatsot = this.pyatsot + money.pyatsot;
                int tycha = this.tycha + money.tycha;
                int pyattych = this.pyattych + money.pyattych;
                double kop = this.kop + money.kop;
                double pyatkop = this.pyatkop + money.pyatkop;
                double desatkop = this.desatkop + money.desatkop;
                double pisatkop = this.pisatkop + money.pisatkop;
                return new Money2(odin, dva, pyat, desat, sto, pyatsot, tycha, pyattych, kop, pyatkop, desatkop, pisatkop);
            }
            else
            {
                throw new ArgumentException("неверный тип даныых для сложения");
            }



        }

        public bool CompareTo(object obj)
        {
            if (obj is Money2)
            {
                Money2 money = (Money2)obj;

                return this.totalSumm > money.totalSumm;
            }
            else
            {
                throw new ArgumentException("неверный тип даныых для операции");
            }
        }

        public double Div(double v)
        {
            return this.totalSumm / v;
        }
        public double Division(Money2 money2)
        {

            return this.totalSumm / money2.totalSumm;
        }

        public IPair Mult(double v)
        {
           
                int odin = (int)(this.odin * v);
                int dva = (int)(this.dva * v);
                int pyat = (int)(this.pyat * v);
                int desat = (int)(this.desat * v);
                int sto = (int)(this.sto * v);
                int pyatsot = (int)(this.pyatsot * v);
                int tycha = (int)(this.tycha * v);
                int pyattych = (int)(this.pyattych * v);
                double kop = this.kop * v;
                double pyatkop = this.pyatkop * v;
                double desatkop = this.desatkop * v;
                double pisatkop = this.pisatkop * v;
                return new Money2(odin, dva, pyat, desat, sto, pyatsot, tycha, pyattych, kop, pyatkop, desatkop, pisatkop);
           

        }

        public IPair Sub(object obj)
        {
            if (obj is Money2)
            {
                Money2 money = (Money2)obj;

                int odin = this.odin - money.odin;
                int dva = this.dva - money.dva;
                int pyat = this.pyat - money.pyat;
                int desat = this.desat - money.desat;
                int sto = this.sto - money.sto;
                int pyatsot = this.pyatsot - money.pyatsot;
                int tycha = this.tycha - money.tycha;
                int pyattych = this.pyattych - money.pyattych;
                double kop = this.kop - money.kop;
                double pyatkop = this.pyatkop - money.pyatkop;
                double desatkop = this.desatkop - money.desatkop;
                double pisatkop = this.pisatkop - money.pisatkop;
                return new Money2(odin, dva, pyat, desat, sto, pyatsot, tycha, pyattych, kop, pyatkop, desatkop, pisatkop);
            }
            else
            {
                throw new ArgumentException("неверный тип даныых для сложения");
            }



        }

        public override string? ToString()
        {
            return $"Сумма в наминале {this.totalSumm}";
        }

    
    }

}
