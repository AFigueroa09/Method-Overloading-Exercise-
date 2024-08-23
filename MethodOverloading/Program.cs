namespace MethodOverloading
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            var add1 = Add(2, 3);
            Console.WriteLine($"First sum method: 2 + 3 = {add1}");
            var add2 = Add(2.51, 3.5);
            Console.WriteLine($"Second sum method: 2.51 + 3.5 = {add2}");
            var add3 = Add(2.51, 3.5, false);
            Console.WriteLine($"third sum method, not currency: 2.51 + 3.5 ={add3}");
            var add4 = Add(2.51, 3.5, true);
            Console.WriteLine($"third sum method, is currency: 2.51 + 3.5 = {add4}");
        }

        static int Add (int num1, int num2)
        {
            return num1 + num2;
        }

        static double Add(double num1, double num2)
        {
            return num1 + num2;
        }

        static string Add(double num1, double num2, bool isCurrency)
        {
            string result = string.Empty;
            if (isCurrency)
            {
                result = $"{num1 + num2} dollars";
            } else
            {
                result = $"{num1 + num2}";
            }

            return result;
        }
    }
}
