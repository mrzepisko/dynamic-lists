using UnityEngine;

public class CustomDataProvider : MonoBehaviour, IDataProvider
{
    public Entry.Data[] LoadData()
    {
        //your implementation
        return new Entry.Data[0];
    }
}
