using System;

namespace Task_2._2__Bank_System_
{
    #region Bank Class
    abstract class Bank
    {
        public string FullName { get; set; }
        public string Card_Code { get; set; }
        public int CVV { get; set; }
        public decimal Balance { get; set; }

        public Bank(string FullName, string Card_Code, int CVV, decimal Balance)
        {
            this.FullName = FullName;
            this.Card_Code = Card_Code;
            this.CVV = CVV;
            this.Balance = Balance;
        }

        public abstract void Income(decimal money);
        public abstract void Expense(decimal money);
    }
    #endregion


    #region Unibank


    abstract class UniBank : Bank
    {
        public UniBank(string FullName, string Card_Code, int CVV, decimal Balance)
            : base(FullName, Card_Code, CVV, Balance)
        {
        }

        public override void Expense(decimal money)
        {
            if (money < 0)
            {
                return;
            }
            else
            {
                Balance -= (money + ((money * 15) / 1000));
            }
        }

        public override void Income(decimal money)
        {
            if (money < 0)
            {
                return;
            }
            else
            {
                Balance += money;
            }
        }
    }



    #endregion


    #region AccessBank
    abstract class AccessBank : Bank
    {
        public AccessBank(string FullName, string Card_Code, int CVV, decimal Balance)
            : base(FullName, Card_Code, CVV, Balance)
        {
        }

        public override void Expense(decimal money)
        {
            if (money < 0)
            {
                return;
            }
            else
            {
                Balance -= (money + ((money * 16) / 1000));
            }
        }

        public override void Income(decimal money)
        {
            if (money < 0)
            {
                return;
            }
            else
            {
                Balance += (money - ((money * 3) / 1000));
            }
        }
    }
    #endregion


    #region PashaBank
    abstract class PashaBank : Bank
    {
        public PashaBank(string FullName, string Card_Code, int CVV, decimal Balance)
            : base(FullName, Card_Code, CVV, Balance) { }

        public override void Expense(decimal money)
        {
            if (money < 0)
            {
                return;
            }
            else
            {
                Balance -= (money + ((money * 11) / 1000));
            }
        }

        public override void Income(decimal money)
        {
            if (money < 0)
            {
                return;
            }
            else
            {
                Balance += (money - ((money * 6) / 1000));
            }
        }
    }


    #endregion


    #region LeoBank
    abstract class LeoBank : Bank
    {
        public LeoBank(string FullName, string Card_Code, int CVV, decimal Balance)
            : base(FullName, Card_Code, CVV, Balance)
        {
        }

        public override void Expense(decimal money)
        {
            if (money < 0)
            {
                return;
            }
            else
            {
                Balance -= money;
            }
        }

        public override void Income(decimal money)
        {
            if (money < 0)
            {
                return;
            }
            else
            {
                Balance += money;
            }
        }
    }
    #endregion
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(AccessBank.Balance); 
        }
    }
}
