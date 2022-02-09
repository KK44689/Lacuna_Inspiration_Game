using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// Show puzzle + gen inspire item
public class PuzzleCollider : MonoBehaviour
{
    public GameObject pickUpText;

    public GameObject Puzzle;
    public GameObject pandora;

    public GameObject InteractPuzzle;

    public GameObject inspireBW;

    public static bool puzzleSolved;

    public static bool alreadyPickup = false;
    public static bool puzzleAwake = false;

    bool showPuzzle = false;

    public static bool deletePuzzle = false;

    // Start is called before the first frame update
    void Start()
    {
        pickUpText.SetActive(false);
        Puzzle.SetActive(false);
        InteractPuzzle.SetActive(false);
        puzzleSolved = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (showPuzzle && Input.GetKeyDown(KeyCode.E))
        {
            pickUpText.SetActive(false);
            Puzzle.SetActive(true);
            InteractPuzzle.SetActive(true);
        }
    }

    void FixedUpdate()
    {
        generateInspireItem();
    }

    void generateInspireItem()
    {
        if (puzzleSolved)
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
            puzzleSolved = false;
            deletePuzzle = true;
            // if (deletePuzzle)
            // {
            //     Destroy(InspireObject);
            // }
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("Player") && deletePuzzle == false && puzzleAwake)
        {
            pickUpText.SetActive(true);
            showPuzzle = true;
        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            pickUpText.SetActive(false);
            showPuzzle = false;
            Puzzle.SetActive(false);
            InteractPuzzle.SetActive(false);
        }
    }
}
