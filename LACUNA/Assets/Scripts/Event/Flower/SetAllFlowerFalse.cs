using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetAllFlowerFalse : MonoBehaviour
{
    GameObject allFlowerCollider;

    [SerializeField]
    private ItemData ItemData;

    void Start()
    {
        allFlowerCollider = GameObject.Find("DetectAllFlower");
    }

    // Update is called once per frame
    void Update()
    {
        if (ItemData.allFlowerCollected)
        {
            // ItemData.allFlowerCollected = false;
            Destroy(allFlowerCollider.GetComponent<DetectAllFlowerCollected>());
            // Destroy(allFlowerCollider.GetComponent<DialogueTrigger>());
        }
    }
}
