namespace _12.WhileCiclos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int contador = 1;
            int acumulador = 0;
            while (contador < 100)
            {
                acumulador += contador;
                contador += 2;
            }

            Console.WriteLine("La suma de todos los números impares hasta el 99 da: " + acumulador);
        }
    }
}