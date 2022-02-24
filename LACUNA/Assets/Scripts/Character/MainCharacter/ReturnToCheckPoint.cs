using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReturnToCheckPoint : MonoBehaviour
{
    public static bool ReturnCheckPoint = false;

    public static string checkPoint;

    GameObject checkPointPos;

    public GameObject gameOver;

    // Update is called once per frame
    void Update()
    {
        if (ReturnCheckPoint)
        {
            ReturnPandoraToCheckpoint(checkPoint);
        }
    }

    void ReturnPandoraToCheckpoint(string checkpoint)
    {
        // move player to checkpoint base on monster position
        switch (checkpoint)
        {
            case "checkpoint1":
                checkPointPos = GameObject.Find("checkpoint1");
                transform.position = checkPointPos.transform.position;
                EnemyController.gameover = false;
                ReturnCheckPoint = false;
                gameOver.SetActive(false);
                break;
            case "checkpoint2":
                checkPointPos = GameObject.Find("checkpoint2");
                transform.position = checkPointPos.transform.position;
                EnemyController.gameover = false;
                ReturnCheckPoint = false;
                gameOver.SetActive(false);
                break;
        }
    }
}
