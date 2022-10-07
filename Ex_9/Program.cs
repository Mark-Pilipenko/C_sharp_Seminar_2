int noun = new Random().Next(10, 100);
Console.WriteLine("Случайное число от 10 до 99: " + noun);
int first = noun / 10;
int second = noun % 10;
Console.Write("Наибольшая цифра: ");
if (first > second) Console.WriteLine(first);
else Console.WriteLine(second);