using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NormalList
{
    internal class MyList<T>
    {
        private Node<T>? _pHead;
        private Node<T>? _pTail;
        private int _listSize;

        public T this[int index]
        {
            get
            {
                int stepCounter;

                if(index < _listSize)
                {
                    stepCounter = 0;

                    Node<T>? pTemp = _pHead;

                    if(pTemp != null)
                    {
                        while(pTemp.pNext != null && stepCounter < index)
                        {
                            pTemp = pTemp.pNext;

                            stepCounter++;
                        } 
                        return pTemp.Value;
                    }
                    else
                    {
                        throw new Exception("Список пуст");
                    }
                }

                else
                {
                    stepCounter = 0;

                    Node<T>? pTemp = _pTail;

                    if (pTemp != null)
                    {
                        while (pTemp.pPrev != null && stepCounter < index)
                        {
                            pTemp = pTemp.pPrev;

                            stepCounter++;
                        }
                        return pTemp.Value;
                    }
                    else
                    {
                        throw new Exception("Список пуст");
                    }
                }
            }
            set
            {
                int stepCounter;

                if (index < _listSize)
                {
                    stepCounter = 0;

                    Node<T>? pTemp = _pHead;

                    if (pTemp != null)
                    {
                        while (pTemp.pNext != null && stepCounter < index)
                        {
                            pTemp = pTemp.pNext;

                            stepCounter++;
                        }
                        pTemp.Value = value;
                    }
                    else
                    {
                        throw new Exception("Список пуст");
                    }
                }

                else
                {
                    Node<T>? pTemp = _pTail;

                    stepCounter = _listSize;

                    if (pTemp != null)
                    {
                        while (pTemp.pPrev != null && stepCounter > index)
                        {
                            pTemp = pTemp.pPrev;

                            stepCounter--;
                        }
                        pTemp.Value = value;
                    }
                    else
                    {
                        throw new Exception("Список пуст");
                    }
                }
            }
        }

        public MyList() 
        {
            _pHead = null;
            _pTail = null;
            _listSize = 0;
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

            _listSize++;

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

            _listSize++;
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

                _listSize--;

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

                _listSize--;

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
