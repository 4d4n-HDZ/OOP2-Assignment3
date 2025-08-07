using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3_skeleton
{
    public class SLL : LinkedListADT
    {
        private Node head;
        private int size = 0;
        public SLL() 
        {
            head = null;
        }
        public void Append(object data)
        {
            Node newNode = new Node(data,null);
            if (IsEmpty())
            {
                head = newNode;
            }
            else
            {
                Node current = head;
                while(current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newNode;
            }
        }

        public void Clear()
        {
            head = null;
        }

        public bool Contains(object data)
        {
            Node current = head;
            while (current != null)
            {
                if (current.Equals(data))
                {
                    return true;
                }
                current = current.Next;
            }
            return false;
        }

        public void Delete(int index)
        {
            if (index < 0|| IsEmpty())
            {
                throw new IndexOutOfRangeException();
            }
            if (index == 0)
            {
                head = head.Next;
                return;
            }
            Node current = head;
            int currentIndex = 0;
            while (current != null && currentIndex < index - 1)
            {
                current = current.Next;
                currentIndex++;
            }
            if (current == null || current.Next == null)
            {
                throw new IndexOutOfRangeException("Index is out of bounds.");
            }
            current.Next = current.Next.Next;
        }

        public int IndexOf(object data)
        {
            Node current = head;
            int index = 0;

            while (current != null)
            {
                if (current.Data.Equals(data))
                {
                    return index;
                }
                current = current.Next;
                index++;
            }
            return -1;
        }

        public void Insert(object data, int index)
        {
            if (index < 0 || index > size)
            {
                throw new IndexOutOfRangeException("Index is out of range.");
            }

            if (index == 0)
            {
                Node newNode = new Node(data, head);
                head = newNode;
            }
            else
            {
                Node current = head;
                for (int i = 0; i < index - 1; i++)
                {
                    current = current.Next;
                }

                Node newNode = new Node(data, current.Next);
                current.Next = newNode;
            }

            size++;
        }

        public bool IsEmpty()
        {
           return head== null;
        }

        public void Prepend(object data)
        {
            Node newNode = new Node(data,head);
            newNode .Next = head;
            head = newNode;
            size++;
        }

        public void Replace(object data, int index)
        {
            if (index < 0 || index >= size)
            {
                throw new IndexOutOfRangeException("Index is out of bounds.");
            }

            Node current = head;
            for (int i = 0; i < index; i++)
            {
                current = current.Next;
            }

            current.Data = data;
        }

        public object Retrieve(int index)
        {
            if (index < 0)
            {
                throw new IndexOutOfRangeException("Index cannot be negative.");
            }

            Node current = head;
            int currentIndex = 0;

            while (current != null)
            {
                if (currentIndex == index)
                {
                    return current.Data; 
                }

                current = current.Next; 
                currentIndex++;
            }

            
            throw new IndexOutOfRangeException("Index exceeds list size.");
        }

        public int Size()
        {
            int count = 0;
            Node current = head;

            while (current != null)
            {
                count++;
                current = current.Next; 
            }

            return count;
        }
    }
}
