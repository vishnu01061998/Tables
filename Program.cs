namespace Tables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter the Limit");
            int limit = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine(i * j);
                }
                Console.WriteLine(" ");
            }
        }
    }
}