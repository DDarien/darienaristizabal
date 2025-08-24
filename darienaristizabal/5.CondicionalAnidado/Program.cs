namespace _5.CondicionalAnidado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //condicional anidado Diseñar un algoritm que lea tres numeor A, B y C y se visualice el mayor de ellos. El usuario ingresara los numeros A, B y C por teclado.

            int numA = 0;
            int numB = 0;
            int numC = 0;

            Console.WriteLine("Ingrese el primer numero (A): ");
            numA = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el primer numero (B): ");
            numB = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el primer numero (C): ");
            numC = Convert.ToInt32(Console.ReadLine());
            // condicional anidado para determinar el mayor de los tres numeros


            if (numA > numB)
            {
                if (numA > numC)
                {
                    Console.WriteLine("El número mayor es {numA}");
                }
                else
                {
                    Console.WriteLine("El número mayor es {numC}");
                }
            }

            else 
            {
                if (numB > numC)
                {
                    Console.WriteLine("El número mayor es {numB}");
                }
                else
                { 
                    Console.WriteLine("El número mayor es {numC}");
                }
            }
        }
    }
}
