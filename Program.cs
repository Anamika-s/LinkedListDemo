using System;

namespace LinkedListDemo
{
public class Node
{
    public Node Next;
    public int Data;
}
public class LinkedList
{
   private Node first= null;
   private Node last=null;//This will have latest node
   private Node new1 = null;
   public int Count;
   public LinkedList(int data)
   {
       new1 = new Node();
       new1.Data = data;
       new1.Next = null;
       if(first==null)
       last = first=new1;
       Console.WriteLine("First Node Constructed");
   }  

  public void AddNode(int data)
  {
      new1= new Node();
      new1.Data = data;
      new1.Next = null;
      if(new1.Data <= first.Data)
      {
          new1.Next = first;
          first = new1;
          Console.WriteLine("Node inserted in Beginning");
      }
      else if(new1.Data >= last.Data)
      {
          last.Next = new1;
          last = new1;
          Console.WriteLine("Node Added at End");
    }
      else 
      {
          Node ptr = new Node();
          Node prev = new Node();
       for(ptr = prev = first ; ptr.Next !=null; prev=ptr, ptr=ptr.Next)
       { 
           Console.WriteLine("Prev Node " + prev.Data);
           Console.WriteLine("Ptr Node"  + ptr.Data);
           if(new1.Data >= prev.Data && new1.Data < ptr.Data)
           {
               prev.Next = new1;
               new1.Next = ptr;
               Console.WriteLine("Node Inserted in Between");
               break;
           }
       }
      }
  }
   public void Display()
   {
        Node ptr = new Node(); 
       for(ptr = first ; ptr.Next !=null ; ptr=ptr.Next)
       { 
            Console.WriteLine(ptr.Data);

       }
   }
}
    class Program
    {
        static void Main(string[] args)
        {
        LinkedList list = new LinkedList(2);
        list.Display();
        string choice="y";
        while(choice=="y")
        {
            Console.WriteLine("Enter Data");
            int data = Int32.Parse(Console.ReadLine());
            list.AddNode(data);
            Console.WriteLine("Wnat to add more Data");
            choice = Console.ReadLine();
        }
        list.Display();
        
        }
    }
    }
