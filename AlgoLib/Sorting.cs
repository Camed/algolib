using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoLib
{
    public abstract class Sorting<T> where T : IComparable
    { 
        abstract public void Swap(ref Node<T> n, ref Node<T> m);
        abstract public Node<T>[] Sort(Node<T>[] nodes);
        abstract public Node<T>[] ReverseSort(Node<T>[] nodes);
    }

    public class BubbleSort<T> : Sorting<T> where T : IComparable
    {
        public override void Swap(ref Node<T> n, ref Node<T> m)
        {
            Node<T> temp = n;
            n = m;
            m = temp;
        }

        public override Node<T>[] Sort(Node<T>[] nodes)
        {
            for(int i = 0; i < nodes.Length; i++)
            {
                for(int j = 0; j < nodes.Length - i - 1; j++)
                {
                    if(nodes[j].CompareTo(nodes[j+1]) > 0)
                    {
                        Swap(ref nodes[j], ref nodes[j + 1]);
                    }
                }
            }
            return nodes;
        }

        public override Node<T>[] ReverseSort(Node<T>[] nodes)
        {
            Sort(nodes);
            Array.Reverse(nodes);
            return nodes;
        }
    }

    public class SelectionSort<T> : Sorting<T> where T: IComparable
    {
        public override void Swap(ref Node<T> n, ref Node<T> m)
        {
            Node<T> temp = n;
            n = m;
            m = temp;
        }
        public override Node<T>[] Sort(Node<T>[] nodes)
        {
            return nodes;
        }
        public override Node<T>[] ReverseSort(Node<T>[] nodes)
        {
            return nodes;
        }
    }
}
