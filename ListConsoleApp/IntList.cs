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
        for (int i = 0; i < _count; i++)
        {
            if (_array[i] == item)
            {
                RemoveAt(i);
                break;
            }
        }
    }

    public void RemoveAt(int index)
    {
        if (index >= _count)
        {
            throw new Exception("В массиве нет необходимого индекса.");
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