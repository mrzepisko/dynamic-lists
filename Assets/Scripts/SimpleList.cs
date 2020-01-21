using System.Collections.Generic;
using UnityEngine;

public class SimpleList : MonoBehaviour, IDynamicList
{
    [SerializeField] private Entry _prototype;
    [SerializeField] private Transform _container;

    private readonly List<Entry> entries = new List<Entry>();

    private void Awake()
    {
        if (!_container)
        {
            _container = transform;
        }
    }

    public void AddEntry(Entry.Data[] data)
    {
        foreach (var entry in data)
        {
            AddEntry(entry);
        }
    }

    public void AddEntry(Entry.Data data)
    {
        var entryGO = Instantiate(_prototype, _container);
        entryGO.Configure(data);
        entries.Add(entryGO);
    }

    public void Clear()
    {
        foreach (var entry in entries)
        {
            Destroy(entry.gameObject);
        }
        entries.Clear();
    }
}