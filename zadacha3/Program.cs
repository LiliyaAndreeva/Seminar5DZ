// //Задайте массив 
// вещественных чисел. Найдите
//  разницу между максимальным и минимальным 
// элементов массива.
// [3 7 22 2 78] -> 76

Console.Clear();
int [] array = GetDecArray(5, 0, 10);
Console.WriteLine($"[{String.Join(", ", array)}]"); 

int [] GetDecArray (int size, int minValue, int maxValue)
{
  int [] result = new int [size]; // создали массив на size элементов
  for (int i = 0; i < size; i++)
  {
    result [i] = new Random().Next(minValue, maxValue +1); 
  }
  return result;
}

int max = array [0];
int min = array [0];
int dif = 0;
int GetDifMaxMin (int [] array){
  for (int i = 0; i < array.Length; i++)
  {
    if (array[i]<min)
    {
      min=array[i];
    }
    else if (array[i]>max)
    {
      max = array[i];
    }
  }
int dif = max - min;

return dif;
}

Console.WriteLine($"[{String.Join(", ", GetDifMaxMin(array))}]"); 

// int GetFingDifference(GetFindMaxMin(,array)){
// {
// int dif = max-min;
// }
// return dif;
// }