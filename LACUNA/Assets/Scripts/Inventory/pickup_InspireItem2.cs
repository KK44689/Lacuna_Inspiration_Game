using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickup_InspireItem2 : MonoBehaviour
{
    private Inventory inventory;

    public GameObject itemButton;

    private void Awake()
    {
        // get inventory from player
        inventory =
            GameObject
                .FindGameObjectWithTag("Player")
                .GetComponent<Inventory>();
    }

    void Update()
    {
        for (int i = 0; i < inventory.slots.Length; i++)
        {
            if (GenInspireItem.inspireItemPicked && InspireItem.pickUpAllowed)
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
    }
}
