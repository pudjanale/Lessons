using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Выберите тему:");
            Console.WriteLine("1. Типы переменных");
            Console.WriteLine("2. Системы исчисления");
            Console.WriteLine("3. Бинарные операции");
            Console.WriteLine("4. Операции присваивания");
            Console.WriteLine("5. Выход");

            string input = Console.ReadLine();
            Console.Clear();

            switch (input)
            {
                case "1":
                    VariableTypes();
                    break;
                case "2":
                    NumberSystems();
                    break;
                case "3":
                    BinaryOperations();
                    break;
                case "4":
                    AssignmentOperations();
                    break;
                case "5":
                    return;
                default:
                    Console.WriteLine("Неверный ввод. Попробуйте еще раз.");
                    break;
            }
        }
    }

    static void VariableTypes()
    {
        Console.WriteLine("Основные типы переменных в C#:");
        Console.WriteLine("sbyte: 8-битное целое число со знаком (-128 to 127)");
        Console.WriteLine("short: 16-битное целое число со знаком (-32,768 to 32,767)");
        Console.WriteLine("ushort: 16-битное целое число без знака (0 to 65,535)");
        Console.WriteLine("int: 32-битное целое число со знаком (-2,147,483,648 to 2,147,483,647)");
        Console.WriteLine("uint: 32-битное целое число без знака (0 to 4,294,967,295)");
        Console.WriteLine("long: 64-битное целое число со знаком (-9,223,372,036,854,775,808 to 9,223,372,036,854,775,807)");
        Console.WriteLine("ulong: 64-битное целое число без знака (0 to 18,446,744,073,709,551,615)");
        Console.WriteLine("float: 32-битное число с плавающей точкой (примерно ±1.5 x 10^−45 to ±3.4 x 10^38)");
        Console.WriteLine("double: 64-битное число с плавающей точкой (примерно ±5.0 × 10^−324 to ±1.7 × 10^308)");
        Console.WriteLine("decimal: 128-битное десятичное число (примерно ±1.0 x 10^−28 to ±7.9 x 10^28)");
        Console.WriteLine("char: 16-битный символ Unicode (U+0000 to U+FFFF)");
        Console.WriteLine("string:  строка символов Unicode");
        Console.WriteLine("bool: логическое значение (true или false)");
        Console.WriteLine("object: базовый тип для всех типов данных. Может хранить значение любого типа.");
        Console.WriteLine();
    }

    static void NumberSystems()
    {
        Console.WriteLine("Системы исчисления:");
        Console.WriteLine("Десятичная: основание 10 (0-9)");
        Console.WriteLine("Двоичная: основание 2 (0-1)");
        Console.WriteLine("Восьмеричная: основание 8 (0-7)"); 
        Console.WriteLine("Шестнадцатеричная: основание 16 (0-9, A-F)");
        Console.WriteLine("Пример: число 10 в десятичной системе равно 1010 в двоичной, 12 в восьмеричной и A в шестнадцатеричной.");
        Console.WriteLine();
    }

    static void BinaryOperations()
    {
        Console.WriteLine("Бинарные операции:");
        Console.WriteLine("+: сложение");
        Console.WriteLine("-: вычитание");
        Console.WriteLine("*: умножение");
        Console.WriteLine("/: деление");
        Console.WriteLine("%: остаток от деления");
        Console.WriteLine("&: побитовое И(логическое умножение)");
        Console.WriteLine("|: побитовое ИЛИ(логическое сложение)");
        Console.WriteLine("^: побитовое исключающее ИЛИ");
        Console.WriteLine("<<: сдвиг влево");
        Console.WriteLine(">>: сдвиг вправо");
        Console.WriteLine();
    }


    static void AssignmentOperations()
    {
        Console.WriteLine("Операции присваивания:");
        Console.WriteLine("=: присвоение (x = 5)");
        Console.WriteLine("+=: сложение с присваиванием (x += 5, эквивалентно x = x + 5)");
        Console.WriteLine("-=: вычитание с присваиванием (x -= 5)");
        Console.WriteLine("*=: умножение с присваиванием (x *= 5)");
        Console.WriteLine("/=: деление с присваиванием (x /= 5)");
        Console.WriteLine("%=: остаток от деления с присваиванием (x %= 5)");
        Console.WriteLine("<<=: сдвиг влево с присваиванием (x <<= 5)");
        Console.WriteLine(">>=: сдвиг вправо с присваиванием (x >>= 5)");
        Console.WriteLine("&=: побитовое И с присваиванием (x &= 5)");
        Console.WriteLine("|=: побитовое ИЛИ с присваиванием (x |= 5)");
        Console.WriteLine("^=: побитовое исключающее ИЛИ с присваиванием (x ^= 5)");
        Console.WriteLine();


    }
}