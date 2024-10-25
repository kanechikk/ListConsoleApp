using System.Xml.XPath;

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
        RemoveAt(IndexOf(item));
    }

    public void RemoveAt(int index)
    {
        if (index >= _count || index == -1)
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
        if (index >= _count || index == -1)
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

    public int IndexOf(T item)
    {
        for (int i = 0; i < _count; i++)
        {
            if (_array[i].Equals(item))
            {
                return i;
            }
        }
        return -1;
    }

    public void ForEach(System.Action<T> action)
    {
        for (int i = 0; i < _count; i++)
        {
            action(_array[i]);
        }
    }

    public T Find(System.Func<T, bool>  predicate)
    {
        for (int i = 0; i < _count; i++)
        {
            if (predicate(_array[i]))
            {
                return _array[i];
            }
        }
        return default(T);
    }

    static void Swap(ref T el1, ref T el2)
    {
        T temp = el1;
        el1 = el2;
        el2 = temp;
    }

    public void Sort(System.Func<T, T, int> sort)
    {
        for (int i = 0; i < _count; i++)
        {
            for (int j = 0; j < _count - i - 1; j++)
            {
                if (sort(_array[j], _array[j + 1]) == 1)
                {
                    Swap(ref _array[j], ref _array[j + 1]);
                }
            }
        }
    }
}