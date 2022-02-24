using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAllItemUI : MonoBehaviour
{
    private Inventory inventory;

    public int i;

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
        // make inventory empty
        for (int i = 0; i < inventory.slots.Length; i++)
        {
            inventory.isFull[i] = false;
        }
    }

    public void destroyItemUI()
    {
        // delete item icon in inventory
        for (int i = 0; i < inventory.slots.Length; i++)
        {
            foreach (Transform child in inventory.slots[i].transform)
            {
                GameObject.Destroy(child.gameObject);
            }
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            destroyItemUI();
        }
    }
}
