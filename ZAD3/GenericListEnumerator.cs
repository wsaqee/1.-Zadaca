using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZAD2;

namespace ZAD3
{
    public class GenericListEnumerator<T> : IEnumerator<T>
    {
        IGenericList<T> _collection;
        int index = 0;
        public GenericListEnumerator(IGenericList<T> collection)
        {
            _collection = collection;
        }
        public bool MoveNext()
        {
            if (index < _collection.Count)  return true;           
            return false;
            // Zove se prije svake iteracije.
            // Vratite true ako treba ući u iteraciju, false ako ne
            // Hint: čuvajte neko globalno stanje po kojem pratite gdje se
            // nalazimo u kolekciji
        }
        public T Current
        {
            get
            {
                return _collection.GetElement(index++);
                // Zove se na svakom ulasku u iteraciju
                // Hint: Koristite stanje postavljeno u MoveNext() dijelu
                // kako bi odredili što se zapravo vraća u ovom koraku
            }
        }

        object IEnumerator.Current { get { return Current; } }

        public void Dispose()
        {
            // Ignorirajte
        }
        public void Reset()
        {
            // Ignorirajte
        }
    }
}
