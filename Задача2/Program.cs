/*Задайте одномерный массив, заполненный случайными числами.
 Найдите сумму элементов, стоящих на нечётных позициях.*/
Console.Write("Введи количество элементов массива: ");
int numElements = Convert.ToInt32(Console.ReadLine()); 

int RandomNum(int numElements, int min, int max)
  {
  int[] randomNum = new int[numElements];
  int sumElements = 0;
  Console.Write("Получившийся массив: ");

    for (int i = 0; i <randomNum.Length; i++ )
    {
      randomNum[i] = new Random().Next(min, max);

      Console.Write(randomNum[i] + " ");

      if (i % 2 != 0)
      {
        sumElements = sumElements + randomNum[i];
      }
    }
  return sumElements;
  }

int randomNum =  RandomNum(numElements, -5, 5);

Console.WriteLine("\nСумма элементов, стоящих на нечётных позициях:" + randomNum);
