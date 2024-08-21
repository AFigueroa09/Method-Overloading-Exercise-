namespace MethodOverloading
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
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
