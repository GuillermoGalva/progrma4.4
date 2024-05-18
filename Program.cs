using System;

class Program
{
    static void Main()
    {
        int contador = 0;
        int suma = 0;

        while (contador < 10)
        {
            Console.Write($"Ingresa el valor {contador + 1}: ");
            int valor = int.Parse(Console.ReadLine());

            suma += valor;
            contador++;
        }

        double promedio = (double)suma / contador;

        Console.WriteLine($"La suma de los valores ingresados es: {suma}");
        Console.WriteLine($"El promedio de los valores ingresados es: {promedio}");
    }
}
