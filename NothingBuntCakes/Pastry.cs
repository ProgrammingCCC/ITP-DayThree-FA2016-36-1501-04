using System;

namespace NothingBuntCakes
{
    class Pastry
    {
        public bool Sweet;
        public double BakeTime;
        public string Size;
        public double Price;

        public Pastry()
        {

        }

        public Pastry(bool sweet, double baketime, string size, double price)
        {
            Sweet = sweet;
            BakeTime = baketime;
            Size = size;
            Price = price;
        }

        public void About()
        {
            Console.WriteLine("A " + Size + " costs $" + Price);
        }
        public void Rise()
        {

        }
    }
}
