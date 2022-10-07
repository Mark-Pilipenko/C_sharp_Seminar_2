int noun = new Random().Next(100, 1000);
Console.WriteLine("Случайное трехзначное число: " + noun);
int first = noun / 100;
int third = noun % 10;
int newNoun = first*10 + third;
Console.WriteLine("Новое двухзначное число: " + newNoun);