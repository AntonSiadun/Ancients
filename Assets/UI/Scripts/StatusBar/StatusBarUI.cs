using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(StatusPanelUI))]
public class StatusBarUI : MonoBehaviour
{
    private StatusPanelUI _statusPanel;

    private void Awake()
    {
        _statusPanel = GetComponent<StatusPanelUI>();
    }

    public void Add(GameObject statusPrefab)
    {
        var statusObject = InstantiateStatus(statusPrefab);
        Create(statusObject);
        Run(statusObject);
    }

    private GameObject InstantiateStatus(GameObject statusPrefab)
    {
        return Instantiate(statusPrefab, new Vector3(0f, 0f, 0f), Quaternion.identity, transform);
    }
    
    private void Create(GameObject statusObject)
    {
        _statusPanel.Create(statusObject);
    }

    private void Run(GameObject statusObject)
    {
        var status = statusObject.GetComponent<StatusUI>();
        StartCoroutine(RunCoroutine(status));
    }

    IEnumerator RunCoroutine(StatusUI status)
    {
        status.image.enabled = true;
        yield return new WaitForSeconds(status.duration);
        Remove(status);
        RefreshPanelObjectsPosition();
    }

    private void Remove(StatusUI status)
    {
        _statusPanel.Remove(status.gameObject);
        Destroy(status.gameObject);
    }

    private void RefreshPanelObjectsPosition()
    {
        _statusPanel.RefreshPosition();
    }
}
