using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyFlowerUI : MonoBehaviour
{
    bool alreadyDestroy = false;

    private Inventory inventory;

    public GameObject keyItemButton;

    public static bool flowerAllCollected = false;

    // load/save variables
    [SerializeField]
    private ItemData ItemData;

    void Awake()
    {
        // get inventory from player
        inventory =
            GameObject
                .FindGameObjectWithTag("Player")
                .GetComponent<Inventory>();
    }

    void Start()
    {
        // make code value = data value
        flowerAllCollected = ItemData.allFlowerCollected;
        alreadyDestroy = ItemData.allFlower_alreadyDestroy;
    }

    void Update()
    {
        // all flower collected delete all flower icon in inventory
        if (
            FlowerPicked.flowerC_Collected &&
            FlowerPicked.flowerE_Collected &&
            FlowerPicked.flowerG_Collected &&
            flowerAllCollected == false
        )
        // &&
        // alreadyDestroy == false
        {
            // destroyFlowerUI();
            // for (int i = 4; i > 0; i--)
            // {
            //     inventory.isFull[i] = false;
            // }
            // for (int i = 0; i < inventory.slots.Length; i++)
            // {
            //     if (inventory.isFull[i] == false)
            //     {
            //         inventory.isFull[i] = true;
            //         Instantiate(keyItemButton,
            //         inventory.slots[i].transform,
            //         false);
            //     }
            // }
            flowerAllCollected = true;
        }

        // else
        // {
        //     for (int i = 0; i < inventory.slots.Length; i++)
        //     {
        //         if (
        //             FlowerPicked.flowerC_Collected &&
        //             FlowerPicked.flowerE_Collected &&
        //             FlowerPicked.flowerG_Collected &&
        //             flowerAllCollected == false && alreadyDestroy
        //         )
        //         {
        //             if (inventory.isFull[i] == false)
        //             {
        //                 inventory.isFull[i] = true;
        //                 Instantiate(keyItemButton,
        //                 inventory.slots[i].transform,
        //                 false);
        //                 flowerAllCollected = true;
        //             }
        //         }
        //     }
        // }
        //save data
        ItemData.allFlowerCollected = flowerAllCollected;
        ItemData.allFlower_alreadyDestroy = alreadyDestroy;
    }

    // public void destroyFlowerUI()
    // {
    //     // delete item icon in inventory
    //     foreach (Transform child in transform)
    //     {
    //         GameObject.Destroy(child.gameObject);
    //     }
    //     alreadyDestroy = true;
    // }
}
