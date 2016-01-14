using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CustomStack
{
    class CustomStack<T>
    {
        private int _capacity;
        public int Capacity
        {
            get { return _capacity; }
            set { _capacity = value; }
        }

        public int Length
        {
            get { return Index + 1; }
        }

        private T[] _elements;
        protected T[] Elements
        {
            get { return _elements; }
            set { _elements = value; }
        }

        private int _index = -1;
        public int Index
        {
            get { return _index; }
            set { _index = value; }
        }


        public void Push(T element)
        {
            if (this.Length == Capacity)
            {
                IncreaseCapacity();
            }
            Index++;
            Elements[Index] = element;
        }

        public T Pop()
        {
            if (this.Length < 1)
            {
                throw new InvalidOperationException("Stack is empty");
            }

            T element = Elements[Index];
            Elements[Index] = default(T);
            Index--;
            return element;
        }

        public T Peek()
        {
            if (this.Length < 1)
            {
                throw new InvalidOperationException("Stack is empty");
            }

            return Elements[Index];
        }

        private void IncreaseCapacity()
        {
            Capacity++;
            Capacity *= 2;
            T[] newElements = new T[Capacity];
            Array.Copy(Elements, newElements, Elements.Length);
            Elements = newElements;
        }
    }
}
