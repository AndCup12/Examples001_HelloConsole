int [] array = {1,2,1,5,88,62,52};


void printArray(int [] array){
   int count = array.Length;
   for (int i = 0; i < count; i++)
   {
        Console.Write($"{array[i]} ");
   }
   Console.WriteLine();
}


void sortArr (int [] array){
    
    for (int i = 0; i < array.Length - 1 ; i++){
        int maxPosition = i;
            for (int j = i + 1; j < array.Length; j++)
            {
                if(array[j] > array[maxPosition]) maxPosition = j;
            }
        int temporrary = array[i];
        array[i] = array[maxPosition];
        array[maxPosition] = temporrary;
    }
}
printArray(array);
sortArr(array);
printArray(array);
