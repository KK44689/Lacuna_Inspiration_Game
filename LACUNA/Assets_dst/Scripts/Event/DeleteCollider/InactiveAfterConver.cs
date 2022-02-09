using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InactiveAfterConver : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if(DialogueManager.isActive == false){
            gameObject.SetActive(false);
        }
    }
}
