Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 100)
{
    while (number > 1000)
        number = number / 10;

    int a = number % 10;
    Console.WriteLine(a);
}
else
{
    Console.WriteLine("Третьей цифры нет. Переход хода. Крутите барабан...");
}