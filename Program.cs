// See https://aka.ms/new-console-template for more information


namespace Calculator // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            
            int n = 7;
            int m = 2;
            try
            {
                // Simple Combination Formula: n!/((n-m)! * m!) 
                // ===== Factorial can be calculate using WHILE (Factorial) or FOR (Factorial1)            
                // Console.WriteLine( Factorial1(n)/(Factorial1(n-m)*Factorial1(m)));

                Console.WriteLine(Factorial1(n)/(Factorial1(n-m)*Factorial1(m)));
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                Console.ReadKey();
            }
        }
        private static int Factorial(int num)
        {
            int  factorial = 1;
            while (num != 1)
            {
                factorial *= num;
                num--;
            }
            return factorial;
        }
        private static int Factorial1(int num)
        {
            int factorial = 1;
            for (int n = 1; n <= num; n++)
            {
                factorial*=n;              
            }
            return factorial;

        }

    }
}
