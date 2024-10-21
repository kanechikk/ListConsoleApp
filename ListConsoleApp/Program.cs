internal class Program
{
    private static void Main(string[] args)
    {
        IntList array = new IntList(1, 2, 3, 4, 5, 6, 7);
        Console.WriteLine(array.ToString());

        array.Add(8);
        Console.WriteLine(array.ToString());

        array.RemoveAt(1);
        Console.WriteLine(array.ToString() + " " + array.Count);

        array.Remove(3);
        Console.WriteLine(array.ToString() + " " + array.Count);

        array.Insert(3, 66);
        Console.WriteLine(array.ToString() + " " + array.Count);

        //array.Insert(15, 100);
        //Console.WriteLine(array.ToString() + " " + array.Count);

    }
}