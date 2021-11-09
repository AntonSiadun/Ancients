using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int hp;

    [SerializeField]
    private HealthBar _healthBar;

    private void Awake()
    {
        _healthBar.health = hp;         
    }

    public void IncreaseHp(int value)
    {
        hp += value;
        _healthBar.IncreaseHealth(value);
        _healthBar.RefreshInfoAboutHealth();
    }


}
