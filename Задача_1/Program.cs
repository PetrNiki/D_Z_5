// Задача 34: Задайте массив заполненный случайными положительными 
//трёхзначными числами.
/*Напишите программу, которая покажет количество чётных чисел в массиве.*/

int[] array = GetArray(10, 100, 999);
int[] GetArray(int size, int min, int max)
{
  int[] result = new int[size];
  for (int i = 0; i < size; i++)
  {
    result[i] = new Random().Next(min, max + 1);
  }  
  return result;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
       Console.WriteLine(Convert.ToString(array[i]));
    }
}
int CountOfEven(int[] myArray)
{
    int count = 0;
    for(int i = 0; i < myArray.Length; i++)
    if(myArray[i]%2 == 0)
    {
        count++;
    }
    return count;
}
int[] myArray = new int[10];
myArray = GetArray(10, 100, 999);
ShowArray(myArray);
Console.WriteLine("количество четных чисел массива " + CountOfEven(myArray));

//Console.WriteLine("Hello, World!");
