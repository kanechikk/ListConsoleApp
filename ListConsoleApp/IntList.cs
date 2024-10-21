class IntList 
{
    private int[] _array;
    private int _count;

    public int Count 
    {
        get { return _count; }
    }

    public IntList(params int[] numbers)
    {
        _array = numbers;
        _count = numbers.Length;
    }

    public void Add(int item) 
    {

    }
}