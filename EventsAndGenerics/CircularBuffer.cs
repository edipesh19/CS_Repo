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
        public event EventHandler<ItemDiscardedEventArgs<T>> ItemDiscarded;

        public CircularBuffer(int capacity = 10)
        {
            _capacity = capacity;
        }

        public override void Write(T value)
        {
            base.Write(value);
            if (_queue.Count > _capacity)
            {
                var oldValue = _queue.Dequeue();
                OnItemDiscard(oldValue, value);
            }
        }

        private void OnItemDiscard(T oldValue, T value)
        {
            if (ItemDiscarded != null)
            {
                ItemDiscardedEventArgs<T> evenArgs = new ItemDiscardedEventArgs<T>(oldValue, value);
                ItemDiscarded(this, evenArgs);
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

    class ItemDiscardedEventArgs<T> : EventArgs
    {
        public ItemDiscardedEventArgs(T _oldItem, T _newItem)
        {
            OldItem = _oldItem;
            NewItem = _newItem;
        }
        public T OldItem { get; set; }
        public T NewItem { get; set; }
    }
}
