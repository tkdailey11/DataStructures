using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class DoublyLinkedList<T>
    {
        private int _size;
        private Node _root;
        private Node _tail;

        public int size
        {
            get
            {
                return _size;
            }
        }


        public DoublyLinkedList()
        {
            _size = 0;
            _root = null;
            _tail = null;
        }


        public void addLast(T el)
        {
            Node newTail = new Node(el);

            if (this.size == 0)
            {
                this._root = newTail;
                this._tail = newTail;
            }
            else
            {
                newTail.previous = this._tail;

                this._tail.next = newTail;

                this._tail = newTail;
            }

            this._size++;
        }


        public void addFirst(T el)
        {
            Node newRoot = new Node(el);

            if(this.size == 0)
            {
                this._root = newRoot;
                this._tail = newRoot;
            }
            else
            {
                newRoot.next = this._root;

                this._root.previous = newRoot;

                this._root = newRoot;
            }

            this._size++;
        }


        public void add(T el, int index)
        {
            if (index == 0)
            {
                addFirst(el);
                return;
            }
            else if (index == this.size)
            {
                addLast(el);
                return;
            }
            else if (index < 0 || index > this.size)
            {
                throw new Exception();
            }

            Node currNode;
            if (index > this.size / 2)
            {
                currNode = this._tail;
                for (int i = 0; i < size - index - 1; i++)
                {
                    currNode = currNode.previous;
                }
            }
            else
            {

                currNode = this._root;
                for (int i = 0; i < index; i++)
                {
                    currNode = currNode.next;
                }
            }


            Node newNode = new Node(el);
            newNode.next = currNode;
            newNode.previous = currNode.previous;
            currNode.previous = newNode;
            newNode.previous.next = newNode;

            this._size++;
        }


        public T get(int index)
        {
            if (index < 0 || index > this.size || this.size == 0)
            {
                throw new Exception("Invalid Index");
            }

            if (index > this.size / 2)
            {
                Node currNode = this._tail;
                for(int i = 0; i < size - index - 1; i++)
                {
                    currNode = currNode.previous;
                }
                return currNode.value;
            }
            else
            {

                Node currNode = this._root;
                for (int i = 0; i < index; i++)
                {
                    currNode = currNode.next;
                }
                return currNode.value;
            }
        }


        public void removeFirst()
        {
            if (this.size <= 1)
            {
                this._root = null;
                this._tail = null;
                this._size = 0;
                return;
            }

            this._root = this._root.next;
            this._root.previous = null;
            this._size--;
        }


        public void removeLast()
        {
            if (this.size <= 1)
            {
                this._root = null;
                this._tail = null;
                this._size = 0;
                return;
            }

            this._tail = this._tail.previous;
            this._tail.next = null;
            this._size--;
        }


        public void removeAt(int index)
        {
            if (this.size <= 1)
            {
                this._root = null;
                this._tail = null;
                this._size = 0;
                return;
            }
            else if (index < 0 || index > this.size)
            {
                throw new Exception();
            }
            else if (index == this.size - 1)
            {
                removeLast();
                return;
            }

            Node currNode;
            if (index > this.size / 2)
            {
                currNode = this._tail;
                for (int i = 0; i < size - index - 1; i++)
                {
                    currNode = currNode.previous;
                }
            }
            else
            {

                currNode = this._root;
                for (int i = 0; i < index; i++)
                {
                    currNode = currNode.next;
                }
            }

            currNode.previous.next = currNode.next;
            currNode.next.previous = currNode.previous;
            currNode = null;

            this._size--;
        }



        class Node
        {
            private T _value;
            private Node _next;
            private Node _prev;

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

            public Node previous
            {
                get
                {
                    return this._prev;
                }

                set
                {
                    this._prev = value;
                }
            }

            internal Node(T el)
            {
                this._value = el;
                this._next = null;
                this._prev = null;
            }
        }
    }
}
