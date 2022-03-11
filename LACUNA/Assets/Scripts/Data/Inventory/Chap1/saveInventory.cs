using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class saveInventory : MonoBehaviour
{
    private Inventory inventory;

    public GameObject inspireItemButton;

    public GameObject flower1_Button;

    public GameObject flower2_Button;

    public GameObject flower3_Button;
    public GameObject allFlower_Button;

    public GameObject flowerTutorial_Button;
    public GameObject souvenir_Button;

    // load/save data variable
    [SerializeField]
    private PuzzleData PuzzleData;

    [SerializeField]
    private ItemData ItemData;

    // Start is called before the first frame update
    void Start()
    {
        // get inventory from player
        inventory =
            GameObject
                .FindGameObjectWithTag("Player")
                .GetComponent<Inventory>();
    }

    // Update is called once per frame
    void Update()
    {
        // show inspire item in inventory
        if (PuzzleData.inspireItem_alreadyPicked)
        {
            for (int i = 0; i < inventory.slots.Length; i++)
            {
                if (inventory.isFull[i] == false)
                {
                    inventory.isFull[i] = true;
                    Instantiate(inspireItemButton,
                    inventory.slots[i].transform,
                    false);
                    Destroy (gameObject);
                    break;
                }
            }
        }

        // show flower1 in inventory
        if (ItemData.flower1)
        {
            for (int i = 0; i < inventory.slots.Length; i++)
            {
                if (inventory.isFull[i] == false)
                {
                    inventory.isFull[i] = true;
                    Instantiate(flower1_Button,
                    inventory.slots[i].transform,
                    false);
                    Destroy (gameObject);
                    break;
                }
            }
        }

        // show flower2 in inventory
        if (ItemData.flower2)
        {
            for (int i = 0; i < inventory.slots.Length; i++)
            {
                if (inventory.isFull[i] == false)
                {
                    inventory.isFull[i] = true;
                    Instantiate(flower2_Button,
                    inventory.slots[i].transform,
                    false);
                    Destroy (gameObject);
                    break;
                }
            }
        }

        // show flower3 in inventory
        if (ItemData.flower3)
        {
            for (int i = 0; i < inventory.slots.Length; i++)
            {
                if (inventory.isFull[i] == false)
                {
                    inventory.isFull[i] = true;
                    Instantiate(flower3_Button,
                    inventory.slots[i].transform,
                    false);
                    Destroy (gameObject);
                    break;
                }
            }
        }

        // show flowerTutorial in inventory
        if (ItemData.flowerTutorialRight)
        {
            for (int i = 0; i < inventory.slots.Length; i++)
            {
                if (inventory.isFull[i] == false)
                {
                    inventory.isFull[i] = true;
                    Instantiate(flowerTutorial_Button,
                    inventory.slots[i].transform,
                    false);
                    Destroy (gameObject);
                    break;
                }
            }
        }
        // show bouquet in inventory
        if (ItemData.allFlowerCollected && ItemData.allFlower_alreadyDestroy)
        {
            for (int i = 0; i < inventory.slots.Length; i++)
            {
                if (inventory.isFull[i] == false)
                {
                    inventory.isFull[i] = true;
                    Instantiate(allFlower_Button,
                    inventory.slots[i].transform,
                    false);
                    Destroy (gameObject);
                    break;
                }
            }
        }

        // show souvenir item in inventory
        // if (ItemData.souvenir)
        // {
        //     for (int i = 0; i < inventory.slots.Length; i++)
        //     {
        //         if (inventory.isFull[i] == false)
        //         {
        //             inventory.isFull[i] = true;
        //             Instantiate(souvenir_Button,
        //             inventory.slots[i].transform,
        //             false);
        //             print("saveinventory");
        //             Destroy (gameObject);
        //             break;
        //         }
        //     }
        // }
    }
}
