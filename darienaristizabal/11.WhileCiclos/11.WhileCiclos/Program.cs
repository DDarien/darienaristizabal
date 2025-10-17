namespace _11.WhileCiclos
{
    internal class Program
    {
        //11. Realizar un algoritmo que pida números enteros positivos y los sume,
        //hasta que se ingrese un número entero negativo.
        static void Main(string[] args)
        {
            int numero;
            int suma = 0;
            int contador = 0;
            int acumulador = 0;

            do
            {
                Console.WriteLine("Ingrese un número entero positivo (o un número negativo para si quiere terminar): ");
                numero = int.Parse(Console.ReadLine());
                if (numero >= 0)
                {
                    suma += numero; 
                    contador++;
                    acumulador += numero;
                }
            } while (numero >= 0);
        }
    }
}