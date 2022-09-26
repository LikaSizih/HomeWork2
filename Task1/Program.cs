void Task1()
{
    Console.WriteLine("Введите трехзначное число: ");
    int a = int.Parse(Console.ReadLine());
    int result = ((a / 10) % 10);
    Console.WriteLine(result);
}

Task1();