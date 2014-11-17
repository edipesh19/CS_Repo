using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    /// <summary>
    /// This is the extension class of Buffer so the methods implemented here
    /// can also invoked using the Buffer class object.
    /// See the LINQ related examples for extension methods details
    /// </summary>
    public static class BufferExtensions
    {
        public static void Dump<T>(this IBuffer<T> buffer, Action<T> print)
        {
            foreach (var item in buffer)
            {
                print(item);
            }
        }
        
        /// <summary>
        /// Check the signature of extension method and it is used in Client.cs
        /// Return the collection items as S
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="S"></typeparam>
        /// <param name="buffer"></param>
        /// <returns></returns>
        public static IEnumerable<S> Map<T, S>(
            this IBuffer<T> buffer, Converter<T,S> converter)
        {
            return buffer.Select(i => converter(i));
        }
    }
}
