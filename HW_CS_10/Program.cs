/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. Через строку решать нельзя.
456 -> 5
782 -> 8
918 -> 1*/

int GetNumber()
{
    int number = 0;
    while (number < 99 || number > 999)
    {
        Console.WriteLine("Enter number");
        number = Convert.ToInt32(Console.ReadLine());

    }
    return number;
}

void CheckDozens(int number)
{
    int сurrent_number = number;

    while (сurrent_number >= 99)
    {
        сurrent_number = сurrent_number / 10;
    }

    int result = сurrent_number % 10;
    Console.WriteLine("The second digit of the entered number " + (result));
}

int number = GetNumber();
CheckDozens(number);
