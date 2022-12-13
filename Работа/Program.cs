string[] ReadArray() 
{
    Console.Write("Создайте массив (через пробел): ");
    string [] ar = Console.ReadLine().Split(" ");
    return ar;
}

int Size(string[] MyArray, int n) 
{
    int num = 0;

    for(int i = 0; i < MyArray.Length; i++) 
    {
        if(MyArray[i].Length <= n) num++;
    }

    return num;
}



string[] MyArray = ReadArray();
Console.WriteLine($"[{string.Join(" ", MyArray)}]");