class IntList<T>
{
    private T[] _array;
    private int _count;

    public int Count 
    {
        get { return _count; }
    }

    public IntList(params T[] numbers)
    {
        _array = numbers;
        _count = numbers.Length;
    }

    private void Resize()
    {
        T[] temp = _array;
        _array = new T[_count * 2];

        for (int i = 0; i < temp.Length; i++)
        {
            _array[i] = temp[i];
        }
    }

    public void Add(T item) 
    {
        if (_count + 1 > _array.Length)
        {
            Resize();
        }

        _count++;
        
        _array[_count - 1] = item;
    }

    public void Remove(T item)
    {
        for (int i = 0; i < _count; i++)
        {
            if (_array[i].Equals(item))
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

        for (int i = index; i < _count; i++)
        {
            _array[i] = _array[i + 1];
        }
    }

    public void Insert(int index, T item)
    {
        if (index >= _count)
        {
            throw new Exception("В массиве нет необходимого индекса.");
        }

        _count++;
        if (_count > _array.Length)
        {
            Resize();
        }

        for (int i = _count - 1; i > index; i--)
        {
            _array[i] = _array[i - 1];
        }

        _array[index] = item;
    }

    public void Clear()
    {
        _array = new T[0];
        _count = 0;
    }

    public string ToString() 
    {
        string result = "";
        for (int i = 0; i < _count; i++)
        {
            result += _array[i] + " ";
        }
        return result; 
    }
}