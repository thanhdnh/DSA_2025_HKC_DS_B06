public class Node
{
    public object data;
    public Node link;

    public Node()
    {
        data = link = null;
    }
    public Node(object element)
    {
        data = element;
        link = null;
    }
}
public class LinkedList
{
    public Node header;
    public LinkedList()
    {
        header = new Node("Header");
    }
    public Node Find(object value)
    {
        Node current = header;
        while (current.link != null && current.data != value)
        {
            current = current.link;
        }
        return current;
    }

    public void Insert(object newdata, object after)
    {
        Node current = Find(after);
        Node newnode = new Node(newdata);
        newnode.link = current.link;
        current.link = newnode;
    }
    public Node FindPrev(object value)
    {
        Node current = header;
        do
        {
            current = current.link;
        } while (current.link != null && current.link.data != value);
        return current;
    }
    public void Remove(object deleteddata)
    {
        Node current = FindPrev(deleteddata);
        current.link = current.link.link;
    }
    public void Print()
    {
        Node current = header;
        do
        {
            Console.WriteLine(current.data);
            current = current.link;
        } while (current != null);
    }
    public int FindMax()
    {
        //Hoàn thiện nội dung
        return 0;
    }
    public int FindMin()
    {
        //Hoàn thiện nội dung
        return 0;
    }
    public int Sum()
    {
        //Hoàn thiện nội dung
        return 0;
    }
    public int Count()
    {
        //Hoàn thiện nội dung
        return 0;
    }
    public void PrintPrime()
    {
        //Hoàn thiện nội dung: in ra các nút là số nguyên tố
    }
}
public class Node2
{

}
public class DoubleLinkedList
{
    //Cài đặt lại như slide
    //Bổ sung các thủ tục FindMax, FindMin, Sum, Count
}
public class Program
{
    public static void Main(string[] args)
    {
        LinkedList llist = new LinkedList();
        llist.Insert("5", "Header");
        llist.Insert("8", "5");
        llist.Insert("3", "8");
        llist.Print();
        //System.Console.WriteLine("---after removing Second ---");
        //llist.Remove("Second");
        //llist.Print();


        //Bài 3. Thử nghiệm với LinkedList trong NET
    }
}