using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthController : MonoBehaviour
{
    [SerializeField]
    private float _currentHealth;

    [SerializeField]
    private float _maxHealth;

    public float RemainingHealthPercentage
    {
        get
        {
            return _currentHealth / _maxHealth;
        }
    }

    public void TakeDamage(float damageAmount)
    {
        if(_currentHealth == 0) 
        {
            return;
        }
        
        _currentHealth -= damageAmount;

        if(_currentHealth < 0)
        {
            _currentHealth = 0;
        }
    }

    public void AddHealth(float amountToAdd)
    {
        if ( _currentHealth == _maxHealth)
        {
            return;
        }

        _currentHealth += amountToAdd;

        if (_currentHealth > _maxHealth)
        {
            _currentHealth = _maxHealth;
        }
    }
}
