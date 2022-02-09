using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenInspireItem : MonoBehaviour
{
    public GameObject inspireBW;

    public static bool puzzleSolved = false;

    public static bool inspireItemPicked = false;

    GameObject pandora;

    // public static bool deletePuzzle = false;
    // Start is called before the first frame update
    void Start()
    {
        puzzleSolved = false;
        pandora = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        generateInspireItem();
    }

    void generateInspireItem()
    {
        if (puzzleSolved && inspireItemPicked == false)
        {
            // InteractPuzzle.SetActive(false);
            // Puzzle.SetActive(false);
            Physics2D
                .IgnoreCollision(pandora.GetComponent<Collider2D>(),
                GetComponent<Collider2D>());

            Vector2 tempPos = transform.position;

            GameObject InspireObject =
                (GameObject)
                Instantiate(inspireBW, tempPos, Quaternion.identity);
            Destroy(gameObject);
            puzzleSolved = false;
            // deletePuzzle = true;
            // if (deletePuzzle)
            // {
            //     Destroy(InspireObject);
            // }
        }
    }
}
