//using System;

//namespace SimpleFactoryDesignPattern
//{
//    public interface CriditCard
//    {
//        string GetCardName();
//        int GetAnnualCharge();
//        int GetCriditLimit();
//    }
//    public class Moneyback : CriditCard
//    {
//        public int GetAnnualCharge()
//        {
//            return 500;
//        }

//        public string GetCardName()
//        {
//            return "MoneyBack";
//        }

//        public int GetCriditLimit()
//        {
//            return 100000;
//        }
//    }
//    public class Visa : CriditCard
//    {
//        public int GetAnnualCharge()
//        {
//            return 1500;
//        }

//        public string GetCardName()
//        {
//            return "Visa";
//        }

//        public int GetCriditLimit()
//        {
//            return 100000;
//        }
//    }
//    public class Rupee : CriditCard
//    {
//        public int GetAnnualCharge()
//        {
//            return 200;
//        }

//        public string GetCardName()
//        {
//            return "Rupee";
//        }

//        public int GetCriditLimit()
//        {
//            return 100000;
//        }
//    }
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            string cardType = "Visa";
//            CriditCard criditDetails = null;
//            if (cardType == "Moneyback")
//            {
//                criditDetails = new Moneyback();
//            }
//            else if (cardType == "Visa")
//            {
//                criditDetails = new Visa();
//            }
//            else if (cardType == "Rupee")
//            {
//                criditDetails = new Rupee();
//            }
//            if (criditDetails != null)
//            {
//                Console.WriteLine("CardType : " + criditDetails.GetCardName());
//                Console.WriteLine("CreditLimit : " + criditDetails.GetCriditLimit());
//                Console.WriteLine("AnnualCharge :" + criditDetails.GetAnnualCharge());
//            }
//            else
//            {
//                Console.WriteLine("Invalid Card Type!");
//            }
//            Console.ReadKey();
//        }
//    }
//}
