using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ÖdevMyList
{
    internal class MyDictionary<TKey,TValue>
    {
        public TKey[] keys;
        public TValue[] values;
        public int Length = 0;

        public MyDictionary() 
        {
            keys = new TKey[0];
            values = new TValue[0];
            Length = 0;
        }

        public void Add(TKey key, TValue value)      
        { 
            TKey[] tempKeys = new TKey[keys.Length+1];
            TValue[] tempValues = new TValue[keys.Length+1];

            for (int i = 0; i < tempKeys.Length; i++) 
            {
                tempKeys[i] = keys[i];
                tempValues[i] = values[i];           
            } 
        
        
        
        }


    }
}
