namespace MyCustomList;
using System;
public class MyList
{
    private int[] _array;
    public int Capacity { get; set; }
    public int Count { get; set; }
    
    
    public MyList()
    {
        _array = new int[10];
        Capacity = _array.Length;
        Count = 0;
    }
    public MyList(int capacity)
    {
        _array = new int[capacity];
        Capacity = capacity;
        Count = 0;
    }

    public MyList(int capacity, int element)
    {
        _array = new int[capacity];
        _array[0] = element;
        Capacity = capacity;
        Count = 1;
    }

    public void PrintInfo()
    {
        Console.WriteLine($"Capacity: {Capacity}");
        Console.WriteLine($"Count: {Count}");
        for (int i = 0; i < Capacity; i++)
        {
            Console.WriteLine($"_array[{i}]: {_array[i]}");
            
        }
        
        Console.WriteLine( );
    }
    public void Add(int element) // добавляем 1 элемент
    {
        if(Count >= Capacity)
        {
            Resize();
        }
        _array[Count] = element;
        Count++;
    }

    public void Add(int[] elements) // добаваяем массив элементов
    {   
        if(Count >= Capacity)
        {
            Resize(elements.Length);
        }
        
        for (int i = 0; i < elements.Length; i++)
        {
            _array[Count] = elements[i];
            Capacity = _array.Length;
            Count++;
        }

    }

    public void Add(int index, int element){

        {
                for (int i = Count; i >= index; i--)
                {
                    if (i + 2 >= _array.Length)
                    {
                        Resize();
                    }
                    _array[Count] = _array[i - 1];
                }

                _array[index] = element;
        }
        //Реализовать

        //1, 2, 3, 5, 6, 7

        //Add(3, 4)

        //1, 2, 3, 4, 5, 6, 7

    }

 

    public void Add(int index, int[] elements)

    {

        //Реализовать

    }

 

    public int this[int index]
    {
        get
        {
            if(index >= Count || index < 0)
            { 
                throw new IndexOutOfRangeException();
            }
            return _array[index];
        }
        
        set
        {
            if (index >= Count || index < 0)
            {
                throw new IndexOutOfRangeException();
            }
            _array[index] = value;
        }
    }

 

    private void Resize()
    {
        int newLength = _array.Length * 2;
        var newArray = new int[newLength];
        
        Array.Copy(_array, newArray, Count);
        _array = newArray;
    }
    
    private void Resize(int arrayLenth)
    {
        int newLength = _array.Length * 2 + arrayLenth;
        var newArray = new int[newLength];
        
        Array.Copy(_array, newArray, Count);
        _array = newArray;
    }
    
    private void Copy(int[] sourceArray, int[] destinationArray)
    {
        if(sourceArray.Length > destinationArray.Length)
        {
            throw new ArgumentException();
        }
        
        for(int i = 0; i < sourceArray.Length; i++)
        {
            destinationArray[i] = sourceArray[i];
        }
    }
}