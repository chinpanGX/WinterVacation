using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound : MonoBehaviour
{
    public AudioClip[] audio;
    private AudioSource audioSource;
    // Start is called before the first frame update
    void Awake()
    {
        audioSource = gameObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
   public void PlaySelectSE()
    {
        audioSource.PlayOneShot(audio[0]);
    }

    public void PlayBattingSE()
    {
        audioSource.PlayOneShot(audio[1]);
    }

    public void PlayExplosionSE()
    {
        audioSource.PlayOneShot(audio[2]);
    }

    public void PlayBGM()
    {
        audioSource.PlayOneShot(audio[3]);
    }
}
