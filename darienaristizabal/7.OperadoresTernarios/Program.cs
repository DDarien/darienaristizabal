namespace _7.OperadoresTernarios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Escribe un programa que verifique si una persona es mayor de edad usando el operador ternario.
            //Una persona mayor de edad tiene 18 años o más). 

            int edad = 0;
            Console.WriteLine("Ingrese su edad");
            edad = int.Parse(Console.ReadLine() ?? "0");

            Console.WriteLine(edad >= 18 ? "Es mayor de edad" : "No es mayor de edad");

            //Algoritmo que permita ingresar tres numero enteros diferentes y muestre por consola
            //el mayor de llos usando el operador ternario.

            int num1 = 0;
            int num2 = 0;
            int num3 = 0;
            int mayor = 0;

            Console.WriteLine("Ingrese le primer numero:");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese le segundo numero:");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese le tercer numero:");
            num3 = int.Parse(Console.ReadLine());

            mayor = num1 > num2

                ? (num1 > num3 ? num1 : num3) // si num1 es mayor que num2, entonces verificamos si num1 es myor que num3. parte verdadera con un ?
                : (num2 > num3 ? num2 : num3); // Si num1 no es mayor que num2, entonces verificamos si num2 es mayor que num3. parte falsa con :?
            Console.WriteLine($"El mayor de los tres numeros es: {mayor}");
        }
    }
}
