internal class Program
{
    private static void Main(string[] args)
    {
        IntList array = new IntList(1, 2, 3, 4);
        Console.WriteLine(array.ToString());

        array.Add(5);
        Console.WriteLine(array.ToString());

        array.Remove(3);
        Console.WriteLine(array.ToString() + " " + array.Count);
    }
}