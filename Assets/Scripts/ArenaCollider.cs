using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class ArenaCollider : MonoBehaviour
{
    private void OnCollisionEnter(Collision other) 
    {
        if(other.GetComponent<Collider>().tag != "ArenaCollider")
            return;
        StopTweening(this.gameObject);
        Debug.Log("Stop tweenning.");
    }

    private void StopTweening(GameObject target)
    {
        DOTween.Kill(target);
    }
}
