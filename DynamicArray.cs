// Runtime complexity: O(n)

using System;

namespace Arrays
{
    class Array
    {
        private int[] items;
        private int counter;
        public Array(int lenght)
        {
            items = new int[lenght];
        }

        public void PrintArrayVertical()
        {
            for (int i = 0; i < counter; i++)
            {
                Console.WriteLine(items[i]);
            }
        }

        public void PrintArrayHorizontal()
        {
            for (int i = 0; i < counter; i++)
            {
                Console.Write(items[i]);
                Console.Write(' ');
            }
        }

        public void Append(int n)
        {

            // resize if the array is full
            if (counter == items.Length)
            {
                // size doubling
                int[] new_items = new int[counter + 1];

                // copy
                for (int i = 0; i < counter; i++)
                {
                    new_items[i] = items[i];
                }

                items = new_items;
            }
            // insert to the end
            items[counter] = n;
            counter++;
        }
        public void RemoveAt(int index)
        {
            // validate the index, make sure it is in valid range
            if (index < 0 || index >= counter)
            {
                throw new ArgumentOutOfRangeException("no such index");
            }
            // shift to the left
            for (int i = index; i < counter; i++)
            {
                items[i] = items[i + 1];
            }
            // remove last, counter represents the total number of items in the array, not the size of the array
            counter--;
        }
        public void InsertAt(int index, int item)
        {
            //validate the index
            if (index < 0 || index >= counter)
            {
                throw new ArgumentOutOfRangeException("index is out of range");
            }
            // fill a new list, longer list devided at the index
            int[] new_items = new int[counter + 1];
            new_items[index] = item;
            for (int i = 0; i < index; i++)
            {
                new_items[i] = items[i];
            }
            for (int i = index ; i < counter; i++)
            {
                new_items[i + 1] = items[i];
            }
            items = new_items;
            counter++;
        }
        public int IndexOf(int item) {
            for (int i = 0; i < counter; i++)
            {
                if (items[i] == item)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
