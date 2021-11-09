using UnityEngine;

public class VFXSkillModule : MonoBehaviour
{
    [SerializeField]
    private ParticleSystem _effect;

    public void Run()
    {
        _effect.Play();
    }
}
