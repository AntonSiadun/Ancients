using UnityEngine;
using DG.Tweening;

public class MovementSkillModule : MonoBehaviour
{
    [SerializeField]
    private Vector3 _destination;
    [SerializeField]
    private float _duration;

    public void Move()
    {
        Vector3 localForward = new Vector3 (transform.forward.x*_destination.x,
                                            transform.forward.y*_destination.y,
                                            transform.forward.z*_destination.z);
        Vector3 localDestination = transform.position + localForward;
        transform.DOMove(localDestination,_duration);
    }

}
