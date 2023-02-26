int[] array = { 11, 21, 35, 35, 68, 64, 86, 96, 85 };

int n = array.Length;
int find = 68;

int index = 0;

while ( index < n)

{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}

