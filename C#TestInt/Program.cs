// See https://aka.ms/new-console-template for more information

int[] numbers =  {3,4,5,6,22,55,77,23,99,2,77,12,32,65,115}; 

Array.Sort(numbers);

foreach (var number in numbers)
{
    Console.Write(number+", ");
}
Console.WriteLine();



int[] numbersofArr = { 23,5, 4, 43, 4, 5, 6, 22, 55, 77, 23, 99, 2, 77, 12, 32, 65, 115,15,20, 10,37 };


Array.Reverse(numbersofArr);

foreach (var item in numbersofArr)
{

    Console.Write(item + ", ");
}
Console.WriteLine("\n");


int[] numbersofArray = { 99, 2, 77, 12, 32, 65, 115, 15, 20, 10, 37 };
int[] newArray = new int[11];
Array.Copy(numbersofArray, newArray, 9);

foreach (var item in newArray)
{

    Console.Write(item + ", ");
}
Console.WriteLine($"\nGet length of the New Array using Length property: {newArray.Length}");
Console.WriteLine($"\nGet length of the New Array using GetLength property: {newArray.GetLength(0)}");
Console.WriteLine();

//2 Dimensional Array
int[,] twoDimArrayNumbers = new int[2, 3] { {2,3,4}, {5,6,5} };

Console.WriteLine(twoDimArrayNumbers[0,1]);
Console.ReadKey();