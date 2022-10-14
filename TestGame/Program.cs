Console.WriteLine("Мини игра - Угадай число.");
Console.WriteLine("Следует угадать число, заданное рандомным образом, за наименьшее количество попыток.");
Console.WriteLine("Итак, начнем! Введите число:");
int numberA = new Random().Next(0,999);
Console.WriteLine(numberA);
int count = 0;
int result = 0;
string userString = Console.ReadLine();
int numberB = Convert.ToInt32(userString);
while(exit<1)
{
    if( result == number)
    {
        Console.WriteLine("Ура! Вы угадали число!");
        count++;
        exit++;
    }
    else
    {
        if( result > number)
        {
            Console.WriteLine("Твое число меньше загаданного, попробуй еще раз.");
            userString = Console.ReadLine();
            number = Convert.ToInt32(userString);
            count++;
         }
        else
        {
            Console.WriteLine("Твое число больше загаданного, попробуй еще раз.");
            userString = Console.ReadLine();
            number = Convert.ToInt32(userString);
            count++;
        }
    }
}
Console.Write ("Количество попыток =");
Console.WriteLine(count);