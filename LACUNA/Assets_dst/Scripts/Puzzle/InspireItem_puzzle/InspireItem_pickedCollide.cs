using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InspireItem_pickedCollide : MonoBehaviour
{
    // pop up E
    public GameObject pickUpText;

    // check that it's player who pick up
    public static bool pickUpAllowed = false;

    // show that already pick up item
    // public static bool alreadyPickup = false;
    public static bool destroyInspireBW = false;

    public static bool PlayPickupSound = false;

    // get colored item
    public ConvertToColor convert_color;

    // Start is called before the first frame update
    void Start()
    {
        // hide E
        pickUpText.SetActive(false);
        // alreadyPickup = false;
    }

    // // Update is called once per frame
    // void Update()
    // {
    //     if (pickUpAllowed)
    //     {
    //         PuzzleCollider.alreadyPickup = true;
    //         GenInspireItem.inspireItemPicked = true;
    //         PlayPickupSound = true;
    //         pickUpText.SetActive(false);

    //         // convert_color.GenColorObj();
    //         PuzzleCollider.deletePuzzle = true;
    //         // destroyInspireBW = false;
    //         // delete Black-White item
    //         // Destroy(gameObject);
    //         // PandoraController.inspireItemPuzzleSolved = false;
    //         // gameObject.SetActive(false);
    //     }
    // }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            print(GenInspireItem.inspireItemPicked);
            // pickUpText.SetActive(true);
            PuzzleCollider.alreadyPickup = true;
            GenInspireItem.inspireItemPicked = true;
            PlayPickupSound = true;
            pickUpText.SetActive(false);
            InspireItem.pickUpAllowed = true;

            // convert_color.GenColorObj();
            PuzzleCollider.deletePuzzle = true;

        }
    }
}
