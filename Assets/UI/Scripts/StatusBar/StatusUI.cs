using UnityEngine;
using UnityEngine.UI;

public class StatusUI : MonoBehaviour
{
    public float duration;
    public Image image;

    private RectTransform _transform;

    private void Awake()
    {
        _transform = GetComponent<RectTransform>();
        image = GetComponent<Image>();
    }

    public void SetPosition(float x, float y)
    {
        _transform.localPosition = new Vector3(x, y, 0f);
    }

}
