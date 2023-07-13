using System;


class Program
{
    public static void Main(string[] args)
    {
        CustomList list = new CustomList();
        string inputList1 = Console.ReadLine();
        string[] splitInput1 = inputList1.Split(' ');
        for (int i = 0; i < splitInput1.Length; i++)
        {
            list.InsertEnd(splitInput1[i]);
        }

        string inputList2 = Console.ReadLine();
        string[] splitInput2 = inputList2.Split(' ');

        string query = Console.ReadLine();
        if (query == "nao")
        {
            for (int i = 0; i < splitInput2.Length; i++)
            {
                list.InsertEnd(splitInput2[i]);
            }
        }
        else
        {
            int position = list.Search(query);
            for (int i = 0; i < splitInput2.Length; i++)
            {
                list.Insert(splitInput2[i], position);
                position++;
            }
        }

        list.Show();
    }
}


class Cell
{
    public string Element; // Element inserted in the cell.
    public Cell Next; // Points to the next cell.


    public Cell(string element)
    {
        Element = element;
        Next = null;
    }
}


class CustomList
{
    private Cell First;
    private Cell Last;


    public CustomList()
    {
        string x = "";
        First = new Cell(x);
        Last = First;
    }


    public void InsertStart(string x)
    {
        Cell tmp = new Cell(x);
        tmp.Next = First.Next;
        First.Next = tmp;
        if (First == Last)
        {
            Last = tmp;
        }
        tmp = null;
    }


    public void InsertEnd(string x)
    {
        Last.Next = new Cell(x);
        Last = Last.Next;
    }


    public string RemoveStart()
    {
        if (First == Last)
        {
            throw new Exception("Error: Cannot remove from an empty list!");
        }

        Cell tmp = First;
        First = First.Next;
        string response = First.Element;
        tmp.Next = null;
        tmp = null;
        return response;
    }


    public string RemoveEnd()
    {
        if (First == Last)
        {
            throw new Exception("Error: Cannot remove from an empty list!");
        }
        Cell i;
        for (i = First; i.Next != Last; i = i.Next) ;


        string response = Last.Element;
        Last = i;
        i.Next = Last.Next = null;
        return response;
    }


    public void Insert(string x, int pos)
    {
        int size = Size();


        if (pos < 0 || pos > size)
        {
            throw new Exception("Error: Invalid position to insert (" + pos + " / size = " + size + ")!");
        }
        else if (pos == 0)
        {
            InsertStart(x);
        }
        else if (pos == size)
        {
            InsertEnd(x);
        }
        else
        {
            Cell i = First;
            for (int j = 0; j < pos; j++, i = i.Next) ;


            Cell tmp = new Cell(x);
            tmp.Next = i.Next;
            i.Next = tmp;
            tmp = i = null;
        }
    }


    public string Remove(int pos)
    {
        string response;
        int size = Size();


        if (First == Last)
        {
            throw new Exception("Error: Cannot remove from an empty list!");
        }
        else if (pos < 0 || pos >= size)
        {
            throw new Exception("Error: Invalid position to remove (" + pos + " / " + size + ")!");
        }
        else if (pos == 0)
        {
            response = RemoveStart();
        }
        else if (pos == size - 1)
        {
            response = RemoveEnd();
        }
        else
        {
            Cell i = First;
            for (int j = 0; j < pos; j++, i = i.Next) ;


            Cell tmp = i.Next;
            response = tmp.Element;
            i.Next = tmp.Next;
            tmp.Next = null;
            i = tmp = null;
        }


        return response;
    }


    public int Search(string x)
    {
        int response = 0;
        int count = 0;
        for (Cell i = First.Next; i != null; i = i.Next)
        {
            if (i.Element == x)
            {
                response = count;
                i = Last;
            }
            count++;
        }
        return response;
    }


    public int Size()
    {
        int size = 0;
        for (Cell i = First; i != Last; i = i.Next, size++) ;
        return size;
    }


    public void Show()
    {
        for (Cell i = First.Next; i != null; i = i.Next)
        {
            Console.Write(i.Element + " ");
        }
    }
}
