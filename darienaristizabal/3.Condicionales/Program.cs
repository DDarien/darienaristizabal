namespace _3.Condicionales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CONDICIONAL SIMPLE
            string nombre = "";
            int sueldo = 0;

            Console.WriteLine("ingrese el nombre");
            nombre = Console.ReadLine();//TODO LO QUE YO LEO DESDE LA CONSOLA LLEGA COMO STRING
            Console.WriteLine(nombre);
            Console.WriteLine("Ingrese el sueldo");
            sueldo = Convert.ToInt32(Console.ReadLine());

           if(sueldo>3000)
            {
                Console.WriteLine($"La persona {nombre}, debe abonar impuestos");
            }

            /*Crea un algoritmo que lea la edad de un usuario, si el usuario es mayor de 18 se debe mostrar el siguiente mensaje:
            "Bienvenido al sitio web"*/

            int edad = 0;
            Console.WriteLine("Ingrese su edad");

            edad = int.Parse(Console.ReadLine());

            if (edad>18)
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
