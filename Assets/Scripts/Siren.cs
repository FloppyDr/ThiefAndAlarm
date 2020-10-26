using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Siren : MonoBehaviour
{
    [SerializeField] private AudioSource _audio;
    private int minVolume = 0;
    private int maxVolume = 1;
    public void TurnOffSiren()
    {
        StopAllCoroutines();
        StartCoroutine(ChangeVolume(minVolume));
    }

    public void TurnOnSiren()
    {
        StopAllCoroutines();
        StartCoroutine(ChangeVolume(maxVolume));
    }

    private IEnumerator ChangeVolume(int targetVolume)
    {
        var delay = new WaitForSeconds(0.005f);
        while (true)
        {
            _audio.volume = Mathf.MoveTowards(_audio.volume, targetVolume, Time.deltaTime);
            yield return delay;
        }
    }
}
