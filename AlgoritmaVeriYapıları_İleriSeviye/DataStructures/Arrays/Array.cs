﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Arrays
{
    //Tip Güvenliğini kaybetmek istemiyoruz <T> Generic yapıyoruz
    public class Array<T> : IEnumerable<T>, ICloneable
    {
        private T[] InnerList;

        public int Count { get; private set; }
        public int Capacity => InnerList.Length;

        public Array()
        {
            InnerList = new T[2];
            Count = 0;
        }
        public void Add(T item)
        {
            if (InnerList.Length == Count)
                DoubleArray();
            InnerList[Count] = item;
            Count++;
        }

        private void DoubleArray()
        {
            var temp = new T[InnerList.Length * 2];
            //for (int i = 0; i < InnerList.Length; i++)
            //{
            //    temp[i] = InnerList[i];
            //}

            System.Array.Copy(InnerList, temp, InnerList.Length);
            InnerList = temp;

        }

        public T Remove()
        {
            if (Count == 0)
                throw new Exception("There is no more item to be removed from the array.");
            if (InnerList.Length / 4 == Count)
            {
                HalfArray();
            }

            var temp = InnerList[Count - 1];
            if (Count>0)
            Count--;
            return temp;




        }

        private void HalfArray()
        {
            if (InnerList.Length > 2)
            {
                var temp = new T[InnerList.Length / 2];
                System.Array.Copy(InnerList, temp, temp.Length);
                //System.Array.Copy(InnerList, temp, InnerList.Length / 4);
                InnerList = temp;
            }
        }

        public object Clone()
        {
            throw new NotImplementedException();
        }

        public IEnumerator<T> GetEnumerator()
        {
            return InnerList.Take(Count).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
          return GetEnumerator();
        }
    }
}
