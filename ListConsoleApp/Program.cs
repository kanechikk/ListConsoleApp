using System.Security.Cryptography.X509Certificates;

internal class Program
{
    private static void Main(string[] args)
    {
        IntList<int> array = new IntList<int>(5, 10, 4, 3, 15, 7, 9);
        Console.WriteLine(array.ToString() + " : " + array.Count);

        array.Add(8);
        Console.WriteLine(array.ToString() + " : " + array.Count);

        array.RemoveAt(1);
        Console.WriteLine(array.ToString() + " : " + array.Count);

        array.Remove(8);
        Console.WriteLine(array.ToString() + " : " + array.Count);

        array.Insert(3, 66);
        Console.WriteLine(array.ToString() + " : " + array.Count);

        //array.Insert(15, 100);
        //Console.WriteLine(array.ToString() + " " + array.Count);

        //array.Clear();
        //Console.WriteLine(array.ToString() + " : " + array.Count);
    
        
        //array.ForEach(x => Console.WriteLine(x));
        //Console.WriteLine(array.ToString() + " : " + array.Count);

        //Console.WriteLine(array.Find(x => x % 2 == 0));

        array.Sort( (x, y) => 
        {
            if (x == y)
            {
                return 0;
            }
            else if (x > y)
            {
                return 1;
            }
            else
            {
                return 2;
            } 
        } );

        Console.WriteLine(array.ToString() + " : " + array.Count);

    }

}