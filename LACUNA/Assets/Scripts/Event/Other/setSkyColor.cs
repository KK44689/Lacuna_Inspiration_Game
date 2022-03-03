using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setSkyColor : MonoBehaviour
{
    SpriteRenderer SpriteRenderer;

    // load/save variable
    [SerializeField]
    private GameplayDialogueData GameplayDialogueData;

    // Update is called once per frame
    void FixedUpdate()
    {
        //Fetch the SpriteRenderer from the GameObject
        SpriteRenderer = GetComponent<SpriteRenderer>();

        //Set the GameObject's Color quickly to a set Color (blue)
        SpriteRenderer.color = GameplayDialogueData.skyColor;
    }
}
