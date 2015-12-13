using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using ZAD3;
namespace ZAD2
{
    public interface IGenericList<X> : IEnumerable<X>
    {
        /// <summary>
        /// Adds an item to the collection.
        /// </summary>
        void Add(X item);
        /// <summary>
        /// Removes the first occurrence of an item from the collection.
        /// If the item was not found, method does nothing.
        /// </summary>
        bool Remove(X item);
        /// <summary>
        /// Removes the item at the given index in the collection.
        /// </summary>
        bool RemoveAt(int index);
        /// <summary>
        /// Returns the item at the given index in the collection.
        /// </summary>
        X GetElement(int index);
        /// <summary>
        /// Returns the index of the item in the collection.
        /// If item is not found in the collection, method returns -1.
        /// </summary>
        int IndexOf(X item);
        /// <summary>
        /// Readonly property. Gets the number of items contained in the collection.
        /// </summary>
        int Count { get; }
        /// <summary>
        /// Removes all items from the collection.
        /// </summary>
        void Clear();
        /// <summary>
        /// Determines whether the collection contains a specific value.
        /// </summary>
        bool Contains(X item);
    }

    public class GenericList<X> : IGenericList<X>
    {
        private X[] _internalStorage;        private int _count = 0;
        public GenericList()
        {
            _internalStorage = new X[4];
        }

        public GenericList(int initialSize)
        {
            _internalStorage = new X[initialSize];
        }

        /// <summary>
        /// Adds an item to the collection.
        /// </summary>
        public void Add(X item)
        {
            if (_count >= _internalStorage.Length)
            {
                //Napravi novi duplo veci array
                Array.Resize<X>(ref _internalStorage, _count * 2);
            }
            _internalStorage[_count] = item;
            _count++;
        }
        /// <summary>
        /// Removes the first occurrence of an item from the collection.
        /// If the item was not found, method does nothing.
        /// </summary>
        public bool Remove(X item)
        {
            int index = IndexOf(item);
            if (index > 0) RemoveAt(index);

            return false;
        }
        /// <summary>
        /// Removes the item at the given index in the collection.
        /// </summary>
        public bool RemoveAt(int index)
        {
            if (index > (_count - 1))
            {
                //out of bounds
                return false;
            }
            //shift everything right of index 1 place left
            for (int i = index; i < _count - 1; i++)
            {
                _internalStorage[i] = _internalStorage[i + 1];
            }
            _count--;
            return true;
        }
        /// <summary>
        /// Returns the item at the given index in the collection.
        /// </summary>
        public X GetElement(int index)
        {
            if (index < _count)
            {
                return _internalStorage[index];
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        }
        /// <summary>
        /// Returns the index of the item in the collection.
        /// If item is not found in the collection, method returns -1.
        /// </summary>
        public int IndexOf(X item)
        {
            for (int i = 0; i < _count; i++)
            {
                if (_internalStorage[i].Equals(item))
                {
                    //item found - return index
                    return i;
                }
            }

            //item not found
            return -1;
        }
        /// <summary>
        /// Readonly property. Gets the number of items contained in the collection.
        /// </summary>
        public int Count
        {
            get
            {
                return _count;
            }
        }
        /// <summary>
        /// Removes all items from the collection.
        /// </summary>
        public void Clear()
        {
            _count = 0;
        }
        /// <summary>
        /// Determines whether the collection contains a specific value.
        /// </summary>
        public bool Contains(X item)
        {
            if (IndexOf(item) >= 0) return true;

            //item not found - return false
            return false;
        }

        public IEnumerator<X> GetEnumerator()
        {
            return new GenericListEnumerator<X>(this);
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

    }

}

