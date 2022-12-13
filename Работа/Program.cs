string[] ReadArray() 
{
    Console.Write("Создайте массив (через пробел): ");
    string [] ar = Console.ReadLine().Split(" ");
    return ar;
}


string[] FindThreeSim(string[] MyArray, int n) 
{
    string[] res = new string[Size(MyArray, n)];

    for(int i = 0, j = 0; i < MyArray.Length; i++) 
    {
        if(MyArray[i].Length <= n) 
        {
            res[j] = MyArray[i];
            j++;
        }
    }

    return res;
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
string[] result = FindThreeSim(MyArray, 3);
Console.WriteLine($"[{string.Join(", ", MyArray)}] -> [{string.Join(", ", result)}]");
