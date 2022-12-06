Console.WriteLine("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 7)
    Console.WriteLine("Нет такого дня недели");
else

{
    if (number == 7 || number == 6)
        Console.WriteLine("Да");
    else
        Console.WriteLine("Нет");
}