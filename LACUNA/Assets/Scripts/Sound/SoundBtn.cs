using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundBtn : MonoBehaviour
{
    public AudioSource mybtn_sound;
    public AudioClip hoverbtn;
    public AudioClip clickbtn;

    public void HoverSound() {
        mybtn_sound.PlayOneShot(hoverbtn);
    }

    public void ClickSound() {
        mybtn_sound.PlayOneShot(clickbtn);
    }

}
