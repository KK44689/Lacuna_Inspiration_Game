using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InspireItem_pickedCollide : MonoBehaviour
{
    // pop up E
    public GameObject pickUpText;

    // check that it's player who pick up
    public static bool pickUpAllowed = false;

    public static bool destroyInspireBW = false;

    public static bool PlayPickupSound = false;

    // get colored item
    public ConvertToColor convert_color;

    // load/save variables
    [SerializeField]
    private PuzzleData PuzzleData;

    // Start is called before the first frame update
    void Start()
    {
        // hide E
        pickUpText.SetActive(false);

        // make code value = data value
        GenInspireItem.inspireItemPicked = PuzzleData.inspireItem_alreadyPicked;
    }

    void Update()
    {
        //save data
        PuzzleData.inspireItem_alreadyPicked = GenInspireItem.inspireItemPicked;
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            print(GenInspireItem.inspireItemPicked);
            PuzzleCollider.alreadyPickup = true;
            GenInspireItem.inspireItemPicked = true;
            PlayPickupSound = true;
            pickUpText.SetActive(false);
            InspireItem.pickUpAllowed = true;

            PuzzleCollider.deletePuzzle = true;
        }
    }
}
