using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn
{
    class Product
    {
        public  string Name { get; private set;}
        public decimal Priсe { get; set;}
        protected int Quantity { get; private set;}

        //Конструктор
        public Product(string name, decimal price, int quantity)
        {
            Name = name;
            Priсe = price;
            Quantity = quantity;
        }

        public void AddStock(int amount) => Quantity += amount;
        
        public void RemoveStock(int amount) 
        {
            if (Quantity - amount <= 0)
            {
                Log("Значение меньше или равно нулю");
                return;
            }
            Quantity -= amount;
        }

        private void Log(string message) => Console.WriteLine(message);
    }
}
