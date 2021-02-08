using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class HealthChanger : MonoBehaviour
{
    [SerializeField] private Slider _slider;

    public void Heal()
    {
        _slider.DOValue(_slider.value + 10, 0.5f).SetEase(Ease.Linear);
    }

    public void Damage()
    {
        _slider.DOValue(_slider.value - 10, 0.5f).SetEase(Ease.Linear);
    }
}
