using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlowerPicked : MonoBehaviour
{
    // pop up E
    public GameObject pickUpText;

    // check that it's player who pick up
    bool pickUpAllowed;

    AudioSource audioSource;

    public AudioClip flowerSound;

    public static bool flowerC_Collected = false;

    public static bool flowerE_Collected = false;

    public static bool flowerG_Collected = false;
    // public static bool flowerAllCollected = false;

    private Inventory inventory;

    public GameObject itemButton;
    // GameObject currentButton;

    private void Awake()
    {
        inventory =
            GameObject
                .FindGameObjectWithTag("Player")
                .GetComponent<Inventory>();
    }

    // Start is called before the first frame update
    void Start()
    {
        // hide E
        pickUpText.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        // if (
        //     FlowerPicked.flowerC_Collected &&
        //     FlowerPicked.flowerE_Collected &&
        //     FlowerPicked.flowerG_Collected &&
        //     flowerAllCollected == false
        // )
        // {
        //     flowerAllCollected = true;
        // }
        // flowerAllCollected = true; // for test
        // if (flowerAllCollected)
        // {
        //     for (int i = 0; i < inventory.slots.Length; i++)
        //     {
        //         if (
        //             inventory.isFull[i] &&
        //             itemButton.name == "flower_C_button" ||
        //             itemButton.name == "flower_E_button" ||
        //             itemButton.name == "flower_G_button"
        //         )
        //         {
        //             Destroy(currentButton);
        //         }
        //         if (inventory.isFull[i] == false)
        //         {
        //             inventory.isFull[i] = true;
        //             currentButton = Instantiate(itemButton,
        //             inventory.slots[i].transform,
        //             false);
        //             Destroy (gameObject);
        //             break;
        //         }
        //     }
        //     return;
        // }
        if (
            pickUpAllowed &&
            Input.GetKeyDown(KeyCode.E) &&
            PuzzleCollider.alreadyPickup &&
            (
            flowerSound.ToString() == "C_cut (UnityEngine.AudioClip)" ||
            flowerSound.ToString() == "E_cut (UnityEngine.AudioClip)" ||
            flowerSound.ToString() == "G_cut (UnityEngine.AudioClip)"
            )
        )
        {
            if (flowerSound.ToString() == "C_cut (UnityEngine.AudioClip)")
            {
                flowerC_Collected = true;
                for (int i = 0; i < inventory.slots.Length; i++)
                {
                    // if (
                    //     PuzzleCollider.alreadyPickup &&
                    //     InspireItem.pickUpAllowed
                    // )
                    // {
                    // print(itemButton.name);
                    if (inventory.isFull[i] == false)
                    {
                        inventory.isFull[i] = true;
                        Instantiate(itemButton,
                        inventory.slots[i].transform,
                        false);
                        Destroy (gameObject);
                        break;
                    }
                    // }
                }
            }
            else if (flowerSound.ToString() == "E_cut (UnityEngine.AudioClip)")
            {
                flowerE_Collected = true;
                for (int i = 0; i < inventory.slots.Length; i++)
                {
                    // if (
                    //     PuzzleCollider.alreadyPickup &&
                    //     InspireItem.pickUpAllowed
                    // )
                    // {
                    // print(itemButton.name);
                    if (inventory.isFull[i] == false)
                    {
                        inventory.isFull[i] = true;
                        Instantiate(itemButton,
                        inventory.slots[i].transform,
                        false);
                        Destroy (gameObject);
                        break;
                    }
                    // }
                }
            }
            else if (flowerSound.ToString() == "G_cut (UnityEngine.AudioClip)")
            {
                flowerG_Collected = true;
                for (int i = 0; i < inventory.slots.Length; i++)
                {
                    // if (
                    //     PuzzleCollider.alreadyPickup &&
                    //     InspireItem.pickUpAllowed
                    // )
                    // {
                    // print(itemButton.name);
                    if (inventory.isFull[i] == false)
                    {
                        inventory.isFull[i] = true;
                        Instantiate(itemButton,
                        inventory.slots[i].transform,
                        false);
                        Destroy (gameObject);
                        break;
                    }
                    // }
                }
            }
            print(flowerSound.ToString());

            // delete flower
            Destroy (gameObject);
        }
    }

    // pop up E when player collide
    void OnTriggerEnter2D(Collider2D collision)
    {
        PandoraController controller =
            collision.GetComponent<PandoraController>();
        print(PuzzleCollider.alreadyPickup);
        if (
            collision.gameObject.tag.Equals("Player") &&
            PuzzleCollider.alreadyPickup
        )
        {
            pickUpText.SetActive(true);
            pickUpAllowed = true;
            print (flowerSound);
            controller.PlaySound (flowerSound);
        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            pickUpText.SetActive(false);
            pickUpAllowed = false;
        }
    }
}
