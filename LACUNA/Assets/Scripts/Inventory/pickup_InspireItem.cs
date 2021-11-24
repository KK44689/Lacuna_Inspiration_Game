using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickup_InspireItem : MonoBehaviour
{
    private Inventory inventory;

    public GameObject itemButton;

    private void Awake()
    {
        inventory =
            GameObject
                .FindGameObjectWithTag("Player")
                .GetComponent<Inventory>();
    }

    void Update()
    {
        // print(inventory.slots.Length);
        // if (others.CompareTag("Player"))
        // {
        for (int i = 0; i < inventory.slots.Length; i++)
        {
            if (PuzzleCollider.alreadyPickup && InspireItem.pickUpAllowed)
            {
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
            }
        }
        // }
    }
}
