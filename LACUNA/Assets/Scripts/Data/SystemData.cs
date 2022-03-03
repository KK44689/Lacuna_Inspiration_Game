using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class SystemData : ScriptableObject
{
    //sound
    public float main_volume = -20f;

    //master same as main_volume

    public float audio_music = -10f;
    public float audio_VFX = -10f;


    //fullscreen
    public bool fullscreen = true;

    //resolution
    public int index_resolution = 0;
    public int current_widths = 1920;
    public int current_heights = 1080;
}
