namespace _15.While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int mes = 1;
            double ahorroMensual, ahorroTotal = 0;
            while (mes <= 12)
            {
                Console.Write("Ingrese la cantidad de dinero que ahorró en el mes " + mes + ": ");
                ahorroMensual = Convert.ToDouble(Console.ReadLine());
                ahorroTotal += ahorroMensual;
                Console.WriteLine("El ahorro total hasta el mes " + mes + " es: " + ahorroTotal);
                mes++;
            }
            Console.WriteLine("El ahorro total en el año es: " + ahorroTotal);
            Console.ReadKey();
        }
    }
}