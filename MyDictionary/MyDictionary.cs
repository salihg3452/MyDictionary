using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary<Tkey,Tvalue>
    {
        Tkey[] keys;
        Tvalue[] values;
        public MyDictionary()
        {
            keys = new Tkey[0];
            values = new Tvalue[0];
        }
        public void Add(Tkey key,Tvalue value)
        {
            Tkey[] tempKeys = keys;
            Tvalue[] tempValues = values;

            keys = new Tkey[keys.Length + 1];
            values = new Tvalue[values.Length + 1];
            
            for (int i = 0; i < tempKeys.Length; i++)
            {
                keys[i] = tempKeys[i];
            }
            keys[keys.Length - 1] = key;

            
            for (int i = 0; i < tempValues.Length; i++)
            {
                values[i] = tempValues[i];
            }
            values[values.Length - 1] = value;

        }
        public void ListShow()
        {
            for (int i = 0; i < keys.Length; i++)
            {
                Console.WriteLine(keys[i] + " = " + values[i]);
            }
        }
    }
}
