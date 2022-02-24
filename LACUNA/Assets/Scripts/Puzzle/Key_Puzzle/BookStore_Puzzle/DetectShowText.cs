using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectShowText : MonoBehaviour
{
    public GameObject pickUpText;

    public GameObject Puzzle;

    bool showPuzzle = false;

    // Start is called before the first frame update
    void Start()
    {
        pickUpText.SetActive(false);
        Puzzle.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (this.showPuzzle && Input.GetKeyDown(KeyCode.E))
        {
            pickUpText.SetActive(false);
            Puzzle.SetActive(true);
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            pickUpText.SetActive(true);
            this.showPuzzle = true;
        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            pickUpText.SetActive(false);
            this.showPuzzle = false;
            Puzzle.SetActive(false);
        }
    }
}
