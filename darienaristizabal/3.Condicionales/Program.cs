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
        }
    }
}
