using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorSetter : MonoBehaviour
{
    [SerializeField] private SpriteRenderer _renderer;
    [SerializeField] private Color _alarmColor;
    [SerializeField] private Color _calmColor;

    private void Awake()
    {
        _renderer.color = _calmColor;
    }

    public void Alarm()
    {
        _renderer.color = _alarmColor;
    }

    public void Calm()
    {
        _renderer.color = _calmColor;
    }
}
