using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setDialogueFalse : MonoBehaviour
{
    [SerializeField]
    private GameplayDialogueData GameplayDialogueData;

    // Start is called before the first frame update
    void Start()
    {
        GameplayDialogueData.colliderIsActive[29] = false;
        GameplayDialogueData.colliderIsActive[30] = false;
        GameplayDialogueData.colliderIsActive[31] = true;
    }

    // Update is called once per frame
    void Update()
    {
        GameplayDialogueData.colliderIsActive[29] = false;
        GameplayDialogueData.colliderIsActive[30] = false;
        GameplayDialogueData.colliderIsActive[31] = true;
    }
}
