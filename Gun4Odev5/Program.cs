﻿using System;

namespace Gun4Odev5
{
    class MyDictionary<TKey, TValue>
    {
        TKey[] keys;
        TValue[] values;

        public MyDictionary()
        {
            keys = new TKey[0];
            values = new TValue[0];
        }

        public void Add(TKey key, TValue value)
        {
            TKey[] tempKey = keys;
            TValue[] tempValue = values;

            keys = new TKey[keys.Length + 1];
            values = new TValue[values.Length + 1];

            for (int i = 0; i < tempValue.Length; i++)
            {
                keys[i] = tempKey[i];
                values[i] = tempValue[i];
            }
            keys[keys.Length - 1] = key;
            values[values.Length - 1] = value;



        }
        public int CountOfKey
        {
            get { return keys.Length; }

        }
        public int CountOfValue
        {
            get { return values.Length; }

        }
    }
    


}
