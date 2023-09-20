Console.Write("Введите 1 число: ");
int number1 = int.Parse(Console.ReadLine());
Console.Write("Введите 2 число: ");
int number2 = int.Parse(Console.ReadLine());
if (number1 > number2)
{
    Console.WriteLine("Число " + number1 + " большее");
    Console.Write("Число " + number2 + " меньшее");
}
else if (number1 == number2)
{
    Console.WriteLine("Число " + number1 + " равно числу " + number2);
}
else
{
    Console.WriteLine("Число " + number2 + " большее");
    Console.Write("Число " + number1 + " меньшее");
}
