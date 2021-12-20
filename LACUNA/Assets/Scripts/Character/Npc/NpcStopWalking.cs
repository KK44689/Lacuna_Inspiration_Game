using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcStopWalking : MonoBehaviour
{
    // public GameObject destroyedCollider;
    // public GameObject nextCollider;
    // public bool continueWalking;
    // bool npcEnter = false;
    // Start is called before the first frame update
    void Start()
    {
        // nextCollider.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        // if (continueWalking)
        // {
        //     if (
        //         !(DialogueManager.activeMessage <
        //         DialogueManager.currentMessagesLength) &&
        //         npcEnter
        //     )
        //     {
        //         nextCollider.SetActive(true);
        //     }
        // }
        // else
        // {
        //     if (
        //         !(DialogueManager.activeMessage <
        //         DialogueManager.currentMessagesLength) &&
        //         npcEnter
        //     )
        //     {
        //         nextCollider.SetActive(false);
        //     }
        // }
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag.Equals("NPC"))
        {
            NpcController.move = false;
            NpcController.moveNotWait = false;
            // print(collider.name);
            // destroyedCollider.SetActive(false);
            // npcEnter = true;
            // print(NpcController.sceneID);
            // switch(NpcController.sceneID){
            //     case 1:
            //         GameObject.Find("grandmaStartWalking_1").SetActive(false);
            //         break;
            // }
        }
    }
    // private void OnTriggerExit2D(Collider2D collider)
    // {
    //     if (collider.gameObject.tag.Equals("NPC"))
    //     {
    //         // npcEnter = false;
    //         // print(NpcController.sceneID);
    //         // switch(NpcController.sceneID){
    //         //     case 1:
    //         //         GameObject.Find("grandmaStartWalking_1").SetActive(false);
    //         //         break;
    //         // }
    //     }
    // }
}
