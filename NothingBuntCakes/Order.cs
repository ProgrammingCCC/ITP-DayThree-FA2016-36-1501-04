using System;

namespace NothingBuntCakes
{
    class Order
    {

        public static void Run()
        {
            Console.Title = "Nothing Bunt Cakes!";
            Console.WriteLine("Nothing Bunt Cakes!");
            string input;
            double total;

            //create an instance of pastry for cake
            //Pastry cake = new Pastry();
            Pastry cake = new Pastry(true, 26, "large", 5.00);
            Pastry cupcake = new Pastry(true, 15, "gigantic", 20.50);
            Pastry swissroll = new Pastry(true, 10, "mini", 2);
            Pastry cookie = new Pastry(true, 15, "monstrous", .5);
            Pastry scone = new Pastry(false, 20, "scone sized", 1);

            //how many cakes would they like
            Console.WriteLine("How many cakes would you like?");
            cake.About();
            //read in the integer
            input = Console.ReadLine();
            //multiply the integer * the price of the cake
            total = Convert.ToInt32(input) * cake.Price;

            Console.WriteLine("How many cupcakes would you like?");
            cupcake.About();
            input = Console.ReadLine();
            total = total + Convert.ToInt32(input) * cupcake.Price;

            Console.WriteLine("How many swissrolls would you like?");
            swissroll.About();
            input = Console.ReadLine();
            total = total + Convert.ToInt32(input) * swissroll.Price;

            Console.WriteLine("How many cookies would you like?");
            cookie.About();
            input = Console.ReadLine();
            total = total + Convert.ToInt32(input) * cookie.Price;

            Console.WriteLine("How many scones would you like?");
            scone.About();
            input = Console.ReadLine();
            total = total + Convert.ToInt32(input) * scone.Price;

            Console.WriteLine("Total is $" + total);
            Console.ReadKey();
        }
    }
}
