using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InspireItem : MonoBehaviour
{
    // pop up E
    // public GameObject pickUpText;
    // check that it's player who pick up
    public static bool pickUpAllowed = false;

    public static bool destroyInspireBW = false;

    public static bool PlayPickupSound = false;

    // get colored item
    public ConvertToColor convert_color;

    // load/save puzzle variables
    [SerializeField]
    private PuzzleData PuzzleData;

    // Start is called before the first frame update
    void Start()
    {
        // hide E
        // pickUpText.SetActive(false);
        PuzzleCollider.alreadyPickup = PuzzleData.inspireItem_alreadyPicked;
    }

    // Update is called once per frame
    void Update()
    {
        //  && Input.GetKeyDown(KeyCode.E)
        if (pickUpAllowed)
        {
            PuzzleCollider.alreadyPickup = true;
            GenInspireItem.inspireItemPicked = true;
            PlayPickupSound = true;
            PuzzleData.inspireItem_alreadyPicked = PuzzleCollider.alreadyPickup;
            // pickUpText.SetActive(false);
            PuzzleCollider.deletePuzzle = true;
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            // pickUpText.SetActive(true);
            pickUpAllowed = true;
        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            // pickUpText.SetActive(false);
            pickUpAllowed = false;
        }
    }
}
