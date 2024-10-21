int simpleCount = 0;
int simpleNumber = 2;
int index = 2;
int number;
while (true)
{
    Console.Write("Укажите порядковый номер простого числа: ");
    var res = int.TryParse(Console.ReadLine(), out number);
    if (res)
    {
        while (simpleCount != number)
        {
            if (isSimple(index))
            {
                simpleCount++;
                simpleNumber = index;
            }
            index++;
        }
        break;
    }
}


Console.WriteLine($"{number} простое число - {simpleNumber}");


bool isSimple(int number)
{
    var res = true;
    for (int i = 2; i < number; i++)
    {
        if (number % i == 0) { res = false; break; }
    }
    return res;
}

