namespace _14.While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cantidadNumeros, numero;
            int contadorPositivos = 0;
            int contadorNegativos = 0;
            int contadorCeros = 0;

            Console.Write("Ingrese la cantidad de números que va a introducir: ");
            cantidadNumeros = int.Parse(Console.ReadLine());
            int i = 0;
            while (i < cantidadNumeros)
            {
                Console.Write("Ingrese un número entero: ");
                numero = int.Parse(Console.ReadLine());
                if (numero > 0)
                {
                    contadorPositivos++;
                }
                else if (numero < 0)
                {
                    contadorNegativos++;
                }
                else
                {
                    contadorCeros++;
                }
                i++;
            }
            Console.WriteLine($"Cantidad de números mayores que 0: {contadorPositivos}");
            Console.WriteLine($"Cantidad de números menores que 0: {contadorNegativos}");
            Console.WriteLine($"Cantidad de números iguales a 0: {contadorCeros}");
        }
    }
}