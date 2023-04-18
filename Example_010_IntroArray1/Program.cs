// Решение задачи с массивом с помощью Метода(Функции) продолжение


// Индекс массива   0  1   2   3   4  5   6   7
int[] array =     {11, 2, 33, 18, 15, 6, 17, 28 };

int n = array.Length;

int find = 18;

int index = 0;

while (index < n)
{

    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
// index = index + 1;
    index++;
}