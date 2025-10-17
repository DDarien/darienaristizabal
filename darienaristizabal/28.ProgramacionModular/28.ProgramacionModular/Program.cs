namespace _28.ProgramacionModular
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MostrarMensaje("Soy Darien");
            MostrarMensaje("Tengo 22 años");
            MostrarMensaje("Adiós Mundo");
        }

        static void MostrarMensaje(string mensaje)
        {
            Console.WriteLine("Bienvenido a la programación modular");
            MostrarMensaje("Estoy siendo llamado desde MostrarMensaje");
        }

        static int CalcularEdad() 
        {
            int Edad = 2025 - 1981;
            return Edad;
        }

        static int calcularEdad2(int añoActual, int añoNacimiento) 

        {
            return añoActual - añoNacimiento;
        }
    }
}