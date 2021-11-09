using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    [SerializeField]
    private Health _health;

    private void OnTriggerEnter(Collider other) 
    {
        if(other.CompareTag("BotWeapon"))
        {
            _health.IncreaseHp(-2);
        }        
    }
}
