using System;

namespace DynamicArrayImplementation
{
    class Array
    {
        private int[] _items;
        private int _counter = 0;       // will be incremented when adding an item

        public Array(int lenght)
        {
            _items = new int[lenght];
        }

        public void RemoveAt(int index)
        {
            if (index <= _counter && index >= 0)
            {
                for (int i = index; i < _counter; i++)
                {
                    _items[i] = _items[i + 1];
                }
                _counter--;
            }
            else
                throw new ArgumentOutOfRangeException("No such index");
        }

        public void Print()
        {
            for (int i = 0; i < _counter; i++)
            {
                Console.WriteLine(_items[i]);
            }
        }

        public void Append(int item)
        {
            if (_counter == _items.Length)
            {
                int[] temp = new int[_counter * 2];

                for (int i = 0; i < _counter; i++)
                    temp[i] = _items[i];

                _items = temp;
            }
            _items[_counter++] = item;
        }
    }
}
