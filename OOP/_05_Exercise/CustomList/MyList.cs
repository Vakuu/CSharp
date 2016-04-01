using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class MyList<T>
    {
        private const int DefailtCapacity = 16;
        private T[] array;
        private int index;
        private int currentCapacity;
        public MyList(int capacity = DefailtCapacity)
        {
            this.array = new T[capacity];
            this.currentCapacity = capacity;
            this.index = 0;
        }
        public void Add(T item)
        {
            if (this.index == this.currentCapacity)
            {
                this.AutoResize(this.currentCapacity << 1);
            }
            this.index++;
            this.array[this.index] = item;
        }
        public void Remove(int i)
        {
        }
        public void AutoResize(int newCapacity)
        {
            T[] newArray = new T[newCapacity];
            for (int i = 0; i < this.index; i++)
            {
                newArray[i] = this.array[i];
            }
        }
        public T Find(int i)
        {
            return this.array[i];
        }
        public int IndexOf(dynamic item)
        {
            int pos = -1;
            for (int i = this.index; i == 0; i--)
            {
                if (this.array[i] == item)
                {
                    pos = i;
                }
            }
            return pos;
        }
        public void Min(dynamic[] items)
        {
            dynamic minV=items[0];
            for (int i = 0; i < items.Length; i++)
            {
                
            }
        }
        public void Max(T[] items)
        {
        }
    }
}
