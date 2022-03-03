using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSkyColor : MonoBehaviour
{
    public GameObject sky;

    SpriteRenderer SpriteRenderer;

    //The Color to be assigned to the Renderer’s Material
    public Color NewColor;

    // load/save variable
    [SerializeField]
    private GameplayDialogueData GameplayDialogueData;

    // Start is called before the first frame update
    void Start()
    {
        //Fetch the SpriteRenderer from the GameObject
        SpriteRenderer = sky.GetComponent<SpriteRenderer>();

        //Set the GameObject's Color quickly to a set Color (blue)
        SpriteRenderer.color = NewColor;
        GameplayDialogueData.skyColor = SpriteRenderer.color;
    }
}
