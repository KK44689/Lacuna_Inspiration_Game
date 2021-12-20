using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcStopWalking2 : MonoBehaviour
{
    GameObject pandora;

    Vector2 pandoraPosition;

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
            NpcController.move = false;
            NpcController.moveNotWait = false;
        }
    }
}
