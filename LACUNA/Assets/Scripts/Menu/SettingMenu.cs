using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SettingMenu : MonoBehaviour
{
    //sound
    //public AudioSource audioSource;

    public AudioMixer audioMixer;


    public Slider volumeSlider;
    private float MusicVolume;

    ////sound change in sub volume
    /////mainmixer above asa master audiomixergroup

    public Slider music_Slider;
    public Slider VFX_Slider;
   
    private float music_volume;
    private float VFX_volume;

    ///
    ///


    //fullscreen
    private bool fullscreen;

    //resolution
    List<int> widths = new List<int>() { 1920, 1600, 1366, 1280 };
    List<int> heights = new List<int>() { 1080, 900, 768, 720 };

    private int current_index_resolution;
    private int current_widths;
    private int current_heights;

    //public Dropdown resolutionDropdown;

    [SerializeField]
    private SystemData SystemData;


    private void Start()
    {
        //sound
        //MusicVolume = PlayerPrefs.GetFloat("Volume");
        
        volumeSlider.value = SystemData.main_volume;

        //sub sound 
        music_Slider.value = SystemData.audio_music;
        VFX_Slider.value = SystemData.audio_VFX;


        //fullscreen
        fullscreen = SystemData.fullscreen;
        Screen.fullScreen = fullscreen;

        //SystemData.index_resolution = 0;
        //resolution

        current_index_resolution = SystemData.index_resolution;
        current_widths = widths[current_index_resolution];
        current_heights = heights[current_index_resolution];
        Screen.SetResolution(current_widths, current_heights, Screen.fullScreen);
    }


    //volume
    public void SetVolume(float volume) {
        audioMixer.SetFloat("Volume", volume);
        MusicVolume = volume;
    }


    public void SetSubVolume_Music(float sub_volume_music) {
        audioMixer.SetFloat("music_volume", sub_volume_music);
        music_volume = sub_volume_music;

    }

    public void SetSubVolume_VFX(float sub_volume_VFX) {
        audioMixer.SetFloat("VFX_volume", sub_volume_VFX);
        VFX_volume = sub_volume_VFX;
    }



    //fullscreen
    public void SetFullscreen(bool isFullscreen) {
        Screen.fullScreen = isFullscreen;
        fullscreen = isFullscreen;
    }


    //resolution
    public void SetScreenSize(int index) {
        current_index_resolution = index;
        current_widths = widths[index];
        current_heights = heights[index];
        Screen.SetResolution(current_widths, current_heights, Screen.fullScreen);
    }


    //update

    public void Update()
    {
        //sound
        
        SystemData.main_volume = MusicVolume;

        //sub sound
        SystemData.audio_music = music_volume;
        SystemData.audio_VFX = VFX_volume;


        //fullscreen
        SystemData.fullscreen = fullscreen;
      

        //resolution
        SystemData.index_resolution = current_index_resolution;
        SystemData.current_widths = current_widths;
        SystemData.current_heights = current_heights;
    }
}
