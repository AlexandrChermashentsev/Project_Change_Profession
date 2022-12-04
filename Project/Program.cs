void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] != null && array[i].Length > 0) // проверка на пустоту элемента массива
        {
            if(i == array.Length - 1) 
                Console.Write($"{array[i]}");
            else Console.Write($"{array[i]}, ");
        }
    }
    Console.Write("]");
    Console.WriteLine();
}

string[] InitialArray(int quantity)
{
    string[] array = new string[quantity];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Console.ReadLine();
    }
    return array;
}


Console.WriteLine("Enter the integer number - length of the array");
int userLength = Convert.ToInt32(Console.ReadLine());

string[] userArray = InitialArray(userLength);
PrintArray(userArray);