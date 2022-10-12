// Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]


Console.Clear();

int[] array = new int[8];

int[] fillArray(int[] arr)
{
	for (int i = 0; i<arr.Length; i++)
	{
		arr[i]=new Random().Next(0,2);
	}
	return arr;
}
int[] writeArray (int[] arr)
{
	for(int i=0; i<arr.Length; i++)
	{
		Console.Write($"{arr[i]}");
	}
	return arr;
}
fillArray(array);
writeArray(array);