using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Algorithms.LRU
{
    public class Node
    {
        public int key;
        public int data;

        public Node next;
        public Node prev;

        public Node(int key = 0, int data = 0)
        {
            this.key = key;
            this.data = data;
        }
    }

    public class LRU
    {
        int _capacity;
        Dictionary<int, Node> _map = new Dictionary<int, Node>();
        Node _tail = new Node();
        Node _head = new Node();

        public LRU(int capacity)
        {
            this._capacity = capacity;
            _head.next = _tail;
            _tail.prev = _head;
        }

        public int Get(int key)
        {
            if (!_map.ContainsKey(key)) return -1;
            var node = _map[key];
            Remove(node);
            Add(node);

            return node.data;
        }

        public void Put(int key, int vl)
        {
            if (_map.ContainsKey(key))
            {
                _map[key] = _map[key] ?? new Node(key, vl);
                _map[key].data = vl;
                var nd = _map[key];
                Remove(nd);
                Add(nd);
                return;
            }

            if (_map.Count == this._capacity)
            {
                _map.Remove(_tail.prev.key);
                Remove(_tail.prev);
            }

            var node = new Node(key, vl);
            Add(node);
            _map.Add(key, node);
        }

        void Add(Node node)
        {
            var current = _head.next;
            node.next = current;
            current.prev = node;
            node.prev = _head;
            _head.next = node;
        }

        void Remove(Node node)
        {
            var next = node.next;
            var prev = node.prev;
            prev.next = next;
            next.prev = prev;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var lru = new LRU(3);
                lru.Put(1, 1);
                lru.Put(2, 2);
                lru.Put(3, 3);
                lru.Put(4, 4);
                Assert.IsTrue(-1 == lru.Get(1));
                Assert.IsTrue(2 == lru.Get(2));
                lru.Put(5, 5);
                Assert.IsTrue(-1 == lru.Get(3));
                Console.WriteLine("TESTS ARE PASSED");
            }
            catch (Exception)
            {
                Console.WriteLine("TESTS ARE FAILED");
            }
        }
    }
}
