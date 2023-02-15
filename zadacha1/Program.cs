// адайте массив заполненный 
// случайными положительными трёхзначными числами. Н
// апишите программу, которая покажет 
// количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

Console.Clear();
Console.WriteLine("Введите длину массива ");
int size = int.Parse(Console.ReadLine());
int [] array = GetDecArray(size, 100, 999);
Console.WriteLine($"[{String.Join(", ", array)}]"); 
Console.WriteLine(String.Join(" -> ", GetPositiveElement(array)));

int [] GetDecArray (int size, int minValue, int maxValue)
{
  int [] result = new int [size]; // создали массив на size элементов
  for (int i = 0; i < size; i++)
  {
    result [i] = new Random().Next(minValue, maxValue +1); // на каждый элемент массива кладем рандомное число2 значит будет 0 и 1
  }
  return result;
}

int GetPositiveElement(int [] array){
  int count = 0;
  for (int i = 0; i < array.Length; i++)
  {
    if (array [i]%2==0 )
    count++;
  }
  return count;
}