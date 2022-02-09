using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundLoop : MonoBehaviour
{
    public AudioSource musicSrc;
    public AudioClip musicStart;
    // Start is called before the first frame update
    void Start()
    {
        musicSrc.PlayOneShot(musicStart);
        musicSrc.PlayScheduled(AudioSettings.dspTime + musicStart.length);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
