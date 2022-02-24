using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlowerTutorial : MonoBehaviour
{
    // pop up E
    public GameObject pickUpText;

    public GameObject tutorialText_correct;

    public GameObject tutorialText_wrong;

    private Inventory inventory;

    public GameObject itemButton;

    // check that it's player who pick up
    bool pickUpAllowed;

    AudioSource audioSource;

    public AudioClip flowerSound;

    public static bool flowerCorrect_Collected = false;

    public static bool flowerTutorial_stop = false;

    public static bool flowerWrong_Collected = false;

    // Start is called before the first frame update
    void Start()
    {
        // hide E
        pickUpText.SetActive(false);
        inventory =
            GameObject
                .FindGameObjectWithTag("Player")
                .GetComponent<Inventory>();
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
            flowerCorrect_Collected = true;
            flowerTutorial_stop = true;
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
            tutorialText_correct.SetActive(false);
            tutorialText_wrong.SetActive(false);

            // delete flower
            Destroy (gameObject);
        }
        else if (
            pickUpAllowed &&
            Input.GetKeyDown(KeyCode.E) &&
            PuzzleCollider.alreadyPickup &&
            (
            flowerSound.ToString() == "F_cut (UnityEngine.AudioClip)" ||
            flowerSound.ToString() == "A_cut (UnityEngine.AudioClip)" ||
            flowerSound.ToString() == "B_cut (UnityEngine.AudioClip)"
            )
        )
        {
            flowerWrong_Collected = true;
            tutorialText_wrong.SetActive(false);
        }
    }

    // pop up E when player collide
    void OnTriggerEnter2D(Collider2D collision)
    {
        PandoraController controller =
            collision.GetComponent<PandoraController>();
        if (
            collision.gameObject.tag.Equals("Player") &&
            PuzzleCollider.alreadyPickup &&
            EnableFlowerTutorial.flowerTutorialAwake
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
