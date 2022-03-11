using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetLibraryInactive : MonoBehaviour
{
    public GameObject collider;
    // Start is called before the first frame update
    void Start()
    {
        collider.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        collider.SetActive(false);
        
    }
}
