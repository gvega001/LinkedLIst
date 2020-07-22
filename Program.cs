using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SinglyLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            SinglyLinkedList myLIst = new SinglyLinkedList();
            myLIst.insertFirst(100);
            myLIst.insertFirst(50);
            myLIst.insertFirst(99);
            myLIst.insertFirst(88);
            myLIst.insertLast(999000);
            myLIst.displayList();
            Thread.Sleep(3000);
            myLIst.deleteFirst();
             myLIst.displayList();
            Thread.Sleep(3000);
        }
    }
    public class SinglyLinkedList
    {
    private Node first;
        public bool isEmpty()
        {
            return (first ==null);
        }
          public void insertFirst(int data)
        {
            Node newNode = new Node();
            newNode.data = data;
            newNode.next = first;
            first = newNode;
        }
        public Node deleteFirst()
        {
            Node temp = first;
            first = first.next;
            return temp;
        }
        public void displayList()
        {
            Console.WriteLine("List(first --last");
            Node current = first;
            while (current != null)
	        {
                current.displayNode();
                current = current.next;
	        }
            Console.WriteLine();
        }
        public void insertLast(int data)
        {
            Node current = first; 
            while (current.next!= null)
	        {
                current = current.next;
	        }
            Node newNode = new Node();
            newNode.data = data;
            current.next = newNode;
        } 
    }
  
    public class Node {
    public int data;
    public Node next;

    public void displayNode(){
    Console.WriteLine("<"+ data +">");
        }
    }
}
