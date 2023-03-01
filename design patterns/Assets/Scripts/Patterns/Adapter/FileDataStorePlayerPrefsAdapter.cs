using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Pattern_Adapter
{
    public class FileDataStorePlayerPrefsAdapter : DataStore
    {
        public void SetData<T>(T data, string name)
        {
            string json = JsonUtility.ToJson(data);
            PlayerPrefs.SetString(name, json);
            PlayerPrefs.Save();
        }

        public T Getdata<T>(string name)
        {
            string jsonString = PlayerPrefs.GetString(name);
            return JsonUtility.FromJson<T>(jsonString);
        }
    }
}


