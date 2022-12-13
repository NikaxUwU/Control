string[] ReadArray() 
{
    Console.Write("Создайте массив (через пробел): ");
    string [] ar = Console.ReadLine().Split(" ");
    return ar;
}

string[] MyArray = ReadArray();
Console.WriteLine($"[{string.Join(" ", MyArray)}]");