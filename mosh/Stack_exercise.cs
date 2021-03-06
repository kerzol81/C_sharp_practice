using System;
using System.Collections.Generic;

namespace Stack_exercise
{
    sealed class Stack
    {
        private readonly List<object> items;
        public Stack()
        {
            items = new List<object>();
        }
        public void Push(object any)
        {
            if (any == null)
                throw new InvalidOperationException("cannot add null object to stack");
            items.Add(any);
        }
        public object Pop()
        {
            if (items.Count == 0)
                throw new InvalidOperationException("cannot pop from an empty stack");
            var last = items[items.Count - 1];
            items.Remove(last);
            return last;
        }
        public void Clear()
        {
            if (items.Count == 0)
                throw new InvalidOperationException("an empty stack is useless to be cleared");
            items.Clear();
        }
    }
}
