using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NormalList
{
    class Node<T>
    {
        public Node<T>? pNext;
        public Node<T>? pPrev;
        public T Value { get; set; }

        public Node(T value, Node<T>? pNext = null, Node<T>? pPrev = null)
        {
            if (pNext == null && pPrev != null)
            {
                this.pNext = pNext;
                this.pPrev = pPrev;
                this.pPrev.pNext = this;
            }
            else if (pPrev == null && pNext != null)
            {
                this.pNext = pNext;
                this.pPrev = pPrev;
                this.pNext.pPrev = this;
            }
            
           Value = value;
        }
    }
}
