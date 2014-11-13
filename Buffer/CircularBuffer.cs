using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    class CircularBuffer<T> : Buffer<T>
    {
        private int _capacity;

        public CircularBuffer(int capacity = 10)
        {
            _capacity = capacity;
        }

        public override void Write(T value)
        {
            base.Write(value);
            if (_queue.Count > _capacity)
            {
                _queue.Dequeue();
            }
        }

        public bool IsFull 
        {
            get
            {
                return _queue.Count == _capacity;
            }
        }
    }
}
