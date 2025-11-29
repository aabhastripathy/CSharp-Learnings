
namespace BurgerShopApp
{
    public class BurgerException : ApplicationException 
    {
        public BurgerException(string message):base(message) { }
    }
    public class Burger 
    {
        private static int idgen = 0;
        private int id;
        private string? name;
        private decimal price;
        public int ID {
            get { return id; }  
        }
        public string? Name { set; get; }
        public decimal Price { 
            set {
                if (value < 0)
                {
                    throw new BurgerException("Price!!");
                }
                else price = value;  
            }
            get {return price;}
        }
        public Burger( string Name, int Price) 
        {
            id = ID;
            name = Name;
            price = Price;
            id = ++idgen;
        }
        public override string ToString() 
        {
            string s =  ID + "," + Name + "," + Price;
            return s;
        }
    }
    public class OrderItems 
    {
        public Burger Burger { get; set; }
        public int Quantity { get; set; }
        public decimal GetTotal() 
        {
            return Burger.Price * Quantity;
        }
    }
    public class Order 
    {
        public List<OrderItems> Items { get; set; } = new List<OrderItems>();
        public void AddItem(Burger burger, int quantity) 
        {
            Items.Add(new OrderItems {Burger = burger,Quantity = quantity });
        }
        public decimal GetTotal() 
        {
            return Items.Sum(i => i.GetTotal());
        }
        public void DisplayBill() 
        {
            Console.WriteLine("\n---------BILL---------");
            foreach (var item in Items) 
            {
                Console.WriteLine($"{item.Burger.Name} X {item.Quantity} = ₹{item.GetTotal()}");
            }
            Console.WriteLine($"Total Amount : ₹{GetTotal()}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
           
            List<Burger> menue = new List<Burger>
            {
                new Burger("Classic Burger", 120),
                new Burger("Cheese Burger", 150),
                new Burger("Veggie Burger", 100),
                new Burger("Chicken Burger", 180)
            };
            //foreach (var item in menue) 
            //{
            //    Console.WriteLine(item);
            //}
            Order order = new Order();
            bool a = true;
            Console.WriteLine("🍔 Welcome to Aabhas Burger Shop 🍔\n");
            while (a) 
            {
                Console.WriteLine("Menue");
                foreach (var item in menue) 
                {
                    Console.WriteLine($"{item.ID}.{item.Name} - ₹{item.Price}");
                }
                Console.WriteLine("\n Enter the Id to order : ");
                int id = int.Parse(Console.ReadLine());
                var selected = menue.Find(b => b.ID == id);
                if (selected == null) 
                {
                    Console.WriteLine("Invalid Choice");
                    continue;
                }
                Console.WriteLine("Enter quantity: ");
                int quantity = int.Parse(Console.ReadLine()!);
                order.AddItem(selected, quantity);
                Console.WriteLine("Want more? (y/n): ");
                a = Console.ReadLine().ToLower() == "y";
            }
            order.DisplayBill();
        }
    }
}
