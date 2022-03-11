using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenInspireItem : MonoBehaviour
{
    public GameObject inspireBW;

    public static bool puzzleSolved = false;

    public static bool inspireItemPicked = false;

    GameObject pandora;

    // load/save variables
    [SerializeField]
    private PuzzleData PuzzleData;

    void Start()
    {
        puzzleSolved = false;
        pandora = GameObject.FindWithTag("Player");

        // // make code value = data value
        // puzzleSolved = PuzzleData.inspireItem_puzzle_solved;
    }

    // Update is called once per frame
    void Update()
    {
        generateInspireItem();
    }

    void generateInspireItem()
    {
        if (
            (puzzleSolved && inspireItemPicked == false) ||
            PuzzleData.inspireItem_puzzle_solved
        )
        {
            PuzzleData.inspireItem_alreadyPicked = true;
            // Physics2D
            //     .IgnoreCollision(pandora.GetComponent<Collider2D>(),
            //     GetComponent<Collider2D>());

            // Vector2 tempPos = transform.position;

            // GameObject InspireObject =
            //     (GameObject)
            //     Instantiate(inspireBW, tempPos, Quaternion.identity);
            // Destroy (gameObject);
            // puzzleSolved = false;
        }
    }
}
