using System.Collections;
using System.Collections.Generic;
using Pattern_Adapter;
using UnityEngine;

namespace PatterStrategy
{
    class Consumer 
    {
        private readonly DataStore _dataStore;

        public Consumer(DataStore dataStore)
        {
            _dataStore = dataStore;
        }

        public void Save()
        {
            Data data = new Data("preba pattern", "Strategy");
            _dataStore.SetData(data, "data2");

        }

        public void Load()
        {
            Data _data = _dataStore.Getdata<Data>("data2");
            Debug.Log(_data.data1);
            Debug.Log(_data.data2);
        }
    }
}