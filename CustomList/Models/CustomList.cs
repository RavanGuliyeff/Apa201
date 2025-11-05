namespace ConsoleApp3.Models;

using System;

public class CustomList<T>
{
    private T[] _items;
    public int Count { get; private set; }
    public int Capacity => _items.Length;

    public CustomList()
    {
        _items = Array.Empty<T>();
    }
    public CustomList(int capacity)
    {
        _items = capacity == 0 ? Array.Empty<T>() : new T[capacity];

        if (capacity == 0)
        {
            _items = Array.Empty<T>();
        }
        else
        {
            _items = new T[capacity];
        }
        Count = 0;
    }
    public CustomList(params T[] items) : this()
    {
        foreach (var item in items)
            Add(item);
    }
    public void Add(T item)
    {
        if (Count == Capacity)
            Resize();

        _items[Count++] = item;
    }
    public bool Remove(T item)
    {
        int index = IndexOf(item);
        if (index == -1)
            return false;

        for (int i = index; i < Count - 1; i++)
        {
            _items[i] = _items[i + 1];
        }
        // 1 2 4 5 0
        Count--;
        _items[Count] = default!;
        return true;
    }
    public int IndexOf(T item)
    {
        for (int i = 0; i < Count; i++)
        {
            if (_items[i].Equals(item))
                return i;
        }
        return -1;
    }
    public bool Contains(T item)
    {
        return IndexOf(item) != -1;
    }
    public void Clear()
    {
        for (int i = 0; i < Count; i++)
            _items[i] = default!;

        Count = 0;
    }
    public T this[int index]
    {
        get
        {
            return _items[index];
        }
        set
        {
            _items[index] = value;
        }
    } //opt
    private void Resize()
    {
        int newCapacity = Capacity == 0 ? 4 : Capacity * 2;

        T[] newArray = new T[newCapacity];
        for (int i = 0; i < Count; i++)
        {
            newArray[i] = _items[i];
        }
        _items = newArray;
    }
    public void PrintAll()
    {
        for (int i = 0; i < Count; i++)
        {
            Console.WriteLine(_items[i]);
        }
    }
    public void TrimExcess()
    {
        if (Count < Capacity)
        {
            T[] newArray = new T[Count];

            for (int i = 0; i < Count; i++)
            {
                newArray[i] = _items[i];

            }

            _items = newArray;
        }
    } //opt


    // -------------------------------delegates-------------------------------------------------------------------------------------
    

}

