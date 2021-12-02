using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableDetecter : MonoBehaviour
{
    public GameObject pickUpText;

    public GameObject Puzzle;

    public static bool showPuzzle = false;

    // public GameObject Puzzle;
    // Start is called before the first frame update
    void Start()
    {
        pickUpText.SetActive(false);
        Puzzle.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (showPuzzle && Input.GetKeyDown(KeyCode.E) && GenCollectable.challangeSolved == false)
        {
            pickUpText.SetActive(false);
            Puzzle.SetActive(true);
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("Player") && GenCollectable.challangeSolved == false)
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
        }
    }
}
