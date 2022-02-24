using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogTutorial : MonoBehaviour
{
    public GameObject tutorialText;

    // Update is called once per frame
    void Update()
    {
        if (EnemyController.monsterInactive)
        {
            tutorialText.SetActive(false);
        }
    }
}
