// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (X и Y).
Console.WriteLine("Введите номер четверти");
int quarter = Convert.ToInt32(Console.ReadLine());

string Range(int q){
    switch(q){
        case 1: 
            return "Диапазон возможных координат X > 0 и Y > 0";
            break;
        case 2:
            return "Диапазон возможных координат X < 0 и Y > 0";
            break;
        case 3:
            return "Диапазон возможных координат X < 0 и Y < 0";
            break;
        case 4:
            return "Диапазон возможных координат X > 0 и Y < 0";
            break;
        default:
        return "Введена некорректная четверь";
        break;
    }
}
string result = Range(quarter);
Console.WriteLine(result);

