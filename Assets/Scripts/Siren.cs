﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Siren : MonoBehaviour
{
    [SerializeField] private AudioSource _audio;

    public void Play()
    {
        StartCoroutine(ChangeVolume());
    }

    private IEnumerator ChangeVolume()
    {
        int steps = 15;
        var delay = new WaitForSeconds(0.01f);

        if (_audio.volume == 0)
        {
            for (int i = 0; i < steps; i++)
            {
                _audio.volume = Mathf.Lerp(_audio.volume,1,i*Time.deltaTime);
                yield return delay;
            }

            _audio.volume = 1;

        }
        else if (_audio.volume == 1)
        {
            for (int i = 0; i < steps; i++)
            {
                _audio.volume = Mathf.Lerp(_audio.volume, 0, i * Time.deltaTime);
                yield return delay;
            }

            _audio.volume = 0;
        }
    }
}
