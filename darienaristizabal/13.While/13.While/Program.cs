namespace _13.While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un número entero positivo:");
            int n = int.Parse(Console.ReadLine());
            int contador = 0;

            int i = 1;
            while (i <= n)
            {
                if (i % 2 == 0)
                {
                    contador++;
                }
                i++;
            }
            Console.WriteLine($"Hay {contador} números pares entre 1 y {n}.");
            Console.ReadKey();
        }
    }
}