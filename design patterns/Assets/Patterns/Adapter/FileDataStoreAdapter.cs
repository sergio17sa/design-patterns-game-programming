using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;


namespace Pattern_Adapter
{
    public class FileDataStoreAdapter : DataStore
    {

        public void SetData<T>(T data, string name)
        {
            var json = JsonUtility.ToJson(data);
            var path = Path.Combine(Application.dataPath, name);
            File.WriteAllText(path, json);
        }

        public T Getdata<T>(string name)
        {
            var path = Path.Combine(Application.dataPath, name);
            var json = File.ReadAllText(path);
            return JsonUtility.FromJson<T>(json);
        }
    }

}




