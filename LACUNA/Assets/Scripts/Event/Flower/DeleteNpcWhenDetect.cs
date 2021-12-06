using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteNpcWhenDetect : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag.Equals("NPC"))
        {
            if (DestroyFlowerUI.flowerAllCollected == false)
            {
                GameObject temp;
                temp = GameObject.FindWithTag("NPC");
                temp.SetActive(false);
            }
        }
    }
}
