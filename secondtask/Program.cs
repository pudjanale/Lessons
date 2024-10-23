using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Выберите сложность:");
            Console.WriteLine("1. Единицы");
            Console.WriteLine("2. Десятки");
            Console.WriteLine("3. Сотни");
            Console.WriteLine("4. Выход");

            string input = Console.ReadLine();
            Console.Clear();

            switch (input)
            {
                case "1":
                    Game(1, 10); 
                    break;

                case "2":
                    Game(10, 100); 
                    break;

                case "3":
                    Game(100, 1000);
                    break;

                case "4":
                    return;

                default:
                    Console.WriteLine("Неверный ввод. Попробуйте ещё раз");
                    break;
            }
        }
    }

    public static int RandomNumber(int min, int max)
    {
        Random rand = new Random();
        return rand.Next(min, max);
    }

    static void Game(int min, int max)
    {
        int randomNumber = RandomNumber(min, max);
        int attempts = 3;

        Console.WriteLine($"Угадайте число от {min} до {max - 1}:");

        while (attempts > 0)
        {
            int guess;
            while (!int.TryParse(Console.ReadLine(), out guess))
            {
                Console.WriteLine("Неверный ввод. Введите число.");
            }

            if (guess == randomNumber)
            {
                Console.WriteLine("Поздравляю! Вы угадали!");
                return;
            }
            else
            {
                attempts--;
                Console.WriteLine($"Неверно! Осталось попыток: {attempts}");

                if (attempts > 0) 
                {
                    Console.WriteLine(guess < randomNumber ? "Загаданное число больше." : "Загаданное число меньше.");
                }
            }
        }

        Console.WriteLine($"Вы не угадали. Загаданное число: {randomNumber}");
    }
}