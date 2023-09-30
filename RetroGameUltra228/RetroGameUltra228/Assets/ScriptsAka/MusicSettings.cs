using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicSettings : MonoBehaviour
{
    private AudioSource mus;
    void Start()
    {
        mus = GetComponent<AudioSource>();
    }

    public void MusOff()
    {
        mus.volume = 0f;
    }
    public void MusOn()
    {
        mus.volume = 1f;
    }
}
