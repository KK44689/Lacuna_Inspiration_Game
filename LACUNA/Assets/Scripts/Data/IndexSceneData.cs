using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class IndexSceneData : ScriptableObject
{
    //scenes
    public int currentSceneIndex;

    //list all in scenes
    public enum SceneIndex
    {
        UI_Menu = 0,
        Chap1_Pan_house = 1,
        Chap1 = 2,
        Chap1_color = 3,
        Chap2_ArtGallery = 4,
        Chap2 = 5,
        Chap2_color = 6,
        Chap2_Library = 7,
        Chap2_Library2 = 8,
        Chap2_afterBookStore = 9,
        Chap3 = 10,
        Chap3_color = 11,
        Chap4_house = 12,
        Chap4 = 13,
        Chap4_church = 14,
        Chap4_SisterRoom = 15,
        Chap4_AfterSisterRoom = 16,
        Chap4_flashback = 17,
        Chap4_ending = 18,
        Chap1_Pan_house2 = 19,

    }

   
    
}
