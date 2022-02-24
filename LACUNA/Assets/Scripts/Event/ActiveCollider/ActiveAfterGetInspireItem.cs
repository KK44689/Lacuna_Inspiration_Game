using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveAfterGetInspireItem : MonoBehaviour
{
    public GameObject nextCollider;
    // Start is called before the first frame update
    void Start()
    {
        nextCollider.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        // player collect inspire item -> active collider (chapter 1)
        if(PuzzleCollider.alreadyPickup){
            nextCollider.SetActive(true);
        }
    }
}
