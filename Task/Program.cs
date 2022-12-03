
string[] Method (string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i == 0) Console.Write($"[\"{array[i]}\", ");
        else if (i == array.Length - 1) Console.Write($"\"{array[i]}\"] -> ");
        else Console.Write($"\"{array[i]}\", ");         
    }

    string[] resultArray = new string[array.Length]; 
    int k = 0;

    for (int i = 0; i < array.Length; i++)
    {              
        if (array[i].Length <= 3)
        {
            resultArray[k] = array[i];
            k++;
        }
    }
    return resultArray;
}
    
void WriteResultArray(string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] != null)
        {
            count++;
            if (count == 1 && array[i + 1] == null) Console.Write($"[\"{array[i]}\"] ");
            else if (i == 0) Console.Write($"[\"{array[i]}\", ");     
            else Console.Write($"\"{array[i]}\"]");     
        }                            
    }
    if (count == 0) Console.Write("[]");
    System.Console.WriteLine();    
}

string [] array1 = new string[] {"hello", "2", "world", ":-)"};
string [] array2 = new string[] {"1234", "1567", "-2", "computer science"};
string [] array3 = new string[] {"Russia", "Denmark", "Kazan"};

WriteResultArray(Method(array1));
WriteResultArray(Method(array2));
WriteResultArray(Method(array3));
