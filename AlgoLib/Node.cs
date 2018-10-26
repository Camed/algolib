using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoLib
{
    public class Node<T> where T : IComparable
    {
        public T Value { get; set; }
       
        public int CompareTo(Node<T> node)
        {
            return this.Value.CompareTo(node.Value);
        }

        public Node()
        {
            Value = default(T);
        }

        public Node(T x)
        {
            Value = x;
        }
    }
}
