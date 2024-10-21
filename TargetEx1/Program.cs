namespace TargetEx1
{
    internal class Program
    {
        static bool seqFibonacci(int num)
        {
            int a = 0;
            int b = 1;

            while (b < num)
            {
                int n = a;
                a = b;
                b = n + b;
            }
            return b == num || num == 0;
        }

        static void Main(string[] args)
        {

            Console.Write("Digite um número: ");
            int numero = int.Parse(Console.ReadLine());

            if (seqFibonacci(numero))
            {
                Console.WriteLine($"O número {numero} pertence a sequência de Fibonacci.");
            } 
            else
            {
                Console.WriteLine($"O número {numero} não pertence a sequência de Fibonacci.");
            }
        }
    }
}
