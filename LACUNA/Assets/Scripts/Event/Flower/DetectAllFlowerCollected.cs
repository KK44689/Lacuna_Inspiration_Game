using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectAllFlowerCollected : MonoBehaviour
{
    public GameObject allFlowerCollectedDialogue;

    public DialogueTrigger trigger;

    public GameObject hintButtonPrev;
    public GameObject hintButtonNext;

    GameObject Npc;

    bool alreadyTalk = false;

    // Start is called before the first frame update
    void Start()
    {
        allFlowerCollectedDialogue.SetActive(false);
        Npc = GameObject.FindWithTag("NPC");
        hintButtonPrev.SetActive(false);
        hintButtonNext.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (DestroyFlowerUI.flowerAllCollected && alreadyTalk == false)
        {
            print("flower collected");
            Npc.SetActive(true);
            trigger.StartDialogue();
            allFlowerCollectedDialogue.SetActive(true);
            hintButtonPrev.SetActive(false);
            hintButtonNext.SetActive(true);
            alreadyTalk = true;
        }
    }

    // private void OnTriggerEnter2D(Collider2D collider)
    // {
    //     if (collider.gameObject.tag.Equals("NPC"))
    //     {
    //         if (DestroyFlowerUI.flowerAllCollected == false)
    //         {
    //             GameObject temp;
    //             temp = GameObject.FindWithTag("NPC");
    //             temp.SetActive(false);
    //         }
    //     }
    // }
}
