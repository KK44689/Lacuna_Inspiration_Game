using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAllItemUI : MonoBehaviour
{
    // bool alreadyDestroy = false;
    private Inventory inventory;

    public int i;

    // public GameObject keyItemButton;
    // Start is called before the first frame update
    void Start()
    {
        inventory =
            GameObject
                .FindGameObjectWithTag("Player")
                .GetComponent<Inventory>();
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < inventory.slots.Length; i++)
        {
            inventory.isFull[i] = false;
        }
    }

    public void destroyItemUI()
    {
        for (int i = 0; i < inventory.slots.Length; i++)
        {
            foreach (Transform child in inventory.slots[i].transform)
            {
                GameObject.Destroy(child.gameObject);
            }
        }
        // alreadyDestroy = true;
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            destroyItemUI();
        }
    }
}
