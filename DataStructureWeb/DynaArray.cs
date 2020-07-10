using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace DataStructureWeb
{
    public class DynaArray<T>
    {
        private T[] arr;
        private int len = 0;
        private int capacity = 0;

        public DynaArray():this(16) //if default constructor is called then its array length willbe 16 by cons chaining
        {
                
        }

        public DynaArray(int capacity)
        {
            if (capacity < 0)
            {
                throw new InvalidOperationException();
            }
            Initialize(capacity);
        }

        public int size { get { return this.len; } }

        public bool isEmpty { get { return this.size == 0 ? true : false; } }

        public T Get(int index)
        {
            return arr[index];
        }
        public void Set (int index,T element)
        {
            arr[index] = element;
        }

        private void Initialize(int count) 
        {
            this.capacity = count;
            arr = new T[this.capacity];
        }

        public void Clear()
        {
            Initialize(0);
            this.len = 0;
        }

        public void Add(T element)
        {
            if (this.len + 1 >= this.capacity)
            {
                if (capacity == 0)
                {
                    capacity = 1;
                }
                else
                {
                    capacity *= 2;
                }

                T[] new_arr = new T[capacity];
                for (int i = 0; i < len; i++)
                {
                    new_arr[i] = arr[i];
                }
                arr = new_arr;
            }
            arr[len++] = element;
        }

        public T RemoveAt(int index)
        {
            if(index>=len && index < 0)
            {
                throw new IndexOutOfRangeException();
            }
            T data = arr[index];
            T[] new_arr = new T[len - 1];
            for (int i = 0,j=0; i < len; i++,j++)
            {
                if (i == index)
                {
                    j--;
                }
                else
                {
                    new_arr[j] = arr[i];
                }

            }
            arr = new_arr;
            capacity = --len;
            return data;
        }

        public bool Remove(Object obj)
        {
            for (int i = 0; i < len; i++)
            {
                if (arr[i].Equals(obj))
                {
                    RemoveAt(i);
                    return true;
                }
                
            }
            return false;
        }

        public int indexOf(Object obj)
        {
            for (int i = 0; i < len; i++)
            {
                if (arr[i].Equals(obj))
                {
                    return i;
                }
            }
            return -1;
        }

        public bool Contains(Object obj)
        {
            return indexOf(obj) != -1;
        }

        public override string ToString()
        {
            if (len == 0)
            {
                return "[]";
            }
            else
            {
                StringBuilder sb = new StringBuilder(len).Append("[");
                for (int i = 0; i < len-1; i++)
                {
                    sb.Append(arr[i] + ", ");
                }
                return sb.Append(arr[len - 1] + "]").ToString();

               
            }
        }
    }
}
