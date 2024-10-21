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
        _count++;
        int[] list = _array;
        _array = new int[_count];

        for (int i = 0; i < list.Length; i++)
        {
            _array[i] = list[i];
        }

        _array[_count - 1] = item;
    }
}