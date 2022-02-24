using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToPlayerPos : MonoBehaviour
{
    GameObject pandora;

    // Update is called once per frame
    void Update()
    {
        // move this gameobject to player position
        pandora = GameObject.FindWithTag("Player");
        transform.position = pandora.transform.position;
    }
}
