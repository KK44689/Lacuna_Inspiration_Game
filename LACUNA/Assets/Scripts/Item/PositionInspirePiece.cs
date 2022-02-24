using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionInspirePiece : MonoBehaviour
{
    GameObject pandora;

    float delay = 0.3f;

    // Update is called once per frame
    void Update()
    {
        // get pandora position
        pandora = GameObject.FindWithTag("Player");
        Transform pandoraTransform = pandora.transform;
        Vector2 pandoraPosition = pandoraTransform.position;
        Vector2 tempPosition = transform.position;
        if ((tempPosition.y - pandoraPosition.y) > 3)
        {
            print("destroy");
            Destroy (gameObject);
        }
        if (delay <= 0)
        {
            tempPosition.y += 0.5f;
            delay = 0.3f;
        }
        else if (delay > 0)
        {
            delay -= 1f * Time.deltaTime;
        }
        transform.position = tempPosition;
    }
}
