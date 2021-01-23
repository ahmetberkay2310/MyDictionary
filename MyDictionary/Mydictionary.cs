using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary<T>
    {
        T[] Markalar;
        public MyDictionary()
        {
            Markalar = new T[0];
        }

        public void Add (T marka)
        {
            T[] Keep = Markalar;
            Markalar = new T[Markalar.Length];
            for (int i = 0; i < Keep.Length; i++)

            {
                Markalar[i] = Keep[i];
            }
            Markalar[Markalar.Length - 1] = marka;


        }
    }
}
