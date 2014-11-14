using System;
using System.Collections.Generic;
namespace DataStructure
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    interface IBuffer<T> : IEnumerable<T>
    {
        bool IsEmpty { get; }
        T Read();
        void Write(T value);
        IEnumerable<TOutput> AsEnumerableOf<TOutput>();
    }
}
