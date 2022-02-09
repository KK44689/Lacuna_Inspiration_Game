using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToPlayerPos : MonoBehaviour
{
    GameObject pandora;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        pandora = GameObject.FindWithTag("Player");
        transform.position = pandora.transform.position;
        
    }
}
