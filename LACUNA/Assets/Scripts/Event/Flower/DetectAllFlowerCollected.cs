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
        // when
        if (DestroyFlowerUI.flowerAllCollected && alreadyTalk == false)
        {
            // active grandma
            Npc.SetActive(true);

            // play dialogue when all flower collected
            trigger.StartDialogue();
            allFlowerCollectedDialogue.SetActive(true);

            // active next hint and delete prev hint
            hintButtonPrev.SetActive(false);
            hintButtonNext.SetActive(true);
            alreadyTalk = true;
        }
    }
}
