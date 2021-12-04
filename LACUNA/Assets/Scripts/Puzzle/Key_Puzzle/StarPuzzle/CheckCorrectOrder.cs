using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckCorrectOrder : MonoBehaviour
{
    GameObject

            piece1,
            piece2,
            piece3,
            piece4,
            piece5;

    private Vector3

            pos1,
            pos2,
            pos3,
            pos4,
            pos5;

    public GameObject Puzzle;

    bool

            piece1_solved,
            piece2_solved,
            piece3_solved,
            piece4_solved,
            piece5_solved;

    // Start is called before the first frame update
    void Start()
    {
        piece1_solved = false;
        piece2_solved = false;
        piece3_solved = false;
        piece4_solved = false;
        piece5_solved = false;

        piece1 = GameObject.Find("puzzle1");
        piece2 = GameObject.Find("puzzle2");
        piece3 = GameObject.Find("puzzle3");
        piece4 = GameObject.Find("puzzle4");
        piece5 = GameObject.Find("puzzle5");

        pos1 = piece1.transform.position;
        pos2 = piece2.transform.position;
        pos3 = piece3.transform.position;
        pos4 = piece4.transform.position;
        pos5 = piece5.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
    }

    void CheckAllCorrected()
    {
        if (
            piece1_solved &&
            piece2_solved &&
            piece3_solved &&
            piece4_solved &&
            piece5_solved
        )
        {
            // GenCollectable.challangeSolved = true;
            Debug.Log("star puzzle solved");
            Puzzle.SetActive(false);
        }
    }

    void CheckCorrectedOrders()
    {
        // piece1
        if (
            (pos1.x < pos2.x) &&
            (pos1.x < pos3.x) &&
            (pos1.x < pos4.x) &&
            (pos1.x < pos5.x)
        )
        {
            piece1_solved = true;
        }
        // piece2
        if ((pos2.x > pos1.x) &&
            (pos2.x < pos3.x) &&
            (pos2.x < pos4.x) &&
            (pos2.x < pos5.x))
        {
            piece2_solved = true;
        }

        // piece3
        if ((pos3.x > pos1.x) &&
            (pos3.x > pos2.x) &&
            (pos3.x < pos4.x) &&
            (pos3.x < pos5.x))
        {
            piece3_solved = true;
        }

        // piece4
        if ((pos4.x > pos1.x) &&
            (pos4.x > pos2.x) &&
            (pos4.x > pos3.x) &&
            (pos4.x < pos5.x))
        {
            piece4_solved = true;
        }

        // piece5
        if ((pos5.x > pos1.x) &&
            (pos5.x > pos2.x) &&
            (pos5.x > pos3.x) &&
            (pos5.x > pos4.x))
        {
            piece5_solved = true;
        }

        print("1 " + piece1_solved);
        print("2 " + piece2_solved);
        print("3 " + piece3_solved);
        print("4 " + piece4_solved);
        print("5 " + piece5_solved);
        // print(Mathf.Round(Rotation));
    }
}
