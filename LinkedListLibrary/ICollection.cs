using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListLibrary
{
    interface ICollection<T>
    {

        /**
        * Property that holds the number of items in this collection
        */
        int Count { get; }


        /**
        * Adds 'item' to this collection.
        * 
        * Adds to the end of this collection if the notion of end exists for the
        * concrete class
        * 
        * @param item
        */
        void Add(T item);

        /**
         * Clears this collection
         * 
         */
        void Clear();

        /**
         * @param item
         * @return true if this collection contains 'item', false otherwise
         */
        Boolean Contains(Object item);

        /**
         * @return true if this collection is empty, false otherwise
         */
        Boolean isEmpty();

        /**
         * Removes the first occurence 'item' from this collection, and returns what was removed
         * 
         * If 'item' does not exist in this collection, do not modify the
         * collection, and return null
         * 
         * Note that you must return the item removed from this collection, not the
         * parameter 'item'
         * 
         * @param item
         * @return
         */
        T Remove(Object item);


    }
}
