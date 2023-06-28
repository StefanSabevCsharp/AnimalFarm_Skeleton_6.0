﻿namespace _3._Shopping_Spree.Models
{
    public class Person
    {
        private string name;
        private decimal money;

        private List<Product> bagOfProducts;

        public Person(string name, decimal money)
        {
            Name = name;
            Money = money;
            BagOfProducts = new List<Product>();
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (value == null || value == string.Empty || value == " ")
                {
                    throw new ArgumentException("Name cannot be empty");
                }
                name = value;
            }
        }
        public decimal Money
        {
            get => money;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Money cannot be negative");
                }
                money = value;
            }
        }
        public List<Product> BagOfProducts
        {
            get
            {
                return bagOfProducts;
            }

            set
            {
                bagOfProducts = value;
            }
        }

    }
}