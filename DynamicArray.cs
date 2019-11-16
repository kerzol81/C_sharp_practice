using System;


namespace Arrays
{
    class Array
    {
        int[] items;
        int counter;

        public Array(int lenght)
        {
            items = new int[lenght];
        }
        internal void Print()
        {
            for (int i = 0; i < counter; i++)
            {
                Console.WriteLine(items[i]);
            }
        }

        internal void Append(int item)
        {
            //resize if full
            if (items.Length == counter)
            {
                int[] temp = new int[counter * 2];
                for (int i = 0; i < counter; i++)
                {
                    temp[i] = items[i];
                }
                items = temp;
            }

            // add to the end, and increment
            items[counter] = item;
            counter++;

        }

        internal void Remove(int index)
        {
            // validate index
            if (index < 0 || index >= counter)
            {
                throw new ArgumentOutOfRangeException("no such index");
            }
            /*  
                10, 20, 30, 40, 50   if index is 1, then
                10, X, 30, 40, 50    count from index until the end
                10, 30, 40, 50       cut off the end
             */
            for (int i = index; i < counter; i++)
            {
                items[i] = items[i + 1];
            }
            counter--;
            

        }

        internal int IndexOf(int item)
        {
            for (int i = 0; i < counter; i++)
            {
                if (items[i] == item)
                {
                    return i;
                }
            }
            // if it wasnt found
            return -1;
        }

        internal int MaxItem()
        {
            int max = items[0];
            for (int i = 1; i < counter; i++)
            {
                if (items[i] > max)
                {
                    max = items[i];
                }
            }
            return max;
             
        }
        internal int MinItem()
        {
            int min = items[0];
            for (int i = 1; i < counter; i++)
            {
                if (items[i] < min)
                {
                    min = items[i];
                }
            }
            return min;
        }

        internal void Intersect(Array other)
        {
            // Runtime complexity: O(n * n)
            Array commons = new Array(counter);
            for (int i = 0; i < counter; i++)
            {
                for (int j = 0; j < other.counter; j++)
                {
                    if (items[i] == other.items[j])
                    {
                        commons.Append(items[i]);
                    }
                }
            }
            for (int i = 0; i < commons.counter; i++)
            {
                Console.WriteLine(commons.items[i]);
            }
        }
    }
}
