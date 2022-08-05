// Задайте массив вещественных чисел. Найдите разницу между 
//максимальным и минимальным элементами массива. 

double[] arrayNumbers = new double[10];
for (int i = 0; i < arrayNumbers.Length; i++)
{
    arrayNumbers[i] = new Random().Next(1, 10);
    Console.Write(arrayNumbers[i] + " ");
}

double maxNumber = arrayNumbers[0];
double minNumber = arrayNumbers[0];

for (int i = 0; i < arrayNumbers.Length; i++)
{ 
   if(maxNumber < arrayNumbers[i])
   {
    maxNumber = arrayNumbers[i];
   }
   else if(minNumber > arrayNumbers[i])
   {
    minNumber = arrayNumbers[i];
   }
}

double solution = maxNumber - minNumber;
Console.WriteLine($"\nразница между макс {maxNumber} и мин {minNumber} элементами: {solution}");
