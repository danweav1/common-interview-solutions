using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InterviewStuff
{
    // --- Directions
    // 1) Create a node class.  The constructor
    // should accept an argument that gets assigned
    // to the data property and initialize an
    // empty array for storing children. The node
    // class should have methods 'add' and 'remove'.
    // 2) Create a tree class. The tree constructor
    // should initialize a 'root' property to null.
    // 3) Implement 'traverseBF' and 'traverseDF'
    // on the tree class.  Each method should accept a
    // function that gets called with each element in the tree
    public class Tree
    {
        public Node Root;
        public Tree()
        {
            Root = null;
        }

        public void TraverseBF(Action<Node> fn)
        {
            List<Node> arr = new List<Node>() { Root };

            // while the list still has something in it
            while (arr.Count > 0)
            {
                Node node = arr[0];
                arr.RemoveAt(0); // take first element out of array

                arr.AddRange(node.Children);

                //// alternative solution instead of add range above
                //foreach (Node child in node.Children)
                //{
                //    arr.Add(child);
                //}

                fn(node);
            }
        }

        // Alternative
        public void TraverseBF2(Action<Node> fn)
        {
            if (Root == null)
            {
                return;
            }

            List<Node> q = new List<Node>();
            q.Insert(0, Root);
            while (q.Count > 0)
            {
                Node current = q.Last();
                q.Remove(q.Last());
                fn(current);
                foreach (Node node in current.Children)
                {
                    q.Insert(0, node);
                }
            }
        }

        public void TraverseDF(Action<Node> fn)
        {
            List<Node> arr = new List<Node>() { Root };

            // while the list still has something in it
            while (arr.Count > 0)
            {
                Node node = arr[0];
                arr.RemoveAt(0); // take first element out of array

                arr.InsertRange(0, node.Children); // add each child element to the front of the array
                fn(node);
            }
        }

        // Alternative
        public void TraverseDF2(Action<Node> fn, Node node = null)
        {
            if (node == null)
            {
                node = Root;
            }
            fn(node);
            if (node != null)
            {
                node.Children.ForEach((child) =>
                {
                    TraverseDF2(fn, child);
                });
            }

        }
    }

    public class Node
    {
        public object Data;
        public List<Node> Children;

        public Node(object _data)
        {
            Data = _data;
            Children = new List<Node>();
        }

        public void Add(object data)
        {
            Children.Add(new Node(data));
        }

        public void Remove(object data)
        {
            Children.RemoveAll(c => c.Data != data);// = Children.Where(c => c.Data != data).ToList();
        }
    }
}
