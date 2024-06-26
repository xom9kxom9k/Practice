using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeOne.Second;

public class Deck
{
    private Node? head;
    private Node? tail;
    private int size;

    public Deck()
    {
        head = null;
        tail = null;
        size = 0;
    }

    public int Length()
    {
        return size;
    }
    public void AddFirst(int data)
    {
        Node newNode = new Node(data);
        if (head == null)
        {
            head = tail = newNode;
        }
        else
        {
            newNode.Next = head;
            head = newNode;
        }
        size++;
    }
    public void AddLast(int data)
    {
        Node newNode = new Node(data);
        if (tail == null)
        {
            head = tail = newNode;
        }
        else
        {
            tail.Next = newNode;
            tail = newNode;
        }
        size++;
    }
    public int? RemoveFirst()
    {
        if (head == null)
        {
            return null; 
        }
        int data = head.Data;
        head = head.Next;
        if (head == null)
        {
            tail = null; 
        }
        size--;
        return data;
    }
    public int? RemoveLast()
    {
        if (tail == null)
        {
            return null; 
        }

        if (head == tail)
        {
            int data = tail.Data;
            head = tail = null;
            size--;
            return data;
        }

        Node current = head;
        while (current.Next != tail)
        {
            current = current.Next;
        }

        int tailData = tail.Data;
        tail = current;
        tail.Next = null;
        size--;
        return tailData;
    }
    public bool IsEmpty()
    {
        return size == 0;
    }

    public string Print()
    {
        if (head == null) return "";

        Node ptr = head;
        string s = "";
        while (ptr != null)
        {
            s += ptr.Data + (ptr.Next != null ? " -> " : "");
            ptr = ptr.Next;
        }
        return s;
    }
}
