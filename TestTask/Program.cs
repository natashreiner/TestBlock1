//  Написать программу, которая из имеющегося массива 
// строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам.

string[] array = GetFirstArray(ReadInt("array length"));
Console.WriteLine("First Array: ");
PrintFirstArray(array);
string[] newArray = GetNewArray(array);
Console.WriteLine();
Console.WriteLine("New Array: ");
PrintNewArray(newArray);


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

string[] GetNewArray(string[] array)
{
	string[] newArray = new string[array.Length];

	for (int i = 0; i < array.Length; i++)
	if (array[i].Length <= 3)
	{
		newArray[i] = array[i];
	}
	return newArray;
}

void PrintNewArray(string[] newArray)
{
	for (int i = 0; i < array.Length; i++)
	{
		if (newArray[i] != null)
		{
		Console.Write($"{newArray[i]}, ");
		}
	}
}

