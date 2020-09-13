using Promotion_Engine.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Promotion_Engine
{
    public class PromotionClass
    {
        #region  Methods
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();

            Console.WriteLine("total number of order");
            int a = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < a; i++)
            {
                Console.WriteLine("enter the type of product:A,B,C or D");
                string type = Console.ReadLine();
                Product p = GetProductPrice(type);
                products.Add(p);
            }

            long totalPrice = CalculateTotalPrice(products);
            Console.WriteLine(totalPrice);
            Console.ReadLine();

        }
        public static Product GetProductPrice(string type)
        {
            Product item = new Product();
            item.Id = type;
            switch (type)
            {
                case "A":
                    item.Price = 50m;

                    break;
                case "B":
                    item.Price = 30m;

                    break;
                case "C":
                    item.Price = 20m;

                    break;
                case "D":
                    item.Price = 15m;
                    break;
            }
            return item;

        }
        public static long CalculateTotalPrice(List<Product> products)
        {
            int counterofA = 0;
            int priceofA = 50;
            int counterofB = 0;
            int priceofB = 30;
            int CounterofC = 0;
            int priceofC = 20;
            int CounterofD = 0;
            int priceofD = 15;
            foreach (Product pr in products)
            {
                if (pr.Id == "A" || pr.Id == "a")
                {
                    counterofA = counterofA + 1;
                }
                if (pr.Id == "B" || pr.Id == "b")
                {
                    counterofB = counterofB + 1;
                }
                if (pr.Id == "C" || pr.Id == "c")
                {
                    CounterofC = CounterofC + 1;
                }
                if (pr.Id == "D" || pr.Id == "d")
                {
                    CounterofD = CounterofD + 1;
                }
            }
            int totalPriceofA = (counterofA / 3) * 130 + (counterofA % 3 * priceofA);
            int totalPriceofB = (counterofB / 2) * 45 + (counterofB % 2 * priceofB);
            int totalPriceofC = (CounterofC * priceofC);
            int totalPriceofD = (CounterofD * priceofD);
            return totalPriceofA + totalPriceofB + totalPriceofC + totalPriceofD;

        }
    }

    #endregion
}

