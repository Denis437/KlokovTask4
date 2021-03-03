using System;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            Product1 product1 = new Product1("Carrot", 20, 200);
            product1.Print();

            Product2 product2 = new Product2("Water melon", 50, 120, 2019);
            product2.Print();

            Console.ReadLine();
        }
    }
    class Product1
    {
        public Product1(string name, double price, int count)
        {
            Name = name;
            Price = price;
            Count = count;
        }
        public string Name { get; private protected set; }
        public double Price { get; private protected set; }
        public int Count { get; private protected set; }
        public double Q
        {
            get
            {
                return Math.Round(Price / Count, 2);
            }
        }
        public virtual void Print()
        {
            Console.WriteLine($"Product : {Name}\r\nPrice : {Price}\r\nCount : {Count}\r\nQuality : {Q}\r\n");
        }
    }

    class Product2 : Product1      
    {
        public Product2(string name, double price, int count, int p) : base(name, price, count)
        {
            P = p;
        }
        public int P { get; private set; }
        public double Qp
        {
            get
            {
                return Q + 0.5 * (DateTime.Now.Year - P);
            }
        }
        public override void Print()
        {
            Console.WriteLine($"Product : {Name}\r\nPrice : {Price}\r\nCount : {Count}\r\nQuality : {Q}\r\nYear created : {P}\r\nQuality2 : {Qp}");
        }
    }
}
