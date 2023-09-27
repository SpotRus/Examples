int[] array = { 21, 2, 6, 778, 88, 2, 34, 187 };

int n = array.Length;
int find = 2;

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}
