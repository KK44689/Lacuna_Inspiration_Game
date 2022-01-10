using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerData
{
    ////Default

    //Scene
    //that player stays now
    public int SceneIndex;

    //Resolution
    public int[] resolution;


    //public int resolutionData(GameObject Data)
    //{
    //    resolution = new int[2];
        //resolution[0] = 
        //resolution[1] = 
    //}

    //Fullscreen
    public bool fullscreen;

    //Sound
    //separate main and VFX ???
    public int sound;

    








    //// Character
 
    //Position player
    public float[] position;

    public PlayerData(PandoraController player)
    {
        position = new float[2];
        position[0] = player.transform.position.x;
        position[1] = player.transform.position.y;


    }

    //position NPC

    //nan
    //public NPCData_01( )

    //jill

    //granpa


    //Monster 
    //chap1
    public bool monster101Active;
    public bool monster102Active;
    public bool monster103Active;
    public bool monster104Active;

    //chap2
    public bool monster201Active;
    public bool monster202Active;

    //chap3 none

    //chap4







    ////cutscene

    //pan_house
    public bool pan_house_cutscene_01;
    public bool pan_house_cutscene_02;

    //Chap1
    public bool chap1_cutscene_01;
    public bool chap1_cutscene_02;
    public bool chap1_cutscene_03;
    public bool chap1_cutscene_04;
    public bool chap1_cutscene_05;
    public bool chap1_cutscene_06;

    //Chap2
    public bool chap2_cutscene_01;
    public bool chap2_cutscene_02;
    public bool chap2_cutscene_03;
    public bool chap2_cutscene_04;
    public bool chap2_cutscene_05;
    public bool chap2_cutscene_06;
    public bool chap2_cutscene_07;
    public bool chap2_cutscene_08;

    //Chap3
    public bool chap3_cutscene_01;
    public bool chap3_cutscene_02;
    public bool chap3_cutscene_03;

    //Chap4








    ////item
    //Chap1

    public bool shears_inspire;
    public bool flower1;
    public bool flower2;
    public bool flower3;
    public bool cookies_souvenir;
    public bool brush_collectable;

    //Chap2

    public bool pencil_inspire;
    public bool painting_souvenir;
    public bool color_pencil_collectable;


    //Chap3

    public int num_fish_caught;

    public bool fishing_rod_inspire;
    public bool scented_bag_souvenir;
    public bool pallete_collectable;

    //Chap4







    //Puzzle
    //all chapter
    public bool puzzle01;
    public bool puzzle02;
    public bool puzzle03;
    public bool puzzle04;










}
