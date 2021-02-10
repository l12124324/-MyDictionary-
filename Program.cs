using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, int> ogrencino = new MyDictionary<string, int>();
            ogrencino.Add("Mert", 1235);
            ogrencino.Add("Celal", 1416);
            ogrencino.Add("Ali", 1414);
            ogrencino.Add("Murat", 1217);
            Console.WriteLine(ogrencino.Count);
        }
    }

    class MyDictionary<TKey, TValue>
    {

        TKey[] _keys;
        TKey[] tempKeys;

        TValue[] _values;
        TValue[] tempValues;

        public MyDictionary()
        {
            _keys = new TKey[0];
            _values = new TValue[0];

        }
        public void Add(TKey key, TValue value)
        {
            tempKeys = _keys;
            tempValues = _values;

            _keys = new TKey[_keys.Length + 1];
            _values = new TValue[_values.Length + 1];



        }

        public int Count
        {
            get { return (_keys.Length + _values.Length); }

        }


    }
}

