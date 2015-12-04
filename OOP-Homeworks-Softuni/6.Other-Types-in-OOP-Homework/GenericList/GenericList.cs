using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericList
{
    public class GenericList<T>
        where T : IComparable<T>
    {
        private const int DefaultCapacity = 16;
        private T[] genericList;
        private int count;

        //constructor
        public GenericList(int capacity = DefaultCapacity)
        {
            this.genericList = new T[capacity];
            this.count = 0;
        }

        //property
        public int Count
        {
            get
            {
                return this.count;
            }
        }

        //methods
        public void Add(T element)
        {
            if (this.count >= this.genericList.Length)
            {
               Resize();
            }
            this.genericList[this.count] = element;
            this.count++;
        }
        //HACK
        private void Resize()
        {
            T[] newElements = new T[this.genericList.Length * 2];
            for (int i = 0; i < this.genericList.Length; i++)
            {
                newElements[i] = this.genericList[i];
            }
            this.genericList = newElements;
        }

        public T Access(int index)
        {
            if (index > genericList.Length || index < 0)
            {
                throw new IndexOutOfRangeException("The index was out of range");
            }
            return this.genericList[index];
        }

        public void Remove(int index)
        {
            if (index > genericList.Length || index < 0)
            {
                throw new IndexOutOfRangeException("The index was out of range");
            }

            this.genericList[index] = default(T);
        }

        public void Insert(int index, T element)
        {
            if (index > genericList.Length || index < 0)
            {
                throw new IndexOutOfRangeException("The index was out of range");
            }

            this.genericList[index] = element;
        }

        public void Clear()
        {
            this.genericList =new T[DefaultCapacity];
        }

        public int IndexOf(T element)
        {
            if (genericList.Contains(element))
            {
                for (int i = 0; i < genericList.Length; i++)
                {
                    if (genericList[i].Equals(element))
                    {
                        return i;
                    }
                }
            }
            throw new Exception("There is no such element");
        }

        public bool ContainsValue(T element)
        {
            if (genericList.Contains(element))
            {
                return true;
            }
            return false;
        }
        public T Min()
        {
            if (this.count == 0)
            {
                throw new InvalidOperationException("CustomList is empty");
            }

            T min = this.genericList[0];

            for (int i = 1; i < this.count; i++)
            {
                T currentElement = this.genericList[i];
                if (currentElement.CompareTo(min) < 0)
                {
                    min = currentElement;
                }
            }
            return min;
        }
        public T Max()
        {
            if (this.count == 0)
            {
                throw new InvalidOperationException("CustomList is empty");
            }

            T max = this.genericList[0];

            for (int i = 1; i < this.count; i++)
            {
                T currentElement = this.genericList[i];
                if (currentElement.CompareTo(max) >= 0)
                {
                    max = currentElement;
                }
            }
            return max;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var x in genericList)
            {
                sb.Append(x.ToString() + ", ");
            }
            return sb.ToString().Substring(0,sb.Length-2);
        }
    }

}
