int[] array = { 12, 21, 53, 84, 91, 75, 26, 17, 28, 91 };

int n = array.Length;
int find = 91;

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    // index = index + 1;
    index++;
}
