namespace Szkolenie
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello!!!");
            Console.WriteLine(Add(5, 2));
            Console.WriteLine(Subtract(5, 2));
            Console.WriteLine(Multiply(5, 2));
        }

        private static int Add(int v1, int v2)
        {
            return v1 + v2;
        }

        private static int Subtract(int v1, int v2)
        {
            return v1 - v2;
        }

		private static int Multiply(int v1, int v2)
        {
            return v1 * v2;
        }        
    }
}