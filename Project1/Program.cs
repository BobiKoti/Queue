using System;

namespace Project1
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> queue1 = new Queue<int>();
            queue1 = queue1 + 5;
            queue1 = queue1 + 10;
            queue1 = queue1 + 3;

            Queue<int> queue2 = new Queue<int>();
            queue2 = queue2 + 8;
            queue2 = queue2 + 1;
            queue2 = queue2 + 7;

            Console.WriteLine("Queue 1: " + string.Join(", ", GetQueueItems(queue1)));
            Console.WriteLine("Queue 2: " + string.Join(", ", GetQueueItems(queue2)));

            var sortedQueue = queue1 < queue2;
            Console.WriteLine("Merged and sorted queue: " + string.Join(", ", GetQueueItems(sortedQueue)));

            Console.ReadLine();
        }

        static T[] GetQueueItems<T>(Queue<T> queue)
        {
            var items = new T[queue.Count];
            for (int i = 0; i < queue.Count; i++)
            {
                items[i] = queue[i];
            }
            return items;
        }
    }
}
