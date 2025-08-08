using System;

namespace _2_Operadores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //OPERADORES

            //Operadores Numéricos
            //Cambio de Signo
            int num1 = 5;
            int num2 = -num1;
            int num3 = +num1;
            int num4 = -num2;

            Console.WriteLine($"{num1} // {num2} // {num3} // {num4}");

            //Operadores aritméticos
            int num5 = 3 + 5; //suma
            int num6 = 100 - 34; // resta
            int num7 = 3 * 5; //Multiplicación
            int num8 = (int)(float)5 / 3; //División
            float num9 = 5f / 3;
            double num10 = 5d / 3;
            decimal num10b = 5m / 3m;

            Console.WriteLine($"suma: {num5}, resta: {num6}, producto: {num7}, division: {num8} // {num9} // {num10b}");

            //Operadores incremento(++), decremento(--)
            num1++; //num1 = num1 + 1; Incremento
            num2--; //num2 = num2 - 1; Decremento
            num3 += 2; //num3 = num3 + 2;
            num4 -= 3; //num4 = num4 - 3;
            num5 *= 3; //num5 = num5 * 3;
            num6 /= 7; //num6 = num6 / 7;
            num7 %= num1; //num7 = num7 % num1;

            //Orden de Evaluación operadores
            int num11 = 3 + 3 * 2;
            int num12 = (3 + 3) * 2;
            int num13 = 3 + 3 / 2;
            int num14 = (3 + 3) / 2;
            int num15 = 3 + (3 / 2);
            int num16 = (3 + 3) / (2 + 1);

            Console.WriteLine($"{num11}, {num12}, {num13}, {num14}, {num15}, {num16}");

            //Conjunción
            Console.WriteLine("TABLA DE VERDAD CONJUNCIÓN");
            Console.WriteLine($"{false} && {false} = {false && false}");
            Console.WriteLine($"{true} && {false} = {true && false}");
            Console.WriteLine($"{false} && {true} = {false && true}");
            Console.WriteLine($"{true} && {true} = {true && true}");

            //Disyunción
            Console.WriteLine("TABLA DE VERDAD DISYUNCIÓN");
            Console.WriteLine($"{false} || {false} = {false || false}");
            Console.WriteLine($"{true} || {false} = {true || false}");
            Console.WriteLine($"{false} || {true} = {false || true}");
            Console.WriteLine($"{true} || {true} = {true || true}");

            bool exp1 = true && true;
            bool exp2 = false || false;
            bool exp3 = true && false;
            bool exp4 = false || true;
            bool exp5 = exp1 || exp2;

            Console.WriteLine($"exp1: {exp1}, exp2: {exp2}, exp3: {exp3}, exp4: {exp4}, exp5: {exp5}");
        }
    }
}

