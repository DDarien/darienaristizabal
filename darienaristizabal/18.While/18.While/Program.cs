namespace _18.While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nombre, numeroCuenta;
            double saldo, sumaSaldos = 0;
            int contadorUsuarios = 0;
            string respuesta;
            do
            {
                Console.Write("Ingrese el nombre del usuario: ");
                nombre = Console.ReadLine();
                Console.Write("Ingrese el número de cuenta: ");
                numeroCuenta = Console.ReadLine();
                Console.Write("Ingrese el saldo: ");
                saldo = Convert.ToDouble(Console.ReadLine());
                sumaSaldos += saldo;
                contadorUsuarios++;
                if (saldo > 3000000)
                {
                    Console.WriteLine($"{nombre}, {numeroCuenta}, {saldo:C}, Es apto para el crédito");
                }
                else
                {
                    Console.WriteLine($"{nombre}, {numeroCuenta}, {saldo:C}, No es apto para el crédito");
                }
                Console.Write("¿Desea ingresar otro usuario? (s/n): ");
                respuesta = Console.ReadLine().ToLower();
            } while (respuesta == "s");
            if (contadorUsuarios > 0)
            {
                double promedioSaldos = sumaSaldos / contadorUsuarios;
                Console.WriteLine($"Número de usuarios: {contadorUsuarios}");
                Console.WriteLine($"Promedio de saldos: {promedioSaldos:C}");
            }
            else
            {
                Console.WriteLine("No se ingresaron usuarios.");
            }
        }
    }
}