using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Pattern_Adapter {
public class Consumer : MonoBehaviour
{
    // cree una instacia de la data
    // guarde esa data 
        private DataStore _fileDataStoreAdapter;

    private void Awake()
    {
        _fileDataStoreAdapter = new FileDataStorePlayerPrefsAdapter();
        Data myData = new Data("data1", "dato2");
        _fileDataStoreAdapter.SetData(myData, "Data To Storage prefs");
    }

    private void Start() {
        var data = _fileDataStoreAdapter.Getdata<Data>("Data To Storage prefs");
        Debug.Log(data.data1);
        Debug.Log(data.data2);
    }
}

};
