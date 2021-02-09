using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class HealthChanger : MonoBehaviour
{
    [SerializeField] private Slider _slider;
    [SerializeField] private int _healthQuantity;
    [SerializeField] private float _duration;

    public void Heal()
    {
        _slider.DOValue(_slider.value + _healthQuantity, _duration).SetEase(Ease.Linear);
    }

    public void Damage()
    {
        _slider.DOValue(_slider.value - _healthQuantity, _duration).SetEase(Ease.Linear);
    }
}
