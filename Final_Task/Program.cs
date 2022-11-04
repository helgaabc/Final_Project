string[] arr1 = new string[5] {"Hello", "Kazan", "123", "world", ":-)"};
string[] arr2 = new string[arr1.Length];
void secArray(string[] arr1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < arr1.Length; i++)
    {
    if(arr1[i].Length <= 3)
        {
        array2[count] = arr1[i];
        count++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
secArray(arr1, arr2);
PrintArray(arr2);