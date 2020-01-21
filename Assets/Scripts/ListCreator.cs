using UnityEngine;

public class ListCreator : MonoBehaviour
{
    [SerializeField] private GameObject _target;

    private IDataProvider _dataProvider;
    private IDynamicList _list;

    private void Construct()
    {
        _dataProvider = GetComponent<IDataProvider>();
        if (_dataProvider == null)
        {
            Debug.LogError("Missing component: IDataProvider", gameObject);
        }

        _list = _target.GetComponent<IDynamicList>();
        if (_list == null)
        {
            Debug.LogError("Missing component: IDynamicList", _target);
        }
    }

    private void OnEnable()
    {
        Construct();
    }

    public void AddAll()
    {
        var data = _dataProvider.LoadData();
        _list.AddEntry(data);
    }

    public void AddSingle()
    {
        var data = _dataProvider.LoadData();
        _list.AddEntry(data[Random.Range(0, data.Length)]);
    }

    public void Clear()
    {
        _list.Clear();
    }
}
