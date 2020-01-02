using System;
using System.Collections.Generic;

namespace Stack_exercise
{
    sealed class Stack
    {
        private List<object> items;
        public Stack()
        {
            items = new List<object>();
        }
        public void Push(object any)
        {
            if (any == null)
                throw new InvalidOperationException("cannot add null object");
            items.Add(any);
        }
        public object Pop()
        {
            if (items.Count == 0)
                throw new InvalidOperationException("cannot pop from empty stack");
            var last = items[items.Count - 1];
            items.Remove(last);
            return last;
        }
        public void Clear()
        {
            if (items.Count == 0)
                throw new InvalidOperationException("an empty stack is useless clear");
            items.Clear();
        }
    }
}
