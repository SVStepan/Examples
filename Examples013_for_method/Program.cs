// Упорядочить массив по возрастанию, а затем по убыванию.

int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 1, 2, 3, 1, 9, 10, 12 };

//надо вывести массив на экран 
void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition]) minPosition = j;
        }

        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}

 void SelectionSortmax(int[] array)
 {
     for (int i = 0; i < array.Length - 1; i++)
     {
         int maxPosition = i;
         for (int m = i + 1; m < array.Length; m++)
         {
             if (array[m] > array[maxPosition]) maxPosition = m;
         }

         int temporaryMax = array[i];
         array[i] = array[maxPosition];
         array[maxPosition] = temporaryMax;
     }
 }


PrintArray(arr);

SelectionSort(arr);

PrintArray(arr);

SelectionSortmax(arr);

PrintArray(arr);