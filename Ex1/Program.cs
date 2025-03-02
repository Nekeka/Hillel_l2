namespace Ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product hleb = new Product("Bread", 10, 30);

            hleb.PrintMoney();
            hleb.ReducePrice(3, 4);
            hleb.PrintMoney();

        }

    }

}
