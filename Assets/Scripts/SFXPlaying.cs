using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXPlaying : MonoBehaviour
{
    public AudioSource carStart;
    public AudioSource Tires;
    public void PlayCarStart()
    {
        carStart.Play();
    }

    public void PlayTires()
    {
        Tires.Play();
    }
}
