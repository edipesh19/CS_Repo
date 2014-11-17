using System;
using System.Collections.Generic;

namespace DataStructure
{
    public interface IBuffer<T> : IEnumerable<T>
    {
        bool IsEmpty { get; }
        T Read();
        void Write(T value);
    }
}
