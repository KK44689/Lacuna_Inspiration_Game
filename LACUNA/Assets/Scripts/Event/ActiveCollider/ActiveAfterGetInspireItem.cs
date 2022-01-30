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
        if(PuzzleCollider.alreadyPickup){
            nextCollider.SetActive(true);
        }
    }
}
