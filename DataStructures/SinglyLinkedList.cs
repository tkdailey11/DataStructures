using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class SinglyLinkedList<T>
    {
        private int _size;
        private Node _root;

        public int size
        {
            get
            {
                return _size;
            }
        }


        public SinglyLinkedList()
        {
            _size = 0;
            _root = null;
        }


        public void addLast(T el)
        {
            if(this._size == 0)
            {
                this._root = new Node(el);
                _size = 1;
            }
            else
            {
                Node currNode = this._root;
                while(currNode.next != null)
                {
                    currNode = currNode.next;
                }
                currNode.next = new Node(el);
                _size++;
            }
        }


        public void addFirst(T el)
        {
            Node newRoot = new Node(el);
            newRoot.next = this._root;
            this._root = newRoot;
            this._size++;
        }


        public void add(T el, int index)
        {
            if(index == 0)
            {
                addFirst(el);
                return;
            }
            else if(index == this.size)
            {
                addLast(el);
                return;
            }
            else if(index < 0 || index > this.size)
            {
                throw new Exception();
            }


            Node newNode = new Node(el);
            Node prevNode = this._root;

            for(int i = 0; i < index - 1; i++)
            {
                prevNode = prevNode.next;
            }

            newNode.next = prevNode.next;
            prevNode.next = newNode;
            this._size++;
        }


        public T get(int index)
        {
            if(index < 0 || index > this.size || this.size == 0)
            {
                throw new Exception("Invalid Index");
            }

            Node currNode = this._root;
            for (int i = 0; i < index; i++)
            {
                currNode = currNode.next;
            }
            return currNode.value;
        }


        public void removeFirst()
        {
            if(this.size <= 1)
            {
                this._root = null;
                this._size = 0;
                return;
            }

            this._root = this._root.next;
        }


        public void removeLast()
        {
            if (this.size <= 1)
            {
                this._root = null;
                this._size = 0;
                return;
            }

            Node currNode = this._root;
            for (int i = 0; i < this.size - 1; i++)
            {
                currNode = currNode.next;
            }

            currNode.next = null;
            this._size--;
        }


        public void removeAt(int index)
        {
            if (this.size <= 1)
            {
                this._root = null;
                this._size = 0;
                return;
            }
            else if(index < 0 || index > this.size)
            {
                throw new Exception();
            }

            Node currNode = this._root;
            for (int i = 0; i < index - 1; i++)
            {
                currNode = currNode.next;
            }

            currNode.next = currNode.next.next;
            this._size--;
        }
        


        class Node
        {
            private T _value;
            private Node _next;

            public T value
            {
                get
                {
                    return _value;
                }
            }

            public Node next
            {
                get
                {
                    return this._next;
                }

                set
                {
                    this._next = value;
                }
            }

            internal Node(T el)
            {
                this._value = el;
                this._next = null;
            }
        }
    }
}
