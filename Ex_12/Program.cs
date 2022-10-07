Console.Write("Введите первое число: ");
int first = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int second = Convert.ToInt32(Console.ReadLine());
int rem = first % second;
if (rem == 0) Console.WriteLine("Первое число кратно второму.");
else
{
    Console.WriteLine("Первое число не кратно второму.");
    Console.WriteLine("Остаток от деления равен "+ rem);
}