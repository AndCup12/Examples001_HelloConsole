Console.WriteLine("Введите X");
int X = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Y");
int Y = Convert.ToInt32(Console.ReadLine());

string Quarter (int X, int Y) {
    if (X > 0 && Y > 0) return "Первая четверть";
    if (X < 0 && Y > 0) return "Вторая четверть";
    if (X < 0 && Y < 0) return "Третья четверть";
    if (X > 0 && Y < 0) return "Четвертая четверть";
    return "Ввели неверные значения";
}

string result = Quarter(X, Y);
Console.WriteLine(result);
 

