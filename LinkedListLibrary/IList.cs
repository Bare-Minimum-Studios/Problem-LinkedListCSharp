
namespace LinkedListLibrary
{
    interface IList<T>
    {


        /**
        * Adds 'item' at the given index. Immediately after this get('index')
        * should return 'item', assuming 'index' was valid
        * 
        * @param item
        * @param index
        * @throws IndexOutOfBoundsException
        *             
        */
        void Add(T item, int index);

        /**
         * Gets the item at 'index'
         * 
         * @param index
         * @return
         * @throws IndexOutOfBoundsException
         *             
         */
        T Get(int index);

        /**
         * @param item
         * @return the index of 'item' in this list, -1 if 'item' does not exist in
         *         this list
         */
        int IndexOf(T item);

        /**
         * Removes and returns the item at 'index'
         * 
         * @param index
         * @return
         * @throws IndexOutOfBoundsException
         *             
         */
        T Remove(int index);
    }
}
