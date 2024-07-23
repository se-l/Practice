using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Practice
{
    /// <summary>
    /// Explain the differences between Memory<T> and Span<T> in C#. When would you use one over the other?
    /// Memory<T> represents a chunk of memory that can be read from and written to.Span<T> is a lightweight view of a portion of an array or memory.
    /// Use Memory<T> when you need a dynamically allocated memory block and Span<T> to work with a portion of an existing array or memory.
    /// 
    /// Lazy<T>
    /// 
    /// How does the volatile keyword work in C#? When and how should you use it?
    /// The volatile keyword is used to ensure that the value of a variable is always read from and written to the main memory, not from a cache.
    /// Use it when you have a variable shared between multiple threads and want to avoid potential visibility issues or stale values.
    /// </summary>
    internal class Memory
    {
    }
}
