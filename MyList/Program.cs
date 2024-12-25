// See https://aka.ms/new-console-template for more information
using System;
using MyCustomList;
public class Program
{
    public static void Main()
    {
        MyList List = new MyList(2, 1);
        List.PrintInfo();

        List.Add(2);
        List.PrintInfo();
        
        int[] array = { 3, 5, 6, 7, 8 };
        List.Add(array);
        List.PrintInfo();
        
        List.Add(3,4);
        List.PrintInfo();
        
        int[] secondArray = { 66, 666, 6666} ;
        List.Add(6,secondArray);
        List.PrintInfo();
    }
}


