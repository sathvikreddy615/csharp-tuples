using System;
using System.Collections.Generic;


namespace tuples
{
    class Program
    {
        static void Main(string[] args)
        {
            List<(string product, double amount, int quantity)> transactions = new List<(string, double, int)>();
            (string product, double amount, int quantity) hammer = ("Hammer", 20, 12); 
            (string product, double amount, int quantity) nails = ("Nails", 5, 22); 
            (string product, double amount, int quantity) screwdriver = ("Screwdriver", 10, 12); 
            (string product, double amount, int quantity) nailgun = ("Nail Gun", 50, 5); 
            (string product, double amount, int quantity) bandaid = ("Band Aid", 3, 65); 

            transactions.Add(hammer);
            transactions.Add(nails);
            transactions.Add(screwdriver);
            transactions.Add(nailgun);
            transactions.Add(bandaid);

            int TotalItemsSold = 0;
            double TotalRevenue = 0; 
            
            foreach ((string product, double amount, int quantity) item in transactions)

            {
                TotalItemsSold += item.quantity;
                TotalRevenue += item.amount*item.quantity;
            }
            Console.WriteLine($"Items sold today: {TotalItemsSold}");
            Console.WriteLine($"Total Revenue: ${TotalRevenue}");
        }
    }
}
