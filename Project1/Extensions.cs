using System;
using System.Collections.Generic;
using System.Linq;

namespace Project1
{
    public static class Extensions
    {
        public static int IndexOfFirstDot(this string input)
        {
            return input.IndexOf(".");
        }

        public static T Last<T>(this Queue<T> queue)
        {
            if (queue.Count > 0)
            {
                return queue[queue.Count - 1];
            }
            else
            {
                throw new InvalidOperationException("The queue is empty.");
            }
        }
    }
}
