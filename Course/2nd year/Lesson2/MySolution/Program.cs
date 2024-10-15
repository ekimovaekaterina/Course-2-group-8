//Task
//Практика A
Console.WriteLine("Практика A");
//№1
Console.WriteLine("Введите своё имя: ");
string UserName = Console.ReadLine();
Console.WriteLine("Привет, " + UserName);

//№2
Console.WriteLine("Введите год рождения: ");
int age = int.Parse(Console.ReadLine());
Console.WriteLine(2024 - age);

//Практика B
Console.WriteLine("Практика B");
//№3 не смогла решить

//№4
Console.WriteLine("Введите 1 число:");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2 число:");
int num2 = Convert.ToInt32(Console.ReadLine());
if (num1 > num2) {
    Console.WriteLine(num1 + ">" + num2);
}
else{
    Console.WriteLine(num2 + ">" + num1);
}

//Практика C
Console.WriteLine("Практика C");
//№5
Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Количество сотен: {number/100}");
Console.WriteLine($"Количество десятков: {number/10}");
Console.WriteLine($"Количество единиц: {number%10}");

//Homework
//№1
Console.WriteLine("Введите 1 число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2 число: ");
Console.WriteLine("Введите 1 число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Сумма чисел: {number1 + number2}");

//№2
int rannum = 168;
int usernum; // Объявляем переменную вне цикла

do
{
Console.WriteLine("Введите число:");
usernum = Convert.ToInt32(Console.ReadLine());
if (usernum > rannum)
{
Console.WriteLine("Меньше");
}
else if (usernum < rannum)
{
Console.WriteLine("Больше");
}
} while (usernum != rannum);