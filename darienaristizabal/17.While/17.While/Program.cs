namespace _17.While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero, contador, resultado;
            string respuesta;

            do
            {
                Console.Write("Ingrese un número para generar su tabla de multiplicar: ");
                numero = int.Parse(Console.ReadLine());
                contador = 1;
                Console.WriteLine($"Tabla de multiplicar del {numero}:");
                while (contador <= 10)
                {
                    resultado = numero * contador;
                    Console.WriteLine($"{numero} x {contador} = {resultado}");
                    contador++;
                }
                Console.Write("¿Desea generar otra tabla de multiplicar? (s/n): ");
                respuesta = Console.ReadLine().ToLower();
            } while (respuesta == "s");
            Console.WriteLine("¡Gracias por usar el generador de tablas de multiplicar!");

        }
    }
}