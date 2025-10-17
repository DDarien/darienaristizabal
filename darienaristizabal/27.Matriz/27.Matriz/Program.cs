namespace _27.Matriz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el número de filas de la matriz:");
            int filas = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el número de columnas de la matriz:");
            int columnas = int.Parse(Console.ReadLine());
            int[,] matriz = new int[filas, columnas];
            int positivos = 0, negativos = 0, ceros = 0;
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.WriteLine($"Ingrese el número para la posición [{i},{j}]:");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                    if (matriz[i, j] > 0)
                    {
                        positivos++;
                    }
                    else if (matriz[i, j] < 0)
                    {
                        negativos++;
                    }
                    else
                    {
                        ceros++;
                    }
                }
            }
            Console.WriteLine($"Total de números positivos: {positivos}");
            Console.WriteLine($"Total de números negativos: {negativos}");
            Console.WriteLine($"Total de ceros: {ceros}");
            Console.ReadKey();
        }
    }
}