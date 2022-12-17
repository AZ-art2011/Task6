// Задача проверки четностт числа

Console.WriteLine("Пожалуйста, введите число");
int digit = Convert.ToInt32(Console.ReadLine());

if (digit % 2 == 0){
    Console.WriteLine($"Число {digit} - четное");
}
else {
    Console.WriteLine($"Число {digit} - не четное");
}


