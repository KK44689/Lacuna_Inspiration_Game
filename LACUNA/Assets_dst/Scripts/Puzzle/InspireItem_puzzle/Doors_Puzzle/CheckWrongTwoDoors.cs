using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckWrongTwoDoors : MonoBehaviour
{
    GameObject Kids;

    public GameObject fadeBlack;

    // Start is called before the first frame update
    void Start()
    {
        Kids = GameObject.Find("Kids");
    }

    // Update is called once per frame
    void Update()
    {
        CheckWrongDoors();
    }

    void CheckWrongDoors()
    {
        if (SetBoolDoors.wrong_doors >= 2)
        {
            foreach (Transform child in Kids.transform)
            {
                child.GetComponent<SetBoolTalks>().kid_talk = false;
            }
            fadeBlack.SetActive(true);
            SetBoolDoors.wrong_doors = 0;
            foreach (Transform child in this.transform)
            {
                child.GetComponent<BoxCollider2D>().enabled = false;
            }
        }
    }
}
