namespace TargetEx2
{
    internal class Program
    {
        static int ContadorA(string input)
        {
            int contador = 0;

            foreach (char a in input)
            {
                if (a == 'a' || a == 'A')
                {
                    contador++;
                }
            }
            return contador;
        }

        static void Main(string[] args)
        {
            Console.Write("Digite a string a ser analisada: ");
            string input = Console.ReadLine();

            int contador = ContadorA(input);
            Console.WriteLine($"Na string {input}, a letra A aparece {contador} vezes.");
        }
    }
}
