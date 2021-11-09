using System.Collections;
using UnityEngine;

public class VFXSkillModule : MonoBehaviour
{
    [SerializeField]
    private GameObject _effect;
    [SerializeField]
    private Transform _owner;
    [SerializeField]
    private float _delay = 0.5f;

    public void Run()
    {
        StartCoroutine(DelayInstantiation());
    }

    IEnumerator DelayInstantiation()
    {
        yield return new WaitForSeconds(_delay);
        Instantiate(_effect, _owner.position, Quaternion.identity);
    }
}
