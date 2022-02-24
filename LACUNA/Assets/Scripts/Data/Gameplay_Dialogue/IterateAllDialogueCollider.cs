using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IterateAllDialogueCollider : MonoBehaviour
{
    // load/save gameplay dialogue variables
    [SerializeField]
    private GameplayDialogueData GameplayDialogueData;

    private int index = 0;

    // Start is called before the first frame update
    void Start()
    {
        // set real asset states = data
        index = 0;
        for (int i = 0; i < transform.childCount; i++)
        {
            for (int j = 0; j < transform.GetChild(i).childCount; j++)
            {
                // Debug.Log(transform.GetChild(i).GetChild(j));
                transform
                    .GetChild(i)
                    .GetChild(j)
                    .gameObject
                    .SetActive(GameplayDialogueData.colliderIsActive[index]);
                index++;
            }
        }
        GameplayDialogueData.colliderIsActive = new bool[index];
    }

    // Update is called once per frame
    void Update()
    {
        // set data = real asset states
        index = 0;
        for (int i = 0; i < transform.childCount; i++)
        {
            for (int j = 0; j < transform.GetChild(i).childCount; j++)
            {
                GameplayDialogueData.colliderIsActive[index] =
                    transform
                        .GetChild(i)
                        .GetChild(j)
                        .gameObject
                        .activeInHierarchy;
                index++;
            }
        }
    }
}
