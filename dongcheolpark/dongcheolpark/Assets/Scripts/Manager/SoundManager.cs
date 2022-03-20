using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    private AudioSource Sounds;
    void Awake() {
        Sounds = GetComponent<AudioSource>();
    }

    public void BounceSound() {
        Sounds.clip = Resources.Load<AudioClip>("Audio/Bounce.wav");
        Sounds.Play();
    }

}
