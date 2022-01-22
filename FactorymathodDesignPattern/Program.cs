using System;

namespace FactorymathodDesignPattern
{
    
        public interface CriditCard
        {
            string GetCardName();
            int GetAnnualCharge();
            int GetCriditLimit();
        }

        public class Visa : CriditCard
        {
            public int GetAnnualCharge()
            {
                return 10000;
            }

            public string GetCardName()
            {
                return "Visa";
            }

            public int GetCriditLimit()
            {
                return 100000;
            }
        }

        public class Rupee : CriditCard
        {
            public int GetAnnualCharge()
            {
                return 10230;
            }

            public string GetCardName()
            {
                return "Rupee";
            }

            public int GetCriditLimit()
            {
                return 15000;
            }
        }

        public class Master : CriditCard
        {
            public int GetAnnualCharge()
            {
                return 1400;
            }

            public string GetCardName()
            {
                return "Master";
            }

            public int GetCriditLimit()
            {
                return 190000;
            }
        }

        public abstract class CriditCardFactory
        {
            public abstract CriditCard GetCriditCard();
            public CriditCard MakeProduct()
            {
               return this.GetCriditCard();
            }
        }

    public class VisaCardFactory : CriditCardFactory
    {
        public override CriditCard GetCriditCard()
        {
            CriditCard Card = new Visa();
            return Card;
        }
    }
    public class RupeeCardFactory : CriditCardFactory
    {
        public override CriditCard GetCriditCard()
        {
            CriditCard card = new Rupee();
            return card;
        }
    }

    public class MastrCardFactory : CriditCardFactory
    {
        public override CriditCard GetCriditCard()
        {
            CriditCard card = new Master();
            return card;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            CriditCard criditCard = new MastrCardFactory().GetCriditCard();
            Console.WriteLine(criditCard.GetCardName());
            Console.WriteLine(criditCard.GetCriditLimit());
            Console.WriteLine(criditCard.GetAnnualCharge());
        }
    }
}
