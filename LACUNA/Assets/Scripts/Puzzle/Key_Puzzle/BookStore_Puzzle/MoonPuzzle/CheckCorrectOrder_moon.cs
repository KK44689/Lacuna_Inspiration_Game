using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckCorrectOrder_moon : MonoBehaviour
{
    GameObject

            square1,
            square2,
            square3,
            square4,
            square5,
            square6;

    private Vector3

            pos1,
            pos2,
            pos3,
            pos4,
            pos5,
            pos6;

    public GameObject Puzzle;

    public GameObject puzzleDetector;

    public GameObject getInspireItemDetector;

    bool

            square1_solved,
            square2_solved,
            square3_solved,
            square4_solved,
            square5_solved,
            square6_solved;

    public static bool moon_puzzle_solved = false;

    //load/save variables
    [SerializeField]
    private PuzzleData PuzzleData;

    // Start is called before the first frame update
    void Start()
    {
        square1_solved = false;
        square2_solved = false;
        square3_solved = false;
        square4_solved = false;
        square5_solved = false;
        square6_solved = false;

        square1 = GameObject.Find("square1");
        square2 = GameObject.Find("square2");
        square3 = GameObject.Find("square3");
        square4 = GameObject.Find("square4");
        square5 = GameObject.Find("square5");
        square6 = GameObject.Find("square6");

        // make code value = data value
        moon_puzzle_solved = PuzzleData.moon_puzzle_solved;
    }

    // Update is called once per frame
    void Update()
    {
        pos1 = square1.transform.position;
        pos2 = square2.transform.position;
        pos3 = square3.transform.position;
        pos4 = square4.transform.position;
        pos5 = square5.transform.position;
        pos6 = square6.transform.position;
        CheckAllCorrected();
        CheckCorrectedOrders();
    }

    void CheckAllCorrected()
    {
        if (
            square1_solved &&
            square2_solved &&
            square3_solved &&
            square4_solved &&
            square5_solved &&
            square6_solved
        )
        {
            Debug.Log("star puzzle solved");
            Puzzle.SetActive(false);
            puzzleDetector.GetComponent<BoxCollider2D>().enabled = false;
            moon_puzzle_solved = true;
            PuzzleData.moon_puzzle_solved = moon_puzzle_solved;
            getInspireItemDetector.SetActive(false);
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
            (pos1.x < pos6.x)
        )
        {
            square1_solved = true;
        }

        // piece2
        if (
            (pos2.x > pos1.x) &&
            (pos2.x < pos3.x) &&
            (pos2.x < pos4.x) &&
            (pos2.x < pos5.x) &&
            (pos2.x < pos6.x)
        )
        {
            square2_solved = true;
        }

        // piece3
        if (
            (pos3.x > pos1.x) &&
            (pos3.x > pos2.x) &&
            (pos3.x < pos4.x) &&
            (pos3.x < pos5.x) &&
            (pos3.x < pos6.x)
        )
        {
            square3_solved = true;
        }

        // piece4
        if (
            (pos4.x > pos1.x) &&
            (pos4.x > pos2.x) &&
            (pos4.x > pos3.x) &&
            (pos4.x < pos5.x) &&
            (pos4.x < pos6.x)
        )
        {
            square4_solved = true;
        }

        // piece5
        if (
            (pos5.x > pos1.x) &&
            (pos5.x > pos2.x) &&
            (pos5.x > pos3.x) &&
            (pos5.x > pos4.x) &&
            (pos5.x < pos6.x)
        )
        {
            square5_solved = true;
        }

        // piece6
        if (
            (pos6.x > pos1.x) &&
            (pos6.x > pos2.x) &&
            (pos6.x > pos3.x) &&
            (pos6.x > pos4.x) &&
            (pos6.x > pos5.x)
        )
        {
            square6_solved = true;
        }
    }
}
