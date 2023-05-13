using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NormalList
{
    internal class MyList<T>
    {
        private Node<T>? _pHead;
        private Node<T>? _pTail;

        public MyList() 
        {
            _pHead = null;
            _pTail = null;
        }

        public void PushFront(T value)
        {

            if(_pHead == null)
            {
                _pHead = _pTail = new Node<T>(value);
            }
            else
            {
               _pHead = new Node<T>(value, _pHead, null);
            }

        }
        public void PushBack(T value)
        {
            if (_pTail == null)
            {
                _pHead = _pTail = new Node<T>(value);
            }
            else
            {
                _pTail = new Node<T>(value, null, _pTail);
            }
        }

        public T PopFront()
        {
            if (_pHead == null)
            {
                throw new Exception("Начальный элемент пуст");
            }
            else
            {
                T resultValue = _pHead.Value;
                _pTail = _pHead.pNext;

                return resultValue;
            }
        }
        public T PopBack()
        {
            if (_pTail == null)
            {
                throw new Exception("Конечный элемент пуст");
            }
            else
            {
                T resultValue = _pTail.Value;
                _pTail = _pTail.pPrev;

                return resultValue;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            if (_pHead == null)
            {
                throw new Exception("В списке пусто");
            }
            else
            {
                Node<T>? pTemp = _pHead;

                while(pTemp != null)
                {
                    sb.AppendLine(pTemp.Value?.ToString());

                    pTemp = pTemp.pNext;
                }

                return sb.ToString();
            }
        }

        public void DisplayInfo()
        {
            Console.WriteLine(this.ToString());
        }
    }
}
