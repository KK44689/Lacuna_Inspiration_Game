using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static AudioClip playCollectItemSound, getInspirePieceSound;
    public static AudioClip WalkingCharSound;
    static AudioSource audioSrc;
    // Start is called before the first frame update
    void Start()
    {
        playCollectItemSound = Resources.Load<AudioClip>("items/receiveItem");
        getInspirePieceSound = Resources.Load<AudioClip>("items/getInspirePiece");

        WalkingCharSound = Resources.Load<AudioClip>("Char/walking");

        audioSrc = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void PlaySoundItem(string clip) {
        switch (clip) {
            case "receiveItem":
                audioSrc.PlayOneShot(playCollectItemSound);
                break;
            case "getInspire":
                audioSrc.PlayOneShot(getInspirePieceSound);
                break;
            case "walking":
                audioSrc.PlayOneShot(WalkingCharSound);
                break;
                //make it loop when transitions
        }
    }

    
}
