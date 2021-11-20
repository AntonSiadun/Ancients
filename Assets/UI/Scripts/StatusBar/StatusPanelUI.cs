using System.Collections.Generic;
using UnityEngine;

public class StatusPanelUI : MonoBehaviour
{
    [SerializeField]
    private List<GameObject> _repository = new List<GameObject>();
    [SerializeField]
    private float width = 120f;

    public void Create(GameObject statusObject)
    {
        Add(statusObject);
        RefreshPosition();
    }

    public void Add(GameObject statusObject)
    {
        _repository.Add(statusObject);
    }

    public void RefreshPosition()
    {
        for (int i = 0; i < _repository.Count; i++)
            _repository[i].GetComponent<StatusUI>().SetPosition(i * width, 0f);
    }

    public void Remove(GameObject statusObject)
    {
        _repository.Remove(statusObject);
    }
}
