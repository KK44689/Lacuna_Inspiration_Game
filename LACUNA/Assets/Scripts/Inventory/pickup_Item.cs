using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickup_Item : MonoBehaviour
{
    private Inventory inventory;

    public GameObject itemButton;

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

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            for (int i = 0; i < inventory.slots.Length; i++)
            {
                if (inventory.isFull[i] == false)
                {
                    // ItemData.souvenir = true;
                    // Destroy (gameObject);
                    // inventory.isFull[i] = true;
                    // Instantiate(itemButton,
                    // inventory.slots[i].transform,
                    // false);
                    ItemData.souvenir = true;
                    break;
                }
            }
        }
    }
}
