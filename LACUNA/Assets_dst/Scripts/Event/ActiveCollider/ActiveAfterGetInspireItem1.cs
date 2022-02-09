using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveAfterGetInspireItem1 : MonoBehaviour
{
    public GameObject collider;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(GenInspireItem.inspireItemPicked){
            print("move");
            collider.SetActive(true);
        }
    }
}
