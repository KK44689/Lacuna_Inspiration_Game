using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class PlayerData : ScriptableObject
{

    //// Character

    //Position player

    //// Character
    //Position player
    public float position_player_x;
    //public float position_player_x_scene02;

    // in script PlayerPrefs
    // or Assetmenu to collect postion data in 18 scenes


    //if remove this , will bug in savesytem.cs
    //public float[] position;

    //public PlayerData(PandoraController player)
    //{
    //    position = new float[2];
    //    position[0] = player.transform.position.x;
    //    position[1] = player.transform.position.y;
    //}



}
