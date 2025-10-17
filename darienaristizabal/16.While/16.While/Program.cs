namespace _16.While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int numeroAleatorio = random.Next(1, 101);
            int intentos = 0;
            int numeroUsuario = 0;

            while (numeroUsuario != numeroAleatorio)
            {
                Console.WriteLine("Adivina el número entre 1 y 100:");
                string? input = Console.ReadLine();
                if (int.TryParse(input, out numeroUsuario))
                {
                    intentos++;
                    if (numeroUsuario < numeroAleatorio)
                    {
                        Console.WriteLine("Demasiado bajo. Intenta de nuevo.");
                    }
                    else if (numeroUsuario > numeroAleatorio)
                    {
                        Console.WriteLine("Demasiado alto. Intenta de nuevo.");
                    }
                    else
                    {
                        Console.WriteLine($"¡Correcto! Has adivinado el número {numeroAleatorio} en {intentos} intentos.");
                    }
                }
                else
                {
                    Console.WriteLine("Por favor, introduce un número válido.");
                }
            }
        }
    }
}