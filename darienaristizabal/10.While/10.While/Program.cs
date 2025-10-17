namespace _10.While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crear un algoritmo que permita calcular la factorial de un número dado por el usuario. (5! = 1*2*3*4*5) con contador y acumulador

            Console.WriteLine("Ingrese un número para calcular su factorial:");
            int numero = int.Parse(Console.ReadLine());
            int contador = 1;
            int factorial = 1;
            int acumulador = 1
                ;

            while (contador <= numero)
            {
                factorial *= contador; // factorial = factorial * contador
                contador++;
                acumulador += contador; // acumulador = acumulador + contador
            }
            Console.WriteLine($"El factorial de {numero} es: {factorial}");


        }
    }
}