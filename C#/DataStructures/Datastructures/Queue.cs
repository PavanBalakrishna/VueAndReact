using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Datastructures
{
    public interface IQueue<T>
    {
        T Pop();
        void Push(T value);

        bool IsEmpty();
    }

    public class ArrayQueue<T>:IQueue<T>
    {
        private T[] internalArray = new T[0];

        public bool IsEmpty()
        {
            if (internalArray.Length == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public T Pop()
        {
            if (this.IsEmpty())
            {
                return default(T);
            }

            T firstElement = internalArray[0];

            for (int i = 0; i < internalArray.Length -1; i++)
            {
                internalArray[i] = internalArray[i+1];
            }

            //Reducing the length of the array
            Array.Resize<T>(ref internalArray, internalArray.Length - 1);

            return firstElement;


        }

        public void Push(T newValue)
        {
            T[] newArray = new T[internalArray.Length + 1];

            Array.Copy(internalArray, newArray, internalArray.Length);

            internalArray = newArray;

            internalArray[internalArray.Length - 1] = newValue;
        }



    }
}
