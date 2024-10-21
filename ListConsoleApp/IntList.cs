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

    public void Remove(int item)
    {
        _count--;
        int[] list = _array;
        _array = new int[_count];
        int c = 0;

        for (int i = 0; i < list.Length ; i++)
        {
            if (list[i] == item && c == 0)
            {
                c++;
            }
            else if (c == 0)
            {
                _array[i] = list[i];
            }
            else 
            {
                _array[i - 1] = list[i];
            }
        }

    }

    public void RemoveAt(int index)
    {
        if (index >= _count)
        {
            throw new Exception("В массиве нет данного индекса.");
        }
        
        _count--;
        int[] list = _array;
        _array = new int[_count];

        for (int i = 0; i < index; i++)
        {
            _array[i] = list[i];
        }

        for (int i = index; i < _count; i++)
        {
            _array[i] = list[i + 1];
        }
    }


    public string ToString() 
    { 
        return string.Join(", ", _array); 
    }
}