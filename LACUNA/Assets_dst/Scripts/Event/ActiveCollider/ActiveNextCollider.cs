using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveNextCollider : MonoBehaviour
{
    public GameObject NextCollider;
    // Start is called before the first frame update
    void Awake()
    {
        NextCollider.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
