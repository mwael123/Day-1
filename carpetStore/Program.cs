namespace carpetStore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("25$ per small carpet");
            Console.WriteLine("35$ per large carpet");
            Console.WriteLine("======================================");
            Console.WriteLine("please Enter Number of small carpets");
            int sCarpet = int.Parse(Console.ReadLine());
            Console.WriteLine("please Enter Number of large carpets");
            int lCarpet = int.Parse(Console.ReadLine());
            int total = sCarpet + lCarpet;
            Console.WriteLine($"Cost : {total}$");
            double Tax = total * 0.06;
            Console.WriteLine($"Tax : {Tax}$ ");
            Console.WriteLine("======================================");
            Console.WriteLine($"Total estimate:{total+Tax}$");
            Console.WriteLine($"This estimate is valid for 30 days");


        }
    }
}
