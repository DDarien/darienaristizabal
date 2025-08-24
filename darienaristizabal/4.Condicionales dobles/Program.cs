namespace _4.Condicionales_dobles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Crea un algoritmo que lea la edad de un usuario, si el usuario es mayor de 18 se debe mostrar el siguiente mensaje:
             * "Bienvenido al sitio web"*/

            int edad = 0;
            Console.WriteLine("Ingrese su edad");

            edad = int.Parse(Console.ReadLine());

            if (edad >= 18)
            {
                Console.WriteLine("Bienvenido al sitio web");
            }
            else
            {
                Console.WriteLine("Acceso denegado, debes ser mayor de 18 para acceder al sitio web");
            }
        }
    }
}
