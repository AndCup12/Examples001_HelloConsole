// Имеется одномерный массив array из n элементов, требуется найти элемент массива, равный find

// 1. Установить счетчик index в позицию 0.
// 2. Если array[index] = find, алгоритм завершил работу успешно.
// 3. Увеличить index на 1.
// 4. Если index < n, то перейти к шагу 2. В противном случае алгоритим завершил работу безуспешно.

int [] array = {1,2,3,5,74,6,8,1};

int n = array.Length;

int find = Convert.ToInt32(Console.ReadLine());
int index = 0;

while(index < n){
    if(array[index]== find){
        Console.WriteLine("Индекс: "+ index +"."+ " Число: " + array[index]);
        break;
    }else{
        
    }
    index++;
}