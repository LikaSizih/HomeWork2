void Task2()
{
    Console.WriteLine("Введите число: ");
    int a = int.Parse(Console.ReadLine());
    if (a < 99)
        {
            Console.WriteLine("Третьей цифры нет");
        }
    else
        {
            while (a > 999)
            {
                a/=10;
            }
            Console.WriteLine(a%10);
        }
}
Task2();