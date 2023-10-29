using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // Tarea 1: Crear un array de enteros aleatorios
        int[] array = RandomArray();
        PrintArray(array);
        int minValue = array.Min();
        int maxValue = array.Max();
        int sum = array.Sum();
        Console.WriteLine($"Valor mínimo: {minValue}");
        Console.WriteLine($"Valor máximo: {maxValue}");
        Console.WriteLine($"Suma de valores: {sum}");

        // Tarea 2: Tirar una moneda
        string coinResult = TossCoin();
        Console.WriteLine($"Resultado del lanzamiento de la moneda: {coinResult}");

        // Opción adicional: Tirar múltiples monedas y calcular la relación de caras
        int numTosses = 10; // Cambia el número de lanzamientos según tus necesidades.
        double ratio = TossMultipleCoins(numTosses);
        Console.WriteLine($"Relación de lanzamientos de caras: {ratio:P}");

        // Tarea 3: Filtrar nombres y barajar la lista
        List<string> names = Nombres();
        Console.WriteLine("Nombres con más de 5 caracteres:");
        PrintList(names);
        List<string> shuffledNames = ShuffleList(names);
        Console.WriteLine("Nombres barajados:");
        PrintList(shuffledNames);
    }

    // Tarea 1: Crear una matriz de enteros aleatorios
    static int[] RandomArray()
    {
        int[] array = new int[10];
        Random random = new Random();

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(5, 26);
        }

        return array;
    }

    // Tarea 2: Tirar una moneda
    static string TossCoin()
    {
        Console.WriteLine("Tirando una moneda");
        Random random = new Random();
        int tossResult = random.Next(0, 2);
        string result = (tossResult == 0) ? "Cara" : "Cruz";
        return result;
    }

    // Opción adicional: Tirar múltiples monedas y calcular la relación de caras
    static double TossMultipleCoins(int num)
    {
        int headsCount = 0;

        for (int i = 0; i < num; i++)
        {
            if (TossCoin() == "Cara")
            {
                headsCount++;
            }
        }

        return (double)headsCount / num;
    }

    // Tarea 3: Filtrar nombres y barajar la lista
    static List<string> Nombres()
    {
        List<string> names = new List<string> { "Todd", "Tiffany", "Charlie", "Ginebra", "Sydney" };
        List<string> filteredNames = names.Where(name => name.Length > 5).ToList();
        return filteredNames;
    }

    static List<string> ShuffleList(List<string> list)
    {
        Random random = new Random();
        List<string> shuffledList = list.OrderBy(x => random.Next()).ToList();
        return shuffledList;
    }

    static void PrintList(List<string> list)
    {
        foreach (string item in list)
        {
            Console.WriteLine(item);
        }
    }

    static void PrintArray(int[] array)
    {
        Console.WriteLine("Valores de la matriz:");
        foreach (int value in array)
        {
            Console.Write(value + " ");
        }
        Console.WriteLine();
    }
}
