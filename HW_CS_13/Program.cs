/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.Через строку решать нельзя.
645 -> 5
78 -> третьей цифры нет
32679 -> 6*/

int GetNumber() {
    Console.WriteLine("Enter your number: ");
    int num = int.Parse(Console.ReadLine()!);
    return num;
}

int countDigits(int numArg) {
    int count = 1;
    int temp = numArg;
    while(temp > 10) {
        temp /= 10;
        count++;
    }
    return count;
}

int thirdDigit(int num, int count) {
    if (count == 3) {
        num %= 100;
        num %= 10;
    }
    else {
        num %= Convert.ToInt32(Math.Pow(10, count - 1));
        num %= Convert.ToInt32(Math.Pow(10, count - 2));
        num /= Convert.ToInt32(Math.Pow(10, count - 3));
    }
    return num;
}

int num = GetNumber();
int count = countDigits(num);
if (count < 3) {
    Console.WriteLine("There is no third digit in your number.");
    }
else {
num = thirdDigit(num, count);
Console.WriteLine("Third digit is: " + num);
}