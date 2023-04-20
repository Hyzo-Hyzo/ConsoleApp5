namespace ConsoleApp5
{
    public delegate int  MyDelegate(int a, int b);
    internal class Program
    {
        public static int Add(int a, int b)
        {
            return a+b;
        }

        public static int Substract(int a, int b)
        {
            return a - b;
        }

        public static int Multiplication(int a, int b)
        {
            return a * b;
        }

        public static int Division(int a, int b)
        {
            return a / b;
        }

        static void Main(string[] args)
        {
            MyDelegate myDelegate;
            Console.WriteLine("Enter 2 number : ");
            int num1=int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter '1' = +; '2' = -; '3' = *; '4' = /; ");
            int s=int.Parse(Console.ReadLine());
            switch (s)
            {
                case 1:
                    myDelegate = Add;
                    int res = myDelegate(num1, num2);
                    Console.WriteLine($" + res  {res}");
                    break;
                case 2:
                    myDelegate = Substract;
                    res = myDelegate(num1, num2);
                    Console.WriteLine($" - res  {res}");
                    break;
                case 3:
                    myDelegate = Multiplication;
                    res = myDelegate(num1, num2);
                    Console.WriteLine($" * res {res}");
                    break;
                case 4:
                    myDelegate = Division;
                    res = myDelegate(num1, num2);
                    Console.WriteLine($" / res  {res}");
                    break;
                default: Console.WriteLine("Error!");
                    break;
            }
           

        }
    }
}