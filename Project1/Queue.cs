using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Project1
{
    public class Queue<T>
    {
        private List<T> items = new List<T>();

        public int Count => items.Count;

        public Queue()
        {
        }

        public Queue(IEnumerable<T> collection)
        {
            items.AddRange(collection);
        }

        public T this[int index]
        {
            get => items[index];
            private set => items[index] = value;
        }

        public static Queue<T> operator +(Queue<T> queue, T item)
        {
            queue.Enqueue(item);
            return queue;
        }

        public static T operator -(Queue<T> queue)
        {
            return queue.Dequeue();
        }

        public static bool operator true(Queue<T> queue)
        {
            return queue.Count == 0;
        }

        public static bool operator false(Queue<T> queue)
        {
            return queue.Count != 0;
        }

        public static Queue<T> operator <(Queue<T> queue1, Queue<T> queue2)
        {
            var sortedQueue = new Queue<T>(queue1.items.Concat(queue2.items).OrderByDescending(item => item));
            return sortedQueue;
        }

        public static Queue<T> operator >(Queue<T> queue1, Queue<T> queue2)
        {
            var sortedQueue = new Queue<T>(queue1.items.Concat(queue2.items).OrderBy(item => item));
            return sortedQueue;
        }

        public static implicit operator int(Queue<T> queue)
        {
            return queue.Count;
        }

        public void Enqueue(T item)
        {
            items.Add(item);
        }

        public T Dequeue()
        {
            if (Count > 0)
            {
                T item = items[0];
                items.RemoveAt(0);
                return item;
            }
            else
            {
                throw new InvalidOperationException("The queue is empty.");
            }
        }
    }
}
