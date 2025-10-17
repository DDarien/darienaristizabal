namespace _24.Ciclos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[10];
            int suma = 0;
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.Write($"Ingrese el numero {i + 1}: ");
                numeros[i] = int.Parse(Console.ReadLine());
                suma += numeros[i];
            }
            double promedio = (double)suma / numeros.Length;
            Console.WriteLine($"El promedio de los numeros ingresados es: {promedio}");
            Console.ReadKey();
        }
    }
}