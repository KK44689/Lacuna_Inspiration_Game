using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckAllBookStorePuzzleSolved : MonoBehaviour
{
    public GameObject collider;

    GameObject Pandora;
    public static bool allBookStorePuzzleSolved = false;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (
            CheckCorrectOrder.star_puzzle_solved &&
            CheckCorrectOrder_sun.sun_puzzle_solved &&
            CheckCorrectOrder_moon.moon_puzzle_solved
        )
        {
            print("all solved");
            allBookStorePuzzleSolved = true;
            Pandora = GameObject.FindWithTag("Player");
            collider.SetActive(true);
            collider.transform.position = Pandora.transform.position;
        }
    }
}
