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
        public static void Dump<T>(this IBuffer<T> buffer)
        {
            foreach (var item in buffer)
            {
                Console.WriteLine(item);
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
        public static IEnumerable<S> AsEnumerableOf<T, S>(
            this IBuffer<T> buffer)
        {
            var converter = TypeDescriptor.GetConverter(typeof(T));
            foreach (var item in buffer)
            {
                S result = (S)converter.ConvertTo(item, typeof(S));
                yield return result;
            }
        }
    }
}
