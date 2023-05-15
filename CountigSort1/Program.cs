﻿int[] array = {0, 2, 3, 3, 1, 3, 4, 6, 7, 9, 3, 7, 2, 1, 5, 9, 1, 1};

 CountingSort(array);

 Console.WriteLine(string.Join(",", array));

void CountingSort(int[] inputArray)
{
   int[] counters = new int[10];

   for (int i = 0; i < inputArray.Length; i++)
   {
      counters[inputArray[i]]++;
   }

   int index = 0;
   for (int i = 0; i < counters.Length; i++)
   {
      for (int j = 0; j < counters[i]; j++)
      {
        inputArray[index] = i;
        index++;
      }
   }
}
