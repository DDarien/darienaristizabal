namespace _1.InicialVisualStudio;

internal class Program
{
    static void Main(string[] args)
    {
        //esta es la declaracion e inicializacion de una variable
        string nombre = "Darien";
        const string iva = "19%";

        Console.WriteLine("hello, " + nombre + "\n");
        Console.WriteLine("\tBienvenido a la clase de programación");
        nombre = "Alejandro";
        Console.WriteLine("\n" + nombre);
        //iva="20%" no se puede cambiar el valor de una constante

        //tipos de datos
        byte dato1 = 255;
        int dato2 = 202321;
        long dato3 = 9202125235;
        double dato4 = 326.625;
        char dato5 = 'G';//Puede almacernar un solo caracter
        bool dato6 = false; //Almacena true o false
        object dato7 = new Program();
    }
        

}