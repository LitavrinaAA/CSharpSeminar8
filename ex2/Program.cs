// Задача 47. Задайте двумерный массив размером m×n, заполненный
//случайными вещественными числа
//Задача 53: Задайте двумерный массив. Напишите программу,
//которая поменяет местами первую и последнюю строку
//массива.
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
void PrintArray2(int[] arr){
    int length = arr.Length;
    
    for (int i = 0; i < length; i++)
    {
        
            System.Console.Write($"{arr[i]}\t");
        
        
    }

}
int[] TransferValAtArray(int[,] arr){
    int lengthCol= arr.GetLength(0);
    int lengthRow = arr.GetLength(1);
    int[] values = new int[arr.Length];
    int index = 0;
    
    for (int i = 0; i < lengthCol; i++)
    {
        for (int j = 0; j < lengthRow; j++)
        {
            values[index] = arr[i,j];
            index ++;
        }
    }
    return values;
}
void SortArr(int[] arr){
    int length= arr.Length;
    int max = arr[0];
    for (int i = 0; i < length; i++)
    {
        for (int j = 0; j < length-1; j++)
        {
            if (arr[j] > arr[j+1]){
                max = arr[j];
                arr[j] = arr[j + 1];
                arr[j + 1] = max;
            }
        }
    }
}

void Frequence(int[] arr){
    int count = 1;
    int length= arr.Length;
    for (int i = 0; i < length; i++)
    {
        //System.Console.WriteLine(arr[i]);
       if(arr[i] == arr[i + 1]){
        count ++;
       } else{
        System.Console.WriteLine($"{arr[i]} встречается {count} раз");
        count = 1;
       }
       
    }
}

int m = InputNum("Введите m: ");
int n = InputNum("Введите n: ");;
int[,] arr = new int[m,n];
FillArr(arr, m, n);
PrintArray(arr);
int[] arr2 = TransferValAtArray(arr);
SortArr(arr2);
System.Console.WriteLine();
Frequence(arr2);
PrintArray2(arr2);