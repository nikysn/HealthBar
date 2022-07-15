using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;


public class Player : MonoBehaviour
{
    private float _currentHealth = 0.52f;
    private float _maxHealth = 1f;
    private float _minHealth = 0;

    public event Action <float> HealthChanged;

    public void ChangeHealth(float value)
    {
        _currentHealth = Mathf.Clamp(_currentHealth + value, _minHealth, _maxHealth);
        HealthChanged?.Invoke(_currentHealth);
    }
}
