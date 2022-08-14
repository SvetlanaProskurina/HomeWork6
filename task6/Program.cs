void printArrayRazm(int[,] array)
{
    for (int i=0; i<array.GetLength(0);i++)
    {
         for (int j=0; j<array.GetLength(1);j++)
        {
            Console.Write($"{array[i,j]} ");
           
        }
        Console.WriteLine();
    }
}

Console.WriteLine("введите размерность двумерного массива, 2 числа через запятую");
string test=Console.ReadLine();
string[] array =test.Split(',');
int stringSize=Convert.ToInt32(array[0]);
int columnSize=Convert.ToInt32(array[1]);
int [,] arrayInput = new int [stringSize, columnSize];
void fillArray(int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }

}
Console.WriteLine("");
fillArray(arrayInput);
printArrayRazm(arrayInput);
/*Программа должна вывести матрицу того же размера, 
у которой каждый элемент в позиции i, j равен сумме элементов
 первой матрицы на позициях (i-1, j), (i+1, j), (i, j-1), (i, j+1). 
 У крайних символов соседний элемент находится с противоположной стороны матрицы.
В случае одной строки/столбца элемент сам себе является соседом по соответствующему направлению.*/
int [,] arrayOutput = new int [stringSize,columnSize];

 
    int a,b,c,d;
    for (int i = 0; i < arrayInput.GetLength(0); i++)
    {
        for (int j = 0; j < arrayInput.GetLength(1); j++)
        {
            
            if (i==0) {a=arrayInput[stringSize-1,j];}
            else a=arrayInput[i-1, j];
            if (j==0) {c=arrayInput[i,columnSize-1];}
            else c=arrayInput[i, j-1];
            if (i==stringSize-1) {b=arrayInput[0,j];}
            else b=arrayInput[i+1, j];
            if (j==columnSize-1) {d=arrayInput[i,0];}
            else d=arrayInput[i, j+1];
            arrayOutput[i, j] = a+b+c+d;
        }
    }

Console.WriteLine("");
printArrayRazm(arrayOutput);