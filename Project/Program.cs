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
        else Console.Write("<null>, ");
    }
    Console.Write("]");
    Console.WriteLine();
}

string[] InitialArray(int quantity)
{
    string[] array = new string[quantity];
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"Enter the {i+1} element of array");
        array[i] = Console.ReadLine();
    }
    return array;
}

string[] FindThreeElementsArray(string[] startingArray)
{
    int finalArrLength = 0;
    for (int i = 0; i < startingArray.Length; i++)
    {
        if (startingArray[i].Length <= 3 && startingArray[i] != null && startingArray[i].Length > 0) 
        finalArrLength++;
    }
    string[] finalArr = new string[finalArrLength];
    int j = 0;
    for (int i = 0; i < startingArray.Length; i++)
    {
        if(startingArray[i].Length <= 3 && startingArray[i] != null && startingArray[i].Length > 0) 
        {
            finalArr[j] = startingArray[i];
            j++;
        }
    }
    return finalArr;
}

Console.WriteLine("Enter the integer positive number - length of the array");
int userLength = Convert.ToInt32(Console.ReadLine());

string[] userArray = InitialArray(userLength);
PrintArray(userArray);

string[] finalArr = FindThreeElementsArray(userArray);
PrintArray(finalArr);