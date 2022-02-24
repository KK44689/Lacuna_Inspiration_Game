using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckAllKidsTalk : MonoBehaviour
{
    public GameObject Doors;

    // Start is called before the first frame update
    void Start()
    {
        foreach (Transform child in Doors.transform)
        {
            child.GetComponent<BoxCollider2D>().enabled = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (CheckAllTalk())
        {
            foreach (Transform child in Doors.transform)
            {
                child.GetComponent<BoxCollider2D>().enabled = true;
            }
        }
        else
        {
            foreach (Transform child in Doors.transform)
            {
                child.GetComponent<BoxCollider2D>().enabled = false;
            }
        }
    }

    bool CheckAllTalk()
    {
        foreach (Transform child in this.transform)
        {
            if (!child.GetComponent<SetBoolTalks>().kid_talk)
            {
                return false;
            }
        }
        return true;
    }
}
