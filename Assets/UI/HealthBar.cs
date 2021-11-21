using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    
    [SerializeField]
    public int health = 5;
    [SerializeField]
    private List<Image> _healthBarElements;
    [SerializeField]
    private Text _counter;

    private void Start() 
    {
        RefreshInfoAboutHealth();
    }

    public void RefreshInfoAboutHealth()
    {
        RefreshBar();
        RefreshCounter();
    }

    public void IncreaseHealth(int bonus)
    {
        health +=bonus;
        if(health <= 0) 
            health = 0;
        RefreshInfoAboutHealth();
    }



    private void RefreshBar()
    {
        int length = _healthBarElements.Count;
        for(int i=0; i<length;i++)
        {
            _healthBarElements[i].enabled = i < health;
        }
    }

    private void RefreshCounter()
    {
        _counter.text = health.ToString();
    }
}
