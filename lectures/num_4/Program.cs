void FillArray(int[] collection){
    int length = collection.Length;
    int index = 0;
    while(index < length){
        collection[index] = new Random().Next(1, 15);

        index++;
    }
}

void PrintArray(int[] col){
    int count = col.Length;
    int position = 0;
    while(position < count){
        Console.WriteLine(col[position]);
        
        position++;
    }
}

int IndexOf(int[] collection, int find){

int count = collection.Length;
int index = 0;
int position = -1;

while(index < count){
    if(collection[index] == find){
        position = index;
        break;
    }
    index++;
}
return position;
}

// определили массив из 10 элементов
int [] array = new int[10];
// Заполнили массив array случайными числами
FillArray(array);
// Распечатали заполненный массив array
PrintArray(array);

Console.WriteLine();
int pos = IndexOf(array, 1);
Console.WriteLine(pos);
