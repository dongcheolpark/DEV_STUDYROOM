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
        var _clip = Resources.Load<AudioClip>("Audio/Bounce");
        if(_clip != null) {
            Sounds.clip = _clip;
            Sounds.Play();
        }
    }

}
