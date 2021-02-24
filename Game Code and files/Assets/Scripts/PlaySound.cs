using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySound : MonoBehaviour
{

    public AudioSource sound1;
    public AudioSource sound2;
    public AudioSource sound3;
    public AudioSource sound4;
    public void Play()
    {
        sound1.Play();
    }
    public void Play2()
    {
        sound2.Play();
    }
    public void Play3()
    {
        sound3.Play();

    }
    public void Play4()
    {
        sound4.Play();
    }
}
