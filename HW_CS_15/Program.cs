int GetNumber() {
    Console.WriteLine("Введите число: ");
    int num = int.Parse(Console.ReadLine()!);
    return num;
}

void checkWeekend(int numArg) {
    if(numArg == 6 || numArg ==7) {
        Console.WriteLine("Выходной");
    }
    else {
        Console.WriteLine("Не выходной");
    }
}

int num = GetNumber();

if(num > 0 && num < 8){
    checkWeekend(num);
}
else {
    Console.WriteLine("Неверное число недели");
}
