// See https://aka.ms/new-console-template for more information

int[,] RectangularArray = new int[4, 5];

int a = 0;

foreach (int item in RectangularArray)
{
    Console.Write(item + " ");
}
Console.WriteLine("\n");


for (int i = 0; i < RectangularArray.GetLength(0); i++)
{
    for (int j = 0; j < RectangularArray.GetLength(1); j++)
    {
        a += 5;
        RectangularArray[i, j] = a;
    }
}


//Printing the values of array by using nested for loop
//arr.GetLength(0): Returns the size of the Row
//arr.GetLength(1): Returns the size of the column
for (int i = 0; i < RectangularArray.GetLength(0); i++)
{
    for (int j = 0; j < RectangularArray.GetLength(1); j++)
    {
        Console.Write(RectangularArray[i, j] + " ");
    }
}

Console.ReadKey();



//Program to Add 2 Matrices using C#:


Console.WriteLine("Enter rows and column of Matrices: ");
int Rows = Convert.ToInt32(Console.ReadLine());
int Columns = Convert.ToInt32(Console.ReadLine());

//Create 3 2D Arrays with the above size
int[,] Matrix1 = new int[Rows, Columns];
int[,] Matrix2 = new int[Rows, Columns];
int[,] ResultMatrix = new int[Rows, Columns];

//Enter Matrix 1 Elements
Console.WriteLine("\nEnter Elements of 1st Matrix:");
CreateMatrix(Rows, Columns, Matrix1);



//Enter Matrix 2 Elements
Console.WriteLine("\nEnter Elements of 2nd Matrix:");
CreateMatrix(Rows, Columns, Matrix2);

//Adding Both Matrix Elements and Store the Result in ResultMatrix
Console.WriteLine("\nSum of Both the Matrics:");
for (int i = 0; i < Rows; i++)
{
    for (int j = 0; j < Columns; j++)
    {
        ResultMatrix[i, j] = Matrix1[i, j] + Matrix2[i, j];

        Console.Write($"{ResultMatrix[i, j]} ");
    }
    Console.WriteLine();
}


 static void CreateMatrix(int Rows, int Columns, int[,] Matrix)
{
    for (int i = 0; i < Rows; i++)
    {
        for (int j = 0; j < Columns; j++)
        {
            string number = Console.ReadLine() ?? "0";
            Matrix[i, j] = Convert.ToInt32(number);
        }
    }
}
Console.ReadKey();