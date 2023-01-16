//  Написать программу, которая из имеющегося массива 
// строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам.

string[] array = GetFirstArray(ReadInt("array length"));
PrintFirstArray(array);

string[] GetFirstArray(int length)
{
	string[] array = new string[length];

	for (int i = 0; i < array.Length; i++)
	{
		Console.Write("Input element: ");
		array[i] = Console.ReadLine();
	}

	return array;
}

int ReadInt(string argumentName)
{
	Console.Write($"Input {argumentName}: ");
	return int.Parse(Console.ReadLine());
}

void PrintFirstArray(string[] array)
{
	for (int i = 0; i < array.Length; i++)
	{
		Console.Write($"{array[i]}, ");
	}
}





/*int[] GetArray(int length)
{
	int[] array = new int[length];

	for (int i = 0; i < array.Length; i++)
	{
		array[i] = ReadInt($"element {i}");
	}

	return array;
}*/

