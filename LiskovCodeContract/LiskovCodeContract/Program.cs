using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovCodeContract
{
    public abstract class GoodsBase
    {
        public string Title { get; private set; }

        public decimal Price { get; private set; }

        public GoodsBase(string title, decimal price)
        {
            // Pre and post conditions
            Contract.Requires(!String.IsNullOrEmpty(title));
            Contract.Requires<ArgumentNullException>(!String.IsNullOrEmpty(title), "Title cannot be null!");
            Contract.Requires(price >= 0);
            Contract.Ensures(Title == title);
            Contract.Ensures(Price == price);

            Title = title;
            Price = price;
        }

        public virtual decimal GetDiscount(decimal discount)
        {
            Contract.Requires<ArgumentException>(discount >= 0 && discount <= 0.5m, "Discount cannot exceed 50%!");
            return Price * discount;
        }
    }

    public class Electronics : GoodsBase
    {
        public Electronics(string title, decimal price)
            :base(title, price)
        { }
    }

    public class Diy : GoodsBase
    {
        public Diy(string title, decimal price)
            : base(title, price)
        { }

        public override decimal GetDiscount(decimal discount)
        {
            Contract.Requires<ArgumentException>(discount >= 0 && discount <= 0.7m, "Discount cannot exceed 70%!");
            return Price * discount;
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            GoodsBase electronic = new Electronics("TV set", 1500);
            PrintDiscount(electronic, 0.3m);

            GoodsBase diy = new Diy("Bucket", 150);
            PrintDiscount(electronic, 0.6m);

            Console.ReadLine();
        }

        static void PrintDiscount(GoodsBase goods, decimal discount)
        {
            Console.WriteLine($"Discount for {goods.Title} = {goods.GetDiscount(discount)}");
        }
    }
}
