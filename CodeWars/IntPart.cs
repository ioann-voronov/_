using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    public class Partition
    {
        private readonly int[] _partition;

        public Partition(int a)
        {
            _partition = new[] { a };
        }

        public Partition(int[] parts)
        {
            _partition = parts;
        }

        public static Partition[] operator *(Partition[] p1, Partition p2)
        {
            return new Partition[] {};
        }

        public override bool Equals(object obj)
        {
            Partition that = obj as Partition;
            int length = _partition.Length;
            if (length != that._partition.Length)
                return false;

            Array.Sort(this._partition);
            Array.Sort(that._partition);
            for (int i = 0; i < length; i++)
            {
                if (_partition[i] != that._partition[i])
                {
                    return false;
                }
            }
            return true;
        }

        public override int GetHashCode()
        {
            return _partition.Sum();
        }
    }

    public class PartDictionary
    {
        private IDictionary<int, ISet<Partition>> _dictionary 
            = new Dictionary<int, ISet<Partition>>();

        // should return value for client, not set, string
        public ISet<Partition> this[int n]
        {
            get
            {
                return _dictionary[n];
            }

        }

    }


    public class IntPart
    {

        public void Part(long n)
        {
            Node root = new Node(5);

        }

        public static Tree ConstructTree(int n)
        {
            Node root = new Node(n);
            Node node = root;
            for (int i = 1; i < n; i++)
            {
                Node left = new Node(1);
                Node right = new Node(n-i);
                node.AddChild(left, right);
                node = right;
            }
            
            return new Tree(root);
        }



        
    }
}