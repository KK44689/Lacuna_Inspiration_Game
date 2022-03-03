using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckAllBookStorePuzzleSolved : MonoBehaviour
{
    public GameObject collider;

    bool alreadySolved = false;

    GameObject Pandora;

    public static bool allBookStorePuzzleSolved = false;

    //load/save variables
    [SerializeField]
    private PuzzleData PuzzleData;

    void Start()
    {
        // make code value = data value
        allBookStorePuzzleSolved = PuzzleData.all_puzzle_solved;
    }

    // Update is called once per frame
    void Update()
    {
        if (
            CheckCorrectOrder.star_puzzle_solved &&
            CheckCorrectOrder_sun.sun_puzzle_solved &&
            CheckCorrectOrder_moon.moon_puzzle_solved &&
            alreadySolved == false
        )
        {
            allBookStorePuzzleSolved = true;
            PuzzleData.all_puzzle_solved = allBookStorePuzzleSolved;
            Pandora = GameObject.FindWithTag("Player");
            collider.SetActive(true);
            collider.transform.position = Pandora.transform.position;
            alreadySolved = true;
        }
    }
}
