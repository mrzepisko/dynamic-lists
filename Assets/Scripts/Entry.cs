using UnityEngine;
using UnityEngine.UI;

public class Entry : MonoBehaviour
{
    [System.Serializable]
    public class Data
    {
        public string name;
        public GameObject value;
    }

    [SerializeField] private Text _description;

    private Data data;

    public void Configure(Data data)
    {
        this.data = data; 
        _description.text = data.name;
    }
}
