using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactoryDesignPattern
{
    public interface CriditCard
    {
        string GetCardName();
        int GetAnnualCharge();
        int GetCriditLimit();
    }
    public class Moneyback : CriditCard
    {
        public int GetAnnualCharge()
        {
            return 500;
        }

        public string GetCardName()
        {
            return "MoneyBack";
        }

        public int GetCriditLimit()
        {
            return 100000;
        }
    }
    public class Visa : CriditCard
    {
        public int GetAnnualCharge()
        {
            return 1500;
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
            return 200;
        }

        public string GetCardName()
        {
            return "Rupee";
        }

        public int GetCriditLimit()
        {
            return 100000;
        }
    }

class CriditCardFactory
    {
        public static CriditCard GetCriditCard(string cardType)
        {
            CriditCard cardDetails = null;

            if (cardType == "Moneyback")
            {
                cardDetails = new Moneyback();
            }
            else if (cardType == "Visa")
            {
                cardDetails = new Visa();
            }
            else if (cardType == "Rupee")
            {
                cardDetails = new Rupee();
            }
            return cardDetails;
        }
    }
    class SimpleFactoryDesingPOC
    {
        public static void Main()
        {
            CriditCard criditCard = CriditCardFactory.GetCriditCard("Visa");
            if(criditCard != null)
            {
                Console.WriteLine(criditCard.GetCardName());
                Console.WriteLine(criditCard.GetCriditLimit());
                Console.WriteLine(criditCard.GetAnnualCharge());
            }
        }
    }
}
