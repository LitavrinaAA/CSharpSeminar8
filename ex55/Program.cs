// Задача 55: Задайте двумерный массив. Напишите программу,
//которая заменяет строки на столбцы. В случае, если это
//невозможно, программа должна вывести сообщение для
//пользователя.


int InputNum(string mess){
    System.Console.WriteLine(mess);
    return int.Parse(Console.ReadLine()!);
}


void FillArr(int[,] arr , int m, int n){
    Random rnd = new Random();
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            arr[i,j] = rnd.Next(10);
        }
    }
}

void PrintArray(int[,] arr){
    int length1 = arr.GetLength(0);
    int length2 = arr.GetLength(1);
    for (int i = 0; i < length1; i++)
    {
        for (int j = 0; j < length2; j++)
        {
            System.Console.Write($"{arr[i,j]}\t");
        }
        System.Console.WriteLine();
    }

}
int[,] ArrChange(int[,] arr){
    
    int lengthCol= arr.GetLength(0);
    int lengthRow = arr.GetLength(1);
    int [,] arrChangeTemp = new int[lengthRow, lengthCol];
    
    for (int i = 0; i < lengthRow; i++)
    {
       for (int j = 0; j < lengthCol; j++)
       {
        arrChangeTemp[i, j] = arr[j, i];
       } 
       
    }
return arrChangeTemp;
}



int m = InputNum("Введите m: ");
int n = InputNum("Введите n: ");;
if (n==m) {
int[,] arr = new int[m,n];
FillArr(arr, m, n);
PrintArray(arr);

int[,] arrChange = ArrChange(arr);

System.Console.WriteLine();
PrintArray(arrChange);
} else {
    System.Console.WriteLine("Стороны не совпадают");
}
