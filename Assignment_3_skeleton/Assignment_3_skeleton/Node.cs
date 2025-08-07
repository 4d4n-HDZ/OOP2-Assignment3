using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3_skeleton
{
    internal class Node
    {
        object data;
        Node next;

        public object Data { get => data; set => data = value; }
        public Node Next { get => next; set => next = value; }

        public Node(object obj, Node node)
        {
            data = obj;
            next = node;
        }
    }
}
