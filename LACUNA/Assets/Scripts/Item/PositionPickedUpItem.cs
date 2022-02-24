using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionPickedUpItem : MonoBehaviour
{
    GameObject pandora;

    // Update is called once per frame
    void Update()
    {
        // get pandora position
        pandora = GameObject.FindWithTag("Player");
        Transform pandoraTransform = pandora.transform;
        Vector2 pandoraPosition = pandoraTransform.position;

        //change position to pandora's hands
        Vector2 tempPosition = pandoraPosition;
        tempPosition.x = pandoraPosition.x + 0.9f;
        tempPosition.y = pandoraPosition.y - 0.5f;
        transform.position = tempPosition;
    }
}
