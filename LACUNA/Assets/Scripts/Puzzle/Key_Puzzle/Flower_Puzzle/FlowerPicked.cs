using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlowerPicked : MonoBehaviour
{
    // pop up E
    public GameObject pickUpText;

    // check that it's player who pick up
    bool pickUpAllowed;

    // sound variables
    AudioSource audioSource;

    public AudioClip flowerSound;

    // collected flower variable
    public static bool flowerC_Collected = false;

    public static bool flowerE_Collected = false;

    public static bool flowerG_Collected = false;

    // inventory variables
    private Inventory inventory;

    public GameObject itemButton;

    // load/save variables
    [SerializeField]
    private ItemData ItemData;

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

        // make code values equals data
        flowerC_Collected = ItemData.flower1;
        flowerE_Collected = ItemData.flower2;
        flowerG_Collected = ItemData.flower3;
    }

    // Update is called once per frame
    void Update()
    {
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
                    if (inventory.isFull[i] == false)
                    {
                        inventory.isFull[i] = true;
                        Instantiate(itemButton,
                        inventory.slots[i].transform,
                        false);
                        Destroy (gameObject);
                        break;
                    }
                }
            }
            else if (flowerSound.ToString() == "E_cut (UnityEngine.AudioClip)")
            {
                flowerE_Collected = true;
                for (int i = 0; i < inventory.slots.Length; i++)
                {
                    if (inventory.isFull[i] == false)
                    {
                        inventory.isFull[i] = true;
                        Instantiate(itemButton,
                        inventory.slots[i].transform,
                        false);
                        Destroy (gameObject);
                        break;
                    }
                }
            }
            else if (flowerSound.ToString() == "G_cut (UnityEngine.AudioClip)")
            {
                flowerG_Collected = true;
                for (int i = 0; i < inventory.slots.Length; i++)
                {
                    if (inventory.isFull[i] == false)
                    {
                        inventory.isFull[i] = true;
                        Instantiate(itemButton,
                        inventory.slots[i].transform,
                        false);
                        Destroy (gameObject);
                        break;
                    }
                }
            }

            //save data
            ItemData.flower1 = flowerC_Collected;
            ItemData.flower2 = flowerE_Collected;
            ItemData.flower3 = flowerG_Collected;

            // delete flower
            Destroy (gameObject);
        }
    }

    // pop up E when player collide
    void OnTriggerEnter2D(Collider2D collision)
    {
        PandoraController controller =
            collision.GetComponent<PandoraController>();
        if (
            collision.gameObject.tag.Equals("Player") &&
            PuzzleCollider.alreadyPickup
        )
        {
            pickUpText.SetActive(true);
            pickUpAllowed = true;
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
