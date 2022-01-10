using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideUI : MonoBehaviour
{
    public GameObject UI_Interface;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(DialogueManager.isActive){
            UI_Interface.SetActive(false);
        }
        else{
            UI_Interface.SetActive(true);
        }
    }
}
