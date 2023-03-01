
namespace Pattern_Adapter
{
    public interface DataStore
    {
         void SetData<T>(T data, string name);

        T Getdata<T>(string name);
    }
}


