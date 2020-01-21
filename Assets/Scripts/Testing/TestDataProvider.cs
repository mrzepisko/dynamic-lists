using UnityEngine;

public class TestDataProvider : MonoBehaviour, IDataProvider
{
    [SerializeField] private Entry.Data[] _data;

    public Entry.Data[] LoadData()
    {
        return _data;
    }
}
