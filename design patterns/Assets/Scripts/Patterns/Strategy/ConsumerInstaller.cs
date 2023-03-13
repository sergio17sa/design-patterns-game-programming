using System;
using System.Collections;
using System.Collections.Generic;
using Pattern_Adapter;
using UnityEngine;

namespace PatterStrategy
{
    public class ConsumerInstaller : MonoBehaviour
    {
        private void Awake()
        {
           Consumer _consumer = new Consumer(GetDataStore());
            _consumer.Save();
            _consumer.Load();
        }

        private DataStore GetDataStore()
        {
            bool isEven = UnityEngine.Random.Range(0, 99) % 2 == 0;
            if (isEven)
            {
                return new FileDataStorePlayerPrefsAdapter();
            }

            return new FileDataStoreAdapter();
        }
    }
};
