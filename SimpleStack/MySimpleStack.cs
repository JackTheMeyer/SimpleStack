using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleStack
{
    class MySimpleStack
    {
        private List<int> _stack;
        public MySimpleStack()
        {
            _stack = new List<int>();
        }

        public int Top => _stack.Last();

        public int Count => _stack.Count;

        public void Push(int value)
        {
            _stack.Add(value);
        }

        public void Pop()
        {
            _stack.Remove(_stack.Last());
        }

    }
}
