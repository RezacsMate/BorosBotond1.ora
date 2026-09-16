namespace anisza
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Friend!");
            

            Kutya dog1 = new Kutya("Bodri", "Labrador", 5);
            Kutya dog2 = new Kutya("Morzsi", "Beagle", 3);
            Console.WriteLine("****************************************************");
            Console.WriteLine(dog1);
            Console.WriteLine(dog2);
            Phone phone1 = new Phone("Samsung", "Galaxy S24");
            Phone phone2 = new Phone("Apple", "iPhone 16", 350000);
            Console.WriteLine("****************************************************");
            Console.WriteLine(phone1);
            Console.WriteLine(phone2);
            Player player1 = new Player("Steve");
            Player player2 = new Player("Alex",5,1200 );
            Console.WriteLine("****************************************************");
            Console.WriteLine(player1);
            Console.WriteLine(player2);
            Car car1 = new Car("Toyota", "Corolla", 2018);
            Car car2 = new Car("BMW", "320i", 2021);
            Console.WriteLine("****************************************************");
            Console.WriteLine(car1);
            Console.WriteLine(car2);
            Movie movie1 = new Movie("Interstellar", 8.7);
            Movie movie2 = new Movie("Minecraft Movie", 5.6);
            Console.WriteLine("****************************************************");
            Console.WriteLine(movie1);
            Console.WriteLine(movie2);
            Product product1 = new Product("Laptop", 350000, 20);
            Product product2 = new Product("Monitor", 120000, 15);
            Console.WriteLine("****************************************************");
            Console.WriteLine(product1);
            Console.WriteLine(product2);
        }
    }
}
