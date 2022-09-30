/*Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2

int [] GenerateArray (int length){
    int [] array = new int [length];

    for (var i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100,999);
    }
    return array;
 }
 
 void PrintArray(int[] array) {
    for (var i = 0; i < array.Length -1; i++)
    {
        System.Console.Write(array[i] + ", ");
    }
    System.Console.WriteLine(array[array.Length - 1]);
 }

 int EvenNum(int[] array){
    int N = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i]%2==0)
        N++;
    }
    return N;
 }

 int[] array = GenerateArray(10);
 PrintArray(array);
 System.Console.WriteLine( EvenNum(array));*/


 /*Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов,
  стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0

int [] GenerateArray (int length){
    int [] array = new int [length];

    for (var i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1,100);
    }
    return array;
 }
 
 void PrintArray(int[] array) {
    for (var i = 0; i < array.Length -1; i++)
    {
        System.Console.Write(array[i] + ", ");
    }
    System.Console.WriteLine(array[array.Length - 1]);
 }
 int SumOddNumbers(int [] array){
    int sum = 0;
    for (int i = 1; i < array.Length; i+=2)
    {
        sum = sum + array[i];
    }
    return sum;
 }
 int[] array = GenerateArray(10);
 PrintArray(array);
 System.Console.WriteLine( SumOddNumbers(array));*/


/*Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным 
элементов массива.
[3 7 22 2 78] -> 76*/

double [] GenerateArray (int length){
    double [] array = new double [length];

    for (var i = 0; i < array.Length; i++)
    {
        array[i] = new Random().NextDouble();
    }
    return array;
 }
 void PrintArray(double[] array) {
    for (var i = 0; i < array.Length -1; i++)
    {
        System.Console.Write(array[i] + ", ");
    }
    System.Console.WriteLine(array[array.Length - 1]);
 }

 double MinMaxDif(double[] array){
   double max = array[0];
   double min = array[0]; 
   for (int i = 0; i < array.Length; i++)
   {
    if(array[i]>max){
        max = array[i];
    }
    if (array[i]<min){
        min = array[i];
    }
   }
   System.Console.WriteLine($"Максимальное значение: {max}");
   System.Console.WriteLine($"Минимальное значение: {min}");
   return  max-min;
 }
 double[] array = GenerateArray(10);
 PrintArray(array);
 System.Console.WriteLine( MinMaxDif(array));




