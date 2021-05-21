using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    public class MystaysLinkedList<T> where T : IEquatable<T>
    {

        public MystaysLinkedList(MystaysLinkedItem<T> Head)
        {
            this.Head = Head;
            this.Size = 1;
        }
        public MystaysLinkedItem<T> Head { get; set; }
        public int Size { get; set; }


        public int GetSize()
        {
            return Size;
        }


      


        public MystaysLinkedItem<T> AddFirst(T value)
        {
            if (this.Size==0)
            {
                Head = new MystaysLinkedItem<T>(value, null);
                this.Size = this.Size + 1;
                return Head;
            }
            else
            {
                MystaysLinkedItem<T> newFirst = new MystaysLinkedItem<T>(value, Head);
                Head = newFirst;
                this.Size = this.Size + 1;
                return newFirst;
            }
            
        }


        public MystaysLinkedItem<T> AddLast(T value)
        {
            MystaysLinkedItem<T> item = this.Head;

            while (item.Next != null)
            {
                item = item.Next;
            }

            MystaysLinkedItem<T> lastItem = new MystaysLinkedItem<T>(value);
            item.Next = lastItem;
            return lastItem;
        }


        public MystaysLinkedItem<T> InsertAfter(T value, MystaysLinkedItem<T> insertItem)
        {
            MystaysLinkedItem<T> item = this.Head;

            while (item != null)
            {
                //Check if value of current iteration is same as insert value
                if (EqualityComparer<T>.Default.Equals(insertItem.Value, item.Value))
                {
                    var oldNext = item.Next;

                    var newItem = new MystaysLinkedItem<T>(value, oldNext);

                    item.Next = newItem;

                    this.Size = this.Size + 1;

                    return newItem;
                }
                else
                {
                    item = item.Next;
                }
            }

            return null;
        }

        public MystaysLinkedItem<T> InsertBefore(T value, MystaysLinkedItem<T> insertItem)
        {
            MystaysLinkedItem<T> item = this.Head;
            MystaysLinkedItem<T> previousitem = null;

            while (item != null)
            {
                //Check if value of current iteration is same as insert value
                if (EqualityComparer<T>.Default.Equals(insertItem.Value, item.Value))
                {
                    var newItem= new MystaysLinkedItem<T>(value, item);

                    if (previousitem != null)
                    {
                        previousitem.Next = newItem;
                    }
                    else
                    {
                        AddFirst(value);
                    }
                    

                    this.Size = this.Size + 1;

                    return newItem;
                }
                else
                {
                    previousitem = item;
                    item = item.Next;
                }
            }

            return null;
        }
    }

    //Internal item class
    public class MystaysLinkedItem<T> where T : IEquatable<T>
    {
        public MystaysLinkedItem(T value)
        {
            this.Value = value;
        }

        internal MystaysLinkedItem(T val, MystaysLinkedItem<T> nextItem)
        {
            Value = val;
            Next = nextItem;
        }
        public T Value { get; set; }
        public MystaysLinkedItem<T> Next { get; set; }

    }



}
