using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewGameData : MonoBehaviour
{
    //all in createassetmenu

    ////////////////////////////////////////////////////////////////////////////////////////////
    //index
    ////////////////////////////////////////////////////////////////////////////////////////////
    [SerializeField]
    public IndexSceneData indexSceneData;

    ////////////////////////////////////////////////////////////////////////////////////////////
    //SystemData not to use in this script
    ////////////////////////////////////////////////////////////////////////////////////////////

    ////////////////////////////////////////////////////////////////////////////////////////////
    //Player
    ////////////////////////////////////////////////////////////////////////////////////////////

    [SerializeField]
    public PlayerData player_s0_chap1;
    [SerializeField]
    public PlayerData player_s1_chap1;
    [SerializeField]
    public PlayerData player_s2_chap1;

    [SerializeField]
    public PlayerData player_s0_chap2;
    [SerializeField]
    public PlayerData player_s1_chap2;
    [SerializeField]
    public PlayerData player_s2_chap2;
    [SerializeField]
    public PlayerData player_s3_chap2;
    [SerializeField]
    public PlayerData player_s4_chap2;
    [SerializeField]
    public PlayerData player_s5_chap2;

    [SerializeField]
    public PlayerData player_s0_chap3;
    [SerializeField]
    public PlayerData player_s1_chap3;

    [SerializeField]
    public PlayerData player_s0_chap4;
    [SerializeField]
    public PlayerData player_s1_chap4;
    [SerializeField]
    public PlayerData player_s2_chap4;
    [SerializeField]
    public PlayerData player_s3_chap4;
    [SerializeField]
    public PlayerData player_s4_chap4;
    [SerializeField]
    public PlayerData player_s5_chap4;
    [SerializeField]
    public PlayerData player_s6_chap4;


    ////////////////////////////////////////////////////////////////////////////////////////////
    //NPC
    ////////////////////////////////////////////////////////////////////////////////////////////

    [SerializeField]
    public NpcData npc_s0_chap1;

    [SerializeField]
    public NpcData npc_s0_chap2;
    [SerializeField]
    public NpcData npc_s1_chap2;
    [SerializeField]
    public NpcData npc_s2_chap2;
    [SerializeField]
    public NpcData npc_s3_chap2;

    [SerializeField]
    public NpcData npc_s0_chap3;

    [SerializeField]
    public NpcData npc_s0_chap4;
    [SerializeField]
    public NpcData npc_s1_chap4;
    [SerializeField]
    public NpcData npc_s2_chap4;


    ////////////////////////////////////////////////////////////////////////////////////////////
    //monster
    ////////////////////////////////////////////////////////////////////////////////////////////
    [SerializeField]
    public MonsterData monster1_chap1;
    [SerializeField]
    public MonsterData monster2_chap1;
    [SerializeField]
    public MonsterData monster3_chap1;
    [SerializeField]
    public MonsterData monster4_chap1;

    [SerializeField]
    public MonsterData monster1_chap2_lib2;
    [SerializeField]
    public MonsterData monster2_chap2_lib2;


    ////////////////////////////////////////////////////////////////////////////////////////////
    //item
    ////////////////////////////////////////////////////////////////////////////////////////////
    [SerializeField]
    public ItemData ItemChap1;
    [SerializeField]
    public ItemData ItemChap2;
    [SerializeField]
    public ItemData ItemChap3;
    [SerializeField]
    public ItemData ItemChap4;


    ////////////////////////////////////////////////////////////////////////////////////////////
    //Obstacle
    ////////////////////////////////////////////////////////////////////////////////////////////

    [SerializeField]
    public ObstacleData log1_chap1;
    [SerializeField]
    public ObstacleData log2_chap1;


    ////////////////////////////////////////////////////////////////////////////////////////////
    //Puzzle
    ////////////////////////////////////////////////////////////////////////////////////////////

    [SerializeField]
    public PuzzleData puzzle_chap1;
    [SerializeField]
    public PuzzleData puzzle_chap2;
    [SerializeField]
    public PuzzleData puzzle_chap3;
    [SerializeField]
    public PuzzleData puzzle_chap4;


    ////////////////////////////////////////////////////////////////////////////////////////////
    //Dialogue
    ////////////////////////////////////////////////////////////////////////////////////////////

    private int count1;
    private int count2_1;
    private int count2_2;
    private int count2_3;
    private int count2_4;
    private int count3;
    private int count4_1;
    private int count4_2;
    private int count4_3;
    private int count4_4;


    [SerializeField]
    public GameplayDialogueData chap1_01;

    [SerializeField]
    public GameplayDialogueData chap2_01;
    [SerializeField]
    public GameplayDialogueData chap2_02;
    [SerializeField]
    public GameplayDialogueData chap2_03;
    [SerializeField]
    public GameplayDialogueData chap2_04;

    [SerializeField]
    public GameplayDialogueData chap3_01;

    [SerializeField]
    public GameplayDialogueData chap4_01;
    [SerializeField]
    public GameplayDialogueData chap4_02;
    [SerializeField]
    public GameplayDialogueData chap4_03;
    [SerializeField]
    public GameplayDialogueData chap4_04;


    ////////////////////////////////////////////////////////////////////////////////////////////
    ///Cutscene 
    ////////////////////////////////////////////////////////////////////////////////////////////
    //pan_house
    [SerializeField]
    public CutsceneData cutsceneData_pan_house_01;
    [SerializeField]
    public CutsceneData cutsceneData_pan_house_02;

    //chap1
    [SerializeField]
    public CutsceneData cutsceneData_chap1_01;
    [SerializeField]
    public CutsceneData cutsceneData_chap1_02;
    [SerializeField]
    public CutsceneData cutsceneData_chap1_03;
    [SerializeField]
    public CutsceneData cutsceneData_chap1_04;
    [SerializeField]
    public CutsceneData cutsceneData_chap1_05;
    [SerializeField]
    public CutsceneData cutsceneData_chap1_06;

    //chap2
    [SerializeField]
    public CutsceneData cutsceneData_chap2_01;
    [SerializeField]
    public CutsceneData cutsceneData_chap2_02;
    [SerializeField]
    public CutsceneData cutsceneData_chap2_03;
    [SerializeField]
    public CutsceneData cutsceneData_chap2_04;
    [SerializeField]
    public CutsceneData cutsceneData_chap2_05;
    [SerializeField]
    public CutsceneData cutsceneData_chap2_06;
    [SerializeField]
    public CutsceneData cutsceneData_chap2_07;
    [SerializeField]
    public CutsceneData cutsceneData_chap2_08;

    //chap3
    [SerializeField]
    public CutsceneData cutsceneData_chap3_01;
    [SerializeField]
    public CutsceneData cutsceneData_chap3_02;
    [SerializeField]
    public CutsceneData cutsceneData_chap3_03;

    //chap4
    [SerializeField]
    public CutsceneData cutsceneData_chap4_01;
    [SerializeField]
    public CutsceneData cutsceneData_chap4_02;
    [SerializeField]
    public CutsceneData cutsceneData_chap4_03;
    [SerializeField]
    public CutsceneData cutsceneData_chap4_04;


    ////////////////////////////////////////////////////////////////////////////////////////////
    //warp
    ////////////////////////////////////////////////////////////////////////////////////////////

    [SerializeField]
    public WarpData warp_chap1_01;
    [SerializeField]
    public WarpData warp_chap1_02;
    [SerializeField]
    public WarpData warp_chap1_03;
    [SerializeField]
    public WarpData warp_chap1_04;

    [SerializeField]
    public WarpData warp_chap2_01;
    [SerializeField]
    public WarpData warp_chap2_02;
    [SerializeField]
    public WarpData warp_chap2_03;
    [SerializeField]
    public WarpData warp_chap2_04;
    [SerializeField]
    public WarpData warp_chap2_05;

    [SerializeField]
    public WarpData warp_chap3_01;
    [SerializeField]
    public WarpData warp_chap3_02;
    [SerializeField]
    public WarpData warp_chap3_03;

    [SerializeField]
    public WarpData warp_chap4_01;
    [SerializeField]
    public WarpData warp_chap4_02;
    [SerializeField]
    public WarpData warp_chap4_03;

    ///////////////////////////////////////////////////////////////////////////////////////////////
    ///////////////////////////////////////////////////////////////////////////////////////////////
    ///////////////////////////////////////////////////////////////////////////////////////////////
    ///////////////////////////////////////////////////////////////////////////////////////////////
    ///////////////////////////////////////////////////////////////////////////////////////////////


    // set all data to default 

    public async void StartNewGame()
    {
        ////////////////////////////////////////////////////////////////////////////////////////////
        //index not  to use in this script
        ////////////////////////////////////////////////////////////////////////////////////////////

        //indexSceneData.currentSceneIndex = 1;

        ////////////////////////////////////////////////////////////////////////////////////////////
        //SystemData not to use in this script
        ////////////////////////////////////////////////////////////////////////////////////////////

        ////////////////////////////////////////////////////////////////////////////////////////////
        //Player
        ////////////////////////////////////////////////////////////////////////////////////////////
        //3 6 2 7

        //3
        player_s0_chap1.position_player_x = 7;
        player_s1_chap1.position_player_x = 130;
        player_s2_chap1.position_player_x = -10;

        //6
        player_s0_chap2.position_player_x = 0;
        player_s1_chap2.position_player_x = 98;
        player_s2_chap2.position_player_x = -9;
        player_s3_chap2.position_player_x = 130;
        player_s4_chap2.position_player_x = -9;
        player_s5_chap2.position_player_x = -5;

        //2
        player_s0_chap3.position_player_x = 5;
        player_s1_chap3.position_player_x = 210;

        //7
        player_s0_chap4.position_player_x = 355;
        player_s1_chap4.position_player_x = 167;
        player_s2_chap4.position_player_x = 164;
        player_s3_chap4.position_player_x = 34;
        player_s4_chap4.position_player_x = 119;
        player_s5_chap4.position_player_x = 46;
        player_s6_chap4.position_player_x = 57;


        ////////////////////////////////////////////////////////////////////////////////////////////
        //NPC
        ////////////////////////////////////////////////////////////////////////////////////////////
        //1 4 1 3

        //1
        npc_s0_chap1.position_npc_x = 12;

        //4
        npc_s0_chap2.position_npc_x = 260;
        npc_s1_chap2.position_npc_x = 94;
        npc_s2_chap2.position_npc_x = -9;
        npc_s3_chap2.position_npc_x = -4;

        //1
        npc_s0_chap3.position_npc_x = 278;

        //3
        npc_s0_chap4.position_npc_x = 364;
        npc_s1_chap4.position_npc_x = 171;
        npc_s2_chap4.position_npc_x = 61;


        ////////////////////////////////////////////////////////////////////////////////////////////
        //monster
        ////////////////////////////////////////////////////////////////////////////////////////////
        ///4 2

        //4
        monster1_chap1.monsterActive = true;
        monster1_chap1.monsterPos = 270;
        monster1_chap1.monsterMustDetect = true;
        monster1_chap1.monsterMustPatrol = true;
        monster1_chap1.monsterStruck = false;

        monster2_chap1.monsterActive = true;
        monster2_chap1.monsterPos = 550;
        monster2_chap1.monsterMustDetect = true;
        monster2_chap1.monsterMustPatrol = true;
        monster2_chap1.monsterStruck = false;

        monster3_chap1.monsterActive = true;
        monster3_chap1.monsterPos = 590;
        monster3_chap1.monsterMustDetect = true;
        monster3_chap1.monsterMustPatrol = true;
        monster3_chap1.monsterStruck = false;

        monster4_chap1.monsterActive = true;
        monster4_chap1.monsterPos = 610;
        monster4_chap1.monsterMustDetect = true;
        monster4_chap1.monsterMustPatrol = true;
        monster4_chap1.monsterStruck = false;

        //2

        monster1_chap2_lib2.monsterActive = true;
        monster1_chap2_lib2.monsterPos = 22;
        monster1_chap2_lib2.monsterMustDetect = true;
        monster1_chap2_lib2.monsterMustPatrol = true;
        monster1_chap2_lib2.monsterStruck = false;

        monster2_chap2_lib2.monsterActive = true;
        monster2_chap2_lib2.monsterPos = 77;
        monster2_chap2_lib2.monsterMustDetect = true;
        monster2_chap2_lib2.monsterMustPatrol = true;
        monster2_chap2_lib2.monsterStruck = false;


        ////////////////////////////////////////////////////////////////////////////////////////////
        //item
        ////////////////////////////////////////////////////////////////////////////////////////////
        ///1 1 1 1

        //1
        ItemChap1.flower1 = false;
        ItemChap1.flower2 = false;
        ItemChap1.flower3 = false;
        ItemChap1.allFlowerCollected = false;
        ItemChap1.allFlower_alreadyDestroy = false;
        ItemChap1.flowerTutorialRight = false;
        ItemChap1.flowerTutorialWrong = false;
        ItemChap1.souvenir = false;

        //1
        ItemChap2.flower1 = false;
        ItemChap2.flower2 = false;
        ItemChap2.flower3 = false;
        ItemChap2.allFlowerCollected = false;
        ItemChap2.allFlower_alreadyDestroy = false;
        ItemChap2.flowerTutorialRight = false;
        ItemChap2.flowerTutorialWrong = false;
        ItemChap2.souvenir = false;

        //1
        ItemChap3.flower1 = false;
        ItemChap3.flower2 = false;
        ItemChap3.flower3 = false;
        ItemChap3.allFlowerCollected = false;
        ItemChap3.allFlower_alreadyDestroy = false;
        ItemChap3.flowerTutorialRight = false;
        ItemChap3.flowerTutorialWrong = false;
        ItemChap3.souvenir = false;

        //1
        ItemChap4.flower1 = false;
        ItemChap4.flower2 = false;
        ItemChap4.flower3 = false;
        ItemChap4.allFlowerCollected = false;
        ItemChap4.allFlower_alreadyDestroy = false;
        ItemChap4.flowerTutorialRight = false;
        ItemChap4.flowerTutorialWrong = false;
        ItemChap4.souvenir = false;

        ////////////////////////////////////////////////////////////////////////////////////////////
        //Obstacle
        ////////////////////////////////////////////////////////////////////////////////////////////
        ///1 1

        //1
        log1_chap1.HidelogCollider = false;
        log1_chap1.logRollStop = false;
        log1_chap1.logRollHitFloor = false;
        log1_chap1.logRollHitEnemy = false;
        log1_chap1.blankLogActive = false;

        //1
        log2_chap1.HidelogCollider = false;
        log2_chap1.logRollStop = false;
        log2_chap1.logRollHitFloor = false;
        log2_chap1.logRollHitEnemy = false;
        log2_chap1.blankLogActive = false;

        ////////////////////////////////////////////////////////////////////////////////////////////
        //Puzzle
        ////////////////////////////////////////////////////////////////////////////////////////////
        ///1 1 1 1 

        //1
        puzzle_chap1.inspireItem_puzzle_solved = false;
        puzzle_chap1.inspireItem_alreadyPicked = false;
        puzzle_chap1.collectable_puzzle_solved = false;
        puzzle_chap1.moon_puzzle_solved = false;
        puzzle_chap1.star_puzzle_solved = false;
        puzzle_chap1.sun_puzzle_solved = false;
        puzzle_chap1.all_puzzle_solved = false;
        puzzle_chap1.fishing_puzzle_solved = false;

        //1
        puzzle_chap2.inspireItem_puzzle_solved = false;
        puzzle_chap2.inspireItem_alreadyPicked = false;
        puzzle_chap2.collectable_puzzle_solved = false;
        puzzle_chap2.moon_puzzle_solved = false;
        puzzle_chap2.star_puzzle_solved = false;
        puzzle_chap2.sun_puzzle_solved = false;
        puzzle_chap2.all_puzzle_solved = false;
        puzzle_chap2.fishing_puzzle_solved = false;

        //1
        puzzle_chap3.inspireItem_puzzle_solved = false;
        puzzle_chap3.inspireItem_alreadyPicked = false;
        puzzle_chap3.collectable_puzzle_solved = false;
        puzzle_chap3.moon_puzzle_solved = false;
        puzzle_chap3.star_puzzle_solved = false;
        puzzle_chap3.sun_puzzle_solved = false;
        puzzle_chap3.all_puzzle_solved = false;
        puzzle_chap3.fishing_puzzle_solved = false;

        //1
        puzzle_chap4.inspireItem_puzzle_solved = false;
        puzzle_chap4.inspireItem_alreadyPicked = false;
        puzzle_chap4.collectable_puzzle_solved = false;
        puzzle_chap4.moon_puzzle_solved = false;
        puzzle_chap4.star_puzzle_solved = false;
        puzzle_chap4.sun_puzzle_solved = false;
        puzzle_chap4.all_puzzle_solved = false;
        puzzle_chap4.fishing_puzzle_solved = false;

        ////////////////////////////////////////////////////////////////////////////////////////////
        //Dialogue
        ////////////////////////////////////////////////////////////////////////////////////////////
        ///1 4 1 4

        //1
        chap1_01.skyColor = new Color(0.7882354f, 0.7882354f, 0.7882354f, 1f);
        count1 = 34;
        for (int i = 0; i < count1; i++)
        {
            chap1_01.colliderIsActive[i] = false;

            if (i == 0 || i == 16 || i == 17) {
                chap1_01.colliderIsActive[i] = true;
            }
        }

        //4
        chap2_01.skyColor = new Color(0.6901961f, 0.7882354f, 0.7882354f, 1f);
        count2_1 = 6;
        for (int i = 0; i < count2_1; i++)
        {
            chap2_01.colliderIsActive[i] = false;

        }

        chap2_02.skyColor = new Color(0.7882354f, 0.5333334f, 0.372549f, 1f);
        count2_2 = 13;
        for (int i = 0; i < count2_2; i++)
        {
            chap2_02.colliderIsActive[i] = false;

            if (i == 0)
            {
                chap2_02.colliderIsActive[i] = true;
            }
        }

        chap2_03.skyColor = new Color(0.7882354f, 0.7882354f, 0.7882354f, 1f);
        count2_3 = 7;
        for (int i = 0; i < count2_3; i++)
        {
            chap2_03.colliderIsActive[i] = false;

            if (i == 0)
            {
                chap2_03.colliderIsActive[i] = true;
            }

        }

        chap2_04.skyColor = new Color(0.7882354f, 0.7882354f, 0.7882354f, 1f);
        count2_4 = 4;
        for (int i = 0; i < count2_4; i++)
        {
            chap2_04.colliderIsActive[i] = false;

            if (i == 0)
            {
                chap2_04.colliderIsActive[i] = true;
            }
        }

        //1
        chap3_01.skyColor = new Color(0.2099205f, 0.4032004f, 0.5754717f, 1f);
        count3 = 26;
        for (int i = 0; i < count3; i++)
        {
            chap3_01.colliderIsActive[i] = false;

            if (i == 0)
            {
                chap3_01.colliderIsActive[i] = true;
            }
        }


        //4
        chap4_01.skyColor = new Color(0.7098039f, 0.7843138f, 0.7882354f, 1f);
        count4_1 = 5;
        for (int i = 0; i < count4_1; i++)
        {
            chap4_01.colliderIsActive[i] = false;

            if (i == 0)
            {
                chap4_01.colliderIsActive[i] = true;
            }

        }

        chap4_02.skyColor = new Color(0.7098039f, 0.7843138f, 0.7882354f, 1f);
        count4_2 = 3;
        for (int i = 0; i < count4_2; i++)
        {
            chap4_02.colliderIsActive[i] = false;

            if (i == 0)
            {
                chap4_02.colliderIsActive[i] = true;
            }

        }

        chap4_03.skyColor = new Color(0.7882354f, 0.7882354f, 0.7882354f, 1f);
        count4_3 = 1;
        for (int i = 0; i < count4_3; i++)
        {
            chap4_03.colliderIsActive[i] = true;

        }

        chap4_04.skyColor = new Color(0.7882354f, 0.7882354f, 0.7882354f, 1f);
        count4_4 = 7;
        for (int i = 0; i < count4_4; i++)
        {
            chap4_04.colliderIsActive[i] = false;

            if (i == 0 || i == 3)
            {
                chap4_04.colliderIsActive[i] = true;
            }
        }

        ////////////////////////////////////////////////////////////////////////////////////////////
        //cutscene
        ////////////////////////////////////////////////////////////////////////////////////////////
        ///2 6 8 3 4

        //2
        cutsceneData_pan_house_01.UI_active = true;
        cutsceneData_pan_house_01.obj_cut_active = true;
        cutsceneData_pan_house_01.cutscene_active = false;
        cutsceneData_pan_house_01.enter_box_active = false;

        cutsceneData_pan_house_02.UI_active = true;
        cutsceneData_pan_house_02.obj_cut_active = true;
        cutsceneData_pan_house_02.cutscene_active = false;
        cutsceneData_pan_house_02.enter_box_active = false;

        //6
        cutsceneData_chap1_01.UI_active = true;
        cutsceneData_chap1_01.obj_cut_active = true;
        cutsceneData_chap1_01.cutscene_active = false;
        cutsceneData_chap1_01.enter_box_active = false;

        cutsceneData_chap1_02.UI_active = true;
        cutsceneData_chap1_02.obj_cut_active = true;
        cutsceneData_chap1_02.cutscene_active = false;
        cutsceneData_chap1_02.enter_box_active = false;

        cutsceneData_chap1_03.UI_active = true;
        cutsceneData_chap1_03.obj_cut_active = true;
        cutsceneData_chap1_03.cutscene_active = false;
        cutsceneData_chap1_03.enter_box_active = false;

        cutsceneData_chap1_04.UI_active = true;
        cutsceneData_chap1_04.obj_cut_active = true;
        cutsceneData_chap1_04.cutscene_active = false;
        cutsceneData_chap1_04.enter_box_active = false;

        cutsceneData_chap1_05.UI_active = true;
        cutsceneData_chap1_05.obj_cut_active = true;
        cutsceneData_chap1_05.cutscene_active = false;
        cutsceneData_chap1_05.enter_box_active = false;

        cutsceneData_chap1_06.UI_active = true;
        cutsceneData_chap1_06.obj_cut_active = true;
        cutsceneData_chap1_06.cutscene_active = false;
        cutsceneData_chap1_06.enter_box_active = false;

        //8
        cutsceneData_chap2_01.UI_active = true;
        cutsceneData_chap2_01.obj_cut_active = true;
        cutsceneData_chap2_01.cutscene_active = false;
        cutsceneData_chap2_01.enter_box_active = false;

        cutsceneData_chap2_02.UI_active = true;
        cutsceneData_chap2_02.obj_cut_active = true;
        cutsceneData_chap2_02.cutscene_active = false;
        cutsceneData_chap2_02.enter_box_active = false;

        cutsceneData_chap2_03.UI_active = true;
        cutsceneData_chap2_03.obj_cut_active = true;
        cutsceneData_chap2_03.cutscene_active = false;
        cutsceneData_chap2_03.enter_box_active = false;

        cutsceneData_chap2_04.UI_active = true;
        cutsceneData_chap2_04.obj_cut_active = true;
        cutsceneData_chap2_04.cutscene_active = false;
        cutsceneData_chap2_04.enter_box_active = false;

        cutsceneData_chap2_05.UI_active = true;
        cutsceneData_chap2_05.obj_cut_active = true;
        cutsceneData_chap2_05.cutscene_active = false;
        cutsceneData_chap2_05.enter_box_active = false;

        cutsceneData_chap2_06.UI_active = true;
        cutsceneData_chap2_06.obj_cut_active = true;
        cutsceneData_chap2_06.cutscene_active = false;
        cutsceneData_chap2_06.enter_box_active = false;

        cutsceneData_chap2_07.UI_active = true;
        cutsceneData_chap2_07.obj_cut_active = true;
        cutsceneData_chap2_07.cutscene_active = false;
        cutsceneData_chap2_07.enter_box_active = false;

        cutsceneData_chap2_08.UI_active = true;
        cutsceneData_chap2_08.obj_cut_active = true;
        cutsceneData_chap2_08.cutscene_active = false;
        cutsceneData_chap2_08.enter_box_active = false;

        //3
        cutsceneData_chap3_01.UI_active = true;
        cutsceneData_chap3_01.obj_cut_active = true;
        cutsceneData_chap3_01.cutscene_active = false;
        cutsceneData_chap3_01.enter_box_active = false;

        cutsceneData_chap3_02.UI_active = true;
        cutsceneData_chap3_02.obj_cut_active = true;
        cutsceneData_chap3_02.cutscene_active = false;
        cutsceneData_chap3_02.enter_box_active = false;

        cutsceneData_chap3_03.UI_active = true;
        cutsceneData_chap3_03.obj_cut_active = true;
        cutsceneData_chap3_03.cutscene_active = false;
        cutsceneData_chap3_03.enter_box_active = false;

        //4
        cutsceneData_chap4_01.UI_active = true;
        cutsceneData_chap4_01.obj_cut_active = true;
        cutsceneData_chap4_01.cutscene_active = false;
        cutsceneData_chap4_01.enter_box_active = false;

        cutsceneData_chap4_02.UI_active = true;
        cutsceneData_chap4_02.obj_cut_active = true;
        cutsceneData_chap4_02.cutscene_active = false;
        cutsceneData_chap4_02.enter_box_active = false;

        cutsceneData_chap4_03.UI_active = true;
        cutsceneData_chap4_03.obj_cut_active = true;
        cutsceneData_chap4_03.cutscene_active = false;
        cutsceneData_chap4_03.enter_box_active = false;

        cutsceneData_chap4_04.UI_active = true;
        cutsceneData_chap4_04.obj_cut_active = true;
        cutsceneData_chap4_04.cutscene_active = false;
        cutsceneData_chap4_04.enter_box_active = false;

        ////////////////////////////////////////////////////////////////////////////////////////////
        //warp
        ////////////////////////////////////////////////////////////////////////////////////////////
        ///4 5 3 3

        //4
        warp_chap1_01.warp_active = true;
        warp_chap1_02.warp_active = true;
        warp_chap1_03.warp_active = true;
        warp_chap1_04.warp_active = true;

        //5
        warp_chap2_01.warp_active = true;
        warp_chap2_02.warp_active = true;
        warp_chap2_03.warp_active = true;
        warp_chap2_04.warp_active = true;
        warp_chap2_05.warp_active = true;

        //3
        warp_chap3_01.warp_active = true;
        warp_chap3_02.warp_active = true;
        warp_chap3_03.warp_active = true;

        //3
        warp_chap4_01.warp_active = true;
        warp_chap4_02.warp_active = true;
        warp_chap4_03.warp_active = true;

        ////////////////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////////////////

    }


}
