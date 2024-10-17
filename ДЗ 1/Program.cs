﻿using System;

class Program
{
    static void Main()
    {
        // Заголовок таблицы
        Console.WriteLine("{0,-10} {1,-20} {2,30} {3,30}", "Type", "Byte(s) of memory", "Min", "Max");
        Console.WriteLine(new string('-', 100));

        // Вызов обобщенного метода для каждого типа
        PrintTypeInfo<sbyte>("sbyte");
        PrintTypeInfo<byte>("byte");
        PrintTypeInfo<short>("short");
        PrintTypeInfo<ushort>("ushort");
        PrintTypeInfo<int>("int");
        PrintTypeInfo<uint>("uint");
        PrintTypeInfo<long>("long");
        PrintTypeInfo<ulong>("ulong");
        PrintTypeInfo<float>("float");
        PrintTypeInfo<double>("double");
        PrintTypeInfo<decimal>("decimal");
    }

    // Обобщенный метод для вывода информации о типе
    static void PrintTypeInfo<T>(string typeName) where T : struct, IComparable
    {
        int size = System.Runtime.InteropServices.Marshal.SizeOf(typeof(T));
        var minValue = typeof(T).GetField("MinValue").GetValue(null);
        var maxValue = typeof(T).GetField("MaxValue").GetValue(null);

        // Форматированный вывод данных в таблицу
        Console.WriteLine("{0,-10} {1,-20} {2,30} {3,30}", typeName, size, minValue, maxValue);
    }
}
