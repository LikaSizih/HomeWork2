void Task3()
{
    Console.WriteLine("Введите цифру, обозначающую день недели: от 1 до 7: ");
    int a = int.Parse(Console.ReadLine());
    if (a < 6)
        {
            Console.WriteLine("Это будний день");
        }
    else
    {
        Console.WriteLine("Выходной день ");
    }
}
Task3();
