//Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
//Массив размером 2 x 2 x 2
//66(0,0,0) 25(0,1,0)
//34(1,0,0) 41(1,1,0)
//27(0,0,1) 90(0,1,1)
//26(1,0,1) 55(1,1,1)

Random rnd = new Random();
int m = rnd.Next(2, 5);
int n = rnd.Next(2, 5);
int o = rnd.Next(2, 5);

int[,,] array = new int[m, n, o];
int[] arr = new int[90];
for (int q = 10; q < arr.Length + 10; q++)
{
    arr[q - 10] = q;

}

for (int r = 0; r < arr.Length; r++)
{
    int w = rnd.Next(90);
    int buf = arr[w];
    arr[w] = arr[r];
    arr[r] = buf;
}


void FillArray(int[,,] array)
{
    int t = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {

                array[i, j, k] = arr[t];
                t++;
            }
        }

    }
}


void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)

        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write(String.Format("{0,4}", (array[i, j, k] + "[" + i + "," + j + "," + k + "] ")));
                //Console.Beep();
            }
            Console.WriteLine();
        }


    }
}

Console.WriteLine();
FillArray(array);
Console.WriteLine("Random 3D array:");
PrintArray(array);



