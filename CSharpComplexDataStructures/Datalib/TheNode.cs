using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpComplexDataStructures.Datalib
{
    class TheNode <T>
    {

        public T Value { get; set; }
        public TheNode<T> NextNode { get; set; }
        public TheNode<T> PreviousNode { get; set; }

        public TheNode(T item)
        {
            this.Value = item;

        }

    }
}
