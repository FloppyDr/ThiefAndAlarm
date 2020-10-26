using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Siren : MonoBehaviour
{
    [SerializeField] private AudioSource _audio;

    public void TurnOffSiren()
    {
        StopAllCoroutines();
        StartCoroutine(FadeIn());
    }

    public void TurnOnSiren()
    {
        StopAllCoroutines();
        StartCoroutine(FadeOut());
    }

    private IEnumerator FadeOut()
    {
        var delay = new WaitForSeconds(0.005f);
        
            while (_audio.volume < 0.9)
            {
                _audio.volume = Mathf.Lerp(_audio.volume, 1, Time.deltaTime);
                yield return delay;
            }
            _audio.volume = 1;
    }

    private IEnumerator FadeIn()
    {
        var delay = new WaitForSeconds(0.005f);

        while (_audio.volume > 0.01)
        {
            _audio.volume = Mathf.Lerp(_audio.volume, 0, Time.deltaTime);
            yield return delay;
        }
        _audio.volume = 0;

    }
}
