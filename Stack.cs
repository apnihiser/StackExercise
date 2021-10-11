using System;
using System.Collections.Generic;

namespace SeactionFourStack
{
    class Stack
    {
        // Stack operates LIFO. Last object in the List will be the latest object added from push(), then the first to pop().
        // all items can be upcast to objects.
        // null shouldn't be added. instead cause InvalidOperationException
        // Pop method called on an empty stack should cause InvalidOperationException.
        // Clear will set _stack to end up with 0 elements.

        private readonly List<object> _stack = new List<object>();

        public void Push(object obj)
        {
            if (obj == null)
                throw new InvalidOperationException("Null values cannot be added to stack.");

            this._stack.Add(obj);
        }

        public object Pop()
        {
            if (_stack.Count == 0)
                throw new InvalidOperationException("Stack empty, nothing to remove.");

            var lastElement = this._stack[_stack.Count - 1];
            _stack.Remove(this._stack[_stack.Count - 1]);
            return lastElement;
        }

        public string ReadStack()
        {
            var msg = new List<string>();

            foreach(object obj in this._stack)
            {
                msg.Add(obj.ToString());
            }

            return String.Join(", ", msg.ToArray());
        }

        public int StackLength()
        {
            return _stack.Count;
        }

        public void Clear()
        {
                this._stack.RemoveAll(obj => obj == obj);
        }
    }
}
