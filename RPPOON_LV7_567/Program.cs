using System;

namespace RPPOON_LV7_567
{
    class Program
    {
        static void Main(string[] args)
        {

            //7.
            DVD dvd = new DVD("Pcelica maja Sesona 2", DVDType.SOFTWARE, 5000);
            VHS vhs = new VHS("Pcelica maja Sesona 1", 60000);
            Book book = new Book("Pcelica maja i pakosni mrav", 20);

            BuyVisitor visitor = new BuyVisitor();

            Console.WriteLine("Price of purchase dvd: " + dvd.Accept(visitor));
            Console.WriteLine("Price of purchase vhs: " + vhs.Accept(visitor));
            Console.WriteLine("Price of purchase book: " + book.Accept(visitor));

            Console.WriteLine();


            //6.
            RentVisitor renter = new RentVisitor();
            double price = dvd.Accept(renter);
            if(double.IsNaN(price))
            {
                Console.WriteLine("DVD can't be rented!");
            }
            else
            {
                Console.WriteLine("Price of rent dvd: " + price);
            }
            Console.WriteLine("Price of rent vhs: " + vhs.Accept(renter));
            Console.WriteLine("Price of rent book: " + book.Accept(renter));

            //7.
            Cart cart = new Cart();
            cart.AddItem(dvd);
            cart.AddItem(vhs);
            cart.AddItem(book);
            Console.WriteLine();
            Console.WriteLine("Total cart price: " + cart.Accept(renter));
        }
    }
}
