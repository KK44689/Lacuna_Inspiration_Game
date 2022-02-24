using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckCorrectOrder_sun : MonoBehaviour
{
    GameObject

            box1,
            box2,
            box3,
            box4,
            box5,
            box6,
            box7,
            box8;

    private Vector3

            pos1,
            pos2,
            pos3,
            pos4,
            pos5,
            pos6,
            pos7,
            pos8;

    public GameObject Puzzle;

    public GameObject puzzleDetector;

    public GameObject getInspireItemDetector;

    public GameObject monster;

    public GameObject monsterStruck;

    bool

            box1_solved,
            box2_solved,
            box3_solved,
            box4_solved,
            box5_solved,
            box6_solved,
            box7_solved,
            box8_solved;

    public static bool sun_puzzle_solved = false;

    // Start is called before the first frame update
    void Start()
    {
        box1_solved = false;
        box2_solved = false;
        box3_solved = false;
        box4_solved = false;
        box5_solved = false;
        box6_solved = false;
        box7_solved = false;
        box8_solved = false;

        box1 = GameObject.Find("box1");
        box2 = GameObject.Find("box2");
        box3 = GameObject.Find("box3");
        box4 = GameObject.Find("box4");
        box5 = GameObject.Find("box5");
        box6 = GameObject.Find("box6");
        box7 = GameObject.Find("box7");
        box8 = GameObject.Find("box8");
        monsterStruck.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        pos1 = box1.transform.position;
        pos2 = box2.transform.position;
        pos3 = box3.transform.position;
        pos4 = box4.transform.position;
        pos5 = box5.transform.position;
        pos6 = box6.transform.position;
        pos7 = box7.transform.position;
        pos8 = box8.transform.position;
        CheckAllCorrected();
        CheckCorrectedOrders();
    }

    void CheckAllCorrected()
    {
        if (
            box1_solved &&
            box2_solved &&
            box3_solved &&
            box4_solved &&
            box5_solved &&
            box6_solved &&
            box7_solved &&
            box8_solved
        )
        {
            Puzzle.SetActive(false);
            puzzleDetector.GetComponent<BoxCollider2D>().enabled = false;
            sun_puzzle_solved = true;
            getInspireItemDetector.SetActive(false);
            monster.SetActive(false);
            monsterStruck.SetActive(true);
        }
    }

    void CheckCorrectedOrders()
    {
        // piece1
        if (
            (pos1.x < pos2.x) &&
            (pos1.x < pos3.x) &&
            (pos1.x < pos4.x) &&
            (pos1.x < pos5.x) &&
            (pos1.x < pos6.x) &&
            (pos1.x < pos7.x) &&
            (pos1.x < pos8.x)
        )
        {
            box1_solved = true;
        }

        // piece2
        if (
            (pos2.x > pos1.x) &&
            (pos2.x < pos3.x) &&
            (pos2.x < pos4.x) &&
            (pos2.x < pos5.x) &&
            (pos2.x < pos6.x) &&
            (pos2.x < pos7.x) &&
            (pos2.x < pos8.x)
        )
        {
            box2_solved = true;
        }

        // piece3
        if (
            (pos3.x > pos1.x) &&
            (pos3.x > pos2.x) &&
            (pos3.x < pos4.x) &&
            (pos3.x < pos5.x) &&
            (pos3.x < pos6.x) &&
            (pos3.x < pos7.x) &&
            (pos3.x < pos8.x)
        )
        {
            box3_solved = true;
        }

        // piece4
        if (
            (pos4.x > pos1.x) &&
            (pos4.x > pos2.x) &&
            (pos4.x > pos3.x) &&
            (pos4.x < pos5.x) &&
            (pos4.x < pos6.x) &&
            (pos4.x < pos7.x) &&
            (pos4.x < pos8.x)
        )
        {
            box4_solved = true;
        }

        // piece5
        if (
            (pos5.x > pos1.x) &&
            (pos5.x > pos2.x) &&
            (pos5.x > pos3.x) &&
            (pos5.x > pos4.x) &&
            (pos5.x < pos6.x) &&
            (pos5.x < pos7.x) &&
            (pos5.x < pos8.x)
        )
        {
            box5_solved = true;
        }

        // piece6
        if (
            (pos6.x > pos1.x) &&
            (pos6.x > pos2.x) &&
            (pos6.x > pos3.x) &&
            (pos6.x > pos4.x) &&
            (pos6.x > pos5.x) &&
            (pos6.x < pos7.x) &&
            (pos6.x < pos8.x)
        )
        {
            box6_solved = true;
        }

        // piece7
        if (
            (pos7.x > pos1.x) &&
            (pos7.x > pos2.x) &&
            (pos7.x > pos3.x) &&
            (pos7.x > pos4.x) &&
            (pos7.x > pos5.x) &&
            (pos7.x > pos6.x) &&
            (pos7.x < pos8.x)
        )
        {
            box7_solved = true;
        }

        // piece8
        if (
            (pos8.x > pos1.x) &&
            (pos8.x > pos2.x) &&
            (pos8.x > pos3.x) &&
            (pos8.x > pos4.x) &&
            (pos8.x > pos5.x) &&
            (pos8.x > pos6.x) &&
            (pos8.x > pos7.x)
        )
        {
            box8_solved = true;
        }
    }
}
