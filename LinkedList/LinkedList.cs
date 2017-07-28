using System;

namespace LinkedList
{
    /**
    * 
    * @author Your Name here
    *
    */
    public class LinkedList<T> : IList<T>
    {
        private Node<T> head, tail;

        public int Count
        {
            get;
        }

        public LinkedList()
        {
            this.Count = 0;
            this.head = null;
            this.tail = null;
        }






        public void Add(T item, int index)
        {
            // TODO Auto-generated method stub

        }


        public T Get(int index)
        {
            // TODO Auto-generated method stub
            return default(T);
        }


        public int IndexOf(T item)
        {
            // TODO Auto-generated method stub
            return 0;
        }


        public T Remove(int index)
        {
            // TODO Auto-generated method stub
            return default(T);
        }

        /**
         * @return the first item in this linked list
         * @throws InvalidOperationException
         *             if this linked list is empty
         */
        public T GetFirst()
        {
            // TODO method stub
            return default(T);
        }

        /**
         * @return the last item in this linked list
         * @throws InvalidOperationException
         *             if this linked list is empty
         */
        public T GetLast()
        {
            // TODO method stub
            return default(T);
        }

        /**
         * Adds 'item' to front of this linked list
         * 
         * @param item
         */
        public void AddFirst(T item)
        {
            // TODO method stub

        }

        /**
         * Adds 'item' to the end of this linked list
         * 
         * @param item
         */
        public void AddLast(T item)
        {
            // TODO method stub

        }

        /**
         * Removes and returns the first item from this linked list
         * 
         * @return
         * @throws InvalidOperationException
         *             if this linked list is empty
         */
        public T RemoveFirst()
        {
            // TODO method stub
            return default(T);
        }

        /**
         * Removes and returns the last item from this linked list
         * 
         * @return
         * @throws InvalidOperationException
         *             if this linked list is empty
         */
        public T RemoveLast()
        {
            // TODO method stub
            return default(T);
        }

        /**
         * Gets the node pointed to by head, if this doesn't exist return null
         * 
         * @return Node pointed to by head or null
         */
        public Node<T> GetHead()
        {
            return null;
        }

        /**
         * Replace the current linked list with the linked list where 'head' is it's head. 
         * 
         * *HINT* You are replacing your current linked list with the linked list
         *  where the variable 'head' is the head. This is not the same as adding head to the front
         *  of the linked list. Think about which variables in your LinkedList you have to change
         *  when you replace the current LinkedList with another one.
         *  
         */
        public void ReplaceUsingHead(Node<T> head)
        {

        }

        /**
         * Gets the node pointed to by tail, if this doesn't exist return null
         * 
         * @return Node pointed to by tail or null
         */
        public Node<T> GetTail()
        {
            return null;
        }

        /**
         * Replace the current linked list with the linked list where 'tail' is it's tail. 
         * 
         * *HINT* You are replacing your current linked list with the linked list
         *  where the variable 'tail' is the tail. This is not the same as adding tail to the end
         *  of the linked list.Think about which variables in your LinkedList you have to change
         *  when you replace the current LinkedList with another one.
         */
        public void ReplaceUsingTail(Node<T> tail)
        {

        }


        /**
        * Returns the number of elements within the LinkedList
        * May be useful for setting Count property.
        */
        private int GetCount()
        {
            return 0;
        }
    }


}
