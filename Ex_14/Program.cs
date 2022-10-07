Console.Write("Введите число: ");
int noun = Convert.ToInt32(Console.ReadLine());
if (noun % 7 == 0 && noun % 23 == 0) Console.WriteLine("Число кратно 7 и 23.");
else Console.WriteLine("Число не кратно 7 и 23.");