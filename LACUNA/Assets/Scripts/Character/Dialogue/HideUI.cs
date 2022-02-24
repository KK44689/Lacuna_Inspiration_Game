using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideUI : MonoBehaviour
{
    public GameObject UI_Interface;

    // Update is called once per frame
    void Update()
    {
        // check if dialogue box active -> hide UI
        if (DialogueManager.isActive)
        {
            UI_Interface.SetActive(false);
        }
        else
        {
            UI_Interface.SetActive(true);
        }
    }
}
