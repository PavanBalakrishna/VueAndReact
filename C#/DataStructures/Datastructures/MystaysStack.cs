using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    public class MystaysStack<T> where T : IEquatable<T>
    {
        public MystaysStack()
        {
            InternalArray = new T[10];
        }
        public int Length { get {return this.InternalArray.Length ; }  }
        private T[] InternalArray { get; set; }


        //public T SearchIndex(int index)
        //{
        //    if (index > this.InternalArray.Length - 1)
        //    {
        //        throw new Exception("Out of bounds");
        //    }
        //    else
        //    {
        //        return this.InternalArray[index];
        //    }
        //}


        //public T Search(T searchValue)
        //{
        //    for (int i = 0; i <= this.InternalArray.Length -1 ; i++)
        //    {
        //        if (EqualityComparer<T>.Default.Equals(this.InternalArray[i], searchValue))
        //        {
        //            return InternalArray[i];
        //        }
        //    }

        //    return default(T);
        //}

        public bool Push(T pushElement)
        {
            if (!EqualityComparer<T>.Default.Equals(this.InternalArray[this.InternalArray.Length - 1], default(T)))
            {
                T[] newInternalArray = new T[this.InternalArray.Length * 2];

                this.InternalArray.CopyTo(newInternalArray, 0);

                this.InternalArray = newInternalArray;
            }

            for (int i = 0; i <= this.InternalArray.Length - 1; i++)
            {

                if (EqualityComparer<T>.Default.Equals(InternalArray[i], default(T)))
                {
                    InternalArray[i] = pushElement;

                    return true;
                }
            }

            return false;
        }

        public T Pop()
        {
            for (int i = this.InternalArray.Length - 1 ; i >= 0; i--)
            {

                if (!EqualityComparer<T>.Default.Equals(InternalArray[i], default(T)))
                {
                    T topElement = InternalArray[i];

                    InternalArray[i] = default(T);

                    return topElement;
                }
            }

            return default(T);
        }

        public void Clear()
        {
            for (int i = 0; i <= this.InternalArray.Length - 1; i++)
            {
                this.InternalArray[i] = default(T);
            }
        }

        public T Top()
        {
            if (InternalArray.Length > 0)
            {
                return InternalArray[InternalArray.Length - 1];
            }
            else
            {
                return default(T);
            }
            
        }
    }
}
