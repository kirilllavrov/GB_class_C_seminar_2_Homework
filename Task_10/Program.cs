Console.WriteLine("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());


int a = number / 10 % 10;


if (number < 100 || number > 999)
    Console.WriteLine("Было введено не трехзначное число!");
else
    Console.WriteLine("Второе число = " + a);