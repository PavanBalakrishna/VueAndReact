using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Excersices
{
    class StackWIthQueues<T>
    {  // Two inbuilt queues
        public Queue<T> q1 = new Queue<T>();
        public Queue<T> q2 = new Queue<T>();

        // To maintain current number of
        // elements
        public int curr_size;

        public StackWIthQueues()
        {
            curr_size = 0;
        }

        public void push(T x)
        {
            curr_size++;

            // Push x first in empty q2
            q2.Enqueue(x);

            // Push all the remaining
            // elements in q1 to q2.
            while (q1.Count > 0)
            {
                q2.Enqueue(q1.Peek());
                q1.Dequeue();
            }

            // swap the names of two queues
            Queue<T> q = q1;
            q1 = q2;
            q2 = q;
        }

        public void pop()
        {

            // if no elements are there in q1
            if (q1.Count == 0)
                return;
            q1.Dequeue();
            curr_size--;
        }

        public T top()
        {
            if (q1.Count == 0)
                return default(T);
            return q1.Peek();
        }

        public int size()
        {
            return curr_size;
        }
    }
}
