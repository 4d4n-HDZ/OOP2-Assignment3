using System;

namespace Assignment_3
{
    [Serializable]
    public class SLL : LinkedListADT
    {
        private Node head;
        private int size;
        public bool IsEmpty() => size == 0;
        public int Size() => size;
        public void Clear()
        {
            head = null;
            size = 0;
        }
        public void Prepend(object data)
        {
            var n = new Node(data) { Next = head };
            head = n;
            size++;
        }
        public void Append(object data)
        {
            var n = new Node(data);
            if (head == null) head = n;
            else
            {
                var c = head;
                while (c.Next != null) c = c.Next;
                c.Next = n;
            }
            size++;
        }
        public void Insert(object data, int index)
        {
            if (index < 0 || index > size) throw new IndexOutOfRangeException();
            if (index == 0) { Prepend(data); return; }
            var c = head;
            for (int i = 1; i < index; i++) c = c.Next;
            var n = new Node(data) { Next = c.Next };
            c.Next = n;
            size++;
        }
        public void Replace(object data, int index)
        {
            if (index < 0 || index >= size) throw new IndexOutOfRangeException();
            var c = head;
            for (int i = 0; i < index; i++) c = c.Next;
            c.Data = data;
        }
        public object Retrieve(int index)
        {
            if (index < 0 || index >= size) throw new IndexOutOfRangeException();
            var c = head;
            for (int i = 0; i < index; i++) c = c.Next;
            return c.Data;
        }
        public void Delete(int index)
        {
            if (index < 0 || index >= size) throw new IndexOutOfRangeException();
            if (index == 0) head = head.Next;
            else
            {
                var p = head;
                for (int i = 1; i < index; i++) p = p.Next;
                p.Next = p.Next.Next;
            }
            size--;
        }
        public int IndexOf(object data)
        {
            var c = head;
            int i = 0;
            while (c != null)
            {
                if ((data == null && c.Data == null) || (data != null && data.Equals(c.Data)))
                    return i;
                c = c.Next;
                i++;
            }
            return -1;
        }
        public bool Contains(object data) => IndexOf(data) >= 0;
        public void Reverse()
        {
            Node prev = null;
            var c = head;
            while (c != null)
            {
                var nx = c.Next;
                c.Next = prev;
                prev = c;
                c = nx;
            }
            head = prev;
        }
    }
}