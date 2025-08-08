using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    public interface LinkedListADT
    {
        bool IsEmpty();
        int Size();
        void Clear();
        void Append(object data);
        void Prepend(object data);
        void Insert(object data, int index);
        void Replace(object data, int index);
        object Retrieve(int index);
        void Delete(int index);
        int IndexOf(object data);
        bool Contains(object data);
        void Reverse();
    }
}

