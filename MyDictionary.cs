using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyStudents<K,V>
    {
        K[] _keys;
        V[] _values;

        public MyStudents()
        {
            _keys = new K[0];
            _values = new V[0];
        }

        public void Add(K sNumber,V sNameSurname)
        {
            K[] tempKeys = _keys;
            V[] tempValues = _values;

            _keys = new K[_keys.Length + 1];
            _values = new V[_values.Length + 1];

            for (int i = 0; i < tempKeys.Length; i++)
            {
                _keys[i] = tempKeys[i];
                _values[i] = tempValues[i];
            }

            _keys[_keys.Length - 1] = sNumber;
            _values[_values.Length - 1] = sNameSurname;
        }

        public int Count
        {
            get { return _values.Length; }
        }

        public void AddedStudents()
        {
            for(int i=0; i<_keys.Length; i++)
            {
                Console.WriteLine(_keys[i]+" : "+_values[i]+"\n..................................");
            }
        }
    }
}
