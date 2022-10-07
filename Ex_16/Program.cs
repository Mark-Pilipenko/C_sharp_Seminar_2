Console.Write("Введите первое число: ");
int first = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int second = Convert.ToInt32(Console.ReadLine());
if (first*first == second | second*second == first) Console.WriteLine("YES!");
else Console.WriteLine("NO");