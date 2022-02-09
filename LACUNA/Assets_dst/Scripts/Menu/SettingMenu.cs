using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SettingMenu : MonoBehaviour
{
    public AudioMixer audioMixer;
    public Dropdown resolutionDropdown;

    private void Start()
    {
        Screen.fullScreen = true;
        Screen.SetResolution(1920, 1080, Screen.fullScreen);
    }

    public void SetVolume(float volume) {
        audioMixer.SetFloat("Volume", volume);
    }

    public void SetFullscreen(bool isFullscreen) {
        Screen.fullScreen = isFullscreen;
    }

    List<int> widths = new List<int>() { 1920, 1600, 1366, 1280 };
    List<int> heights = new List<int>() { 1080, 900, 768, 720 };

    public void SetScreenSize(int index) {
        int width = widths[index];
        int height = heights[index];
        Screen.SetResolution(width, height, Screen.fullScreen);
    }
}
