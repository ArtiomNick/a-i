using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson9
{
    class GenericCollection<T>
    {
        T[] Items;

        public GenericCollection(int size)
        {
            Items = new T[size];
        }

        public void SetItem(T item, int ind)
        {
            if (ind >= Items.Length)
            {
                throw new IndexOutOfRangeException("Index out of range");
            }

            Items[ind] = item;
        }

        public T GetItem(int ind)
        {
            if (ind >= Items.Length)
            {
                throw new IndexOutOfRangeException("Index out of range");
            }

            return Items[ind];
        }

        public void SwapItemsByIndex(int ind1, int ind2)
        {
            if (ind1 >= Items.Length)
            {
                throw new IndexOutOfRangeException("First index out of range");
            }
            else if(ind2 >= Items.Length)
            {
                throw new IndexOutOfRangeException("Second index out of range");
            }

            T temp;

            temp = Items[ind1];
            Items[ind1] = Items[ind2];
            Items[ind2] = temp;
        }

        public void SwapItemsByValue(T item1, T item2)
        {
            
            int ind1 = Array.IndexOf(Items, item1);
            int ind2 = Array.IndexOf(Items, item2);

            T temp;

            temp = Items[ind1];
            Items[ind1] = Items[ind2];
            Items[ind2] = temp;


        }




    }
}
