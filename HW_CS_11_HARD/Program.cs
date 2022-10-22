/*Задача 11 HARD - необязательная: Напишите программу, которая принимает на вход целое число любой разрядности число и удаляет вторую цифру слева направо этого
числа. И, конечно же, через строку решать нельзя.*/


int GetNumber() {
    Console.WriteLine("Enter your number: ");
    int num = int.Parse(Console.ReadLine()!);
    return num;
}

int countDigits(int numArg) {
    int temp = numArg;
    int count = 1;
    while(temp > 10) {
        temp /= 10;
        count++;
    }
    return count;
}

int deleteSecondDigit(int num, int count) {
    int temp = 0;
    if (count > 2) {
        temp = num;
        temp %= Convert.ToInt32(Math.Pow(10, count - 1));
        temp %= Convert.ToInt32(Math.Pow(10, count - 2));
    }
    num /= Convert.ToInt32(Math.Pow(10, count - 1));
    num = num * Convert.ToInt32(Math.Pow(10, count - 2)) + temp;
    return num;
}

int num = GetNumber();
int count = countDigits(num);
if (count < 2) {
    Console.WriteLine("There is no second digit in your number.");
}
else {
    num = deleteSecondDigit(num, count);
    Console.WriteLine("New number: " + num);
}
