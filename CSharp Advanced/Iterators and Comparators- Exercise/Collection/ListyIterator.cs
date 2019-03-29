﻿namespace Collection
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class ListyIterator<T> : IEnumerable<T>
    {
        private List<T> collection;
        private int internalIndex;

        public ListyIterator(params T[] elements)
        {
            this.collection = new List<T>(elements);
            this.internalIndex = 0;
        }

        public bool Move()
        {
            if (this.internalIndex + 1 < collection.Count)
            {
                this.internalIndex++;
                return true;
            }

            return false;
        }

        public bool HasNext()
        {
            if (this.internalIndex + 1 < collection.Count)
            {
                return true;
            }

            return false;
        }

        public void Print()
        {
            if (this.collection.Count == 0)
            {
                throw new ArgumentException("Invalid Operation!");
            }

            Console.WriteLine(this.collection[internalIndex]);
        }

        public void PrintAll()
        {
            Console.WriteLine(string.Join(' ', collection));
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (var element in collection)
            {
                yield return element;
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();
    }
}
