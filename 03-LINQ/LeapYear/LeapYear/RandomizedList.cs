using System;
using System.Collections.Generic;

namespace LeapYear
{
    public class RandomizedList<T>
    {
        private List<T> _list;
        private Random _random;

        public RandomizedList() {
            _list = new List<T>();
            _random = new Random();
        }

        public void Add(T element) {
            if (_random.Next(2) == 0) {
                _list.Insert(0, element);
            } else {
                _list.Add(element);
            }
        }

        public T Get(int index) {
            if (index < 0 || index >= _list.Count)
                throw new ArgumentOutOfRangeException();

            int randomIndex = _random.Next(index + 1);
            return _list[randomIndex];
        }

        public bool IsEmpty() {
            return _list.Count == 0;
        }

        public int Size() {
            return _list.Count;
        }
    }
}
