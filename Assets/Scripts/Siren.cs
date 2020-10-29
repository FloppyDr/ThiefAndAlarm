using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Siren : MonoBehaviour
{
    [SerializeField] private AudioSource _audio;
    private int _minVolume = 0;
    private int _maxVolume = 1;
    private Coroutine _curretCoroutine;

    public void TurnOffSiren()
    {
        if (_curretCoroutine != null)
        {
            StopCoroutine(_curretCoroutine);
        }
        _curretCoroutine = StartCoroutine(ChangeVolume(_minVolume));
    }

    public void TurnOnSiren()
    {
        if (_curretCoroutine != null)
        {
            StopCoroutine(_curretCoroutine);
        }
        _curretCoroutine = StartCoroutine(ChangeVolume(_maxVolume));
    }

    private IEnumerator ChangeVolume(int targetVolume)
    {
        while (_audio.volume != targetVolume)
        {
            _audio.volume = Mathf.MoveTowards(_audio.volume, targetVolume, Time.deltaTime);
            yield return null;
        }
    }
}
