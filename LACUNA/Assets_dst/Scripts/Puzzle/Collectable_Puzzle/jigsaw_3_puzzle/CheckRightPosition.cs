using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckRightPosition : MonoBehaviour
{
    List<bool> CheckRightPos = new List<bool>();
    public GameObject PuzzleContainer;

    bool allCorrect = false;

    // Start is called before the first frame update
    void Start()
    {
        print(CheckRightPos.Count);
        for (int i = 0; i < 36; i++)
        {
            CheckRightPos.Add(false);
            // print(i.ToString() + CheckRightPos[i].ToString());
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (CheckAllCorrect())
        {
            GenCollectable.challangeSolved = true;
            PuzzleContainer.SetActive(false);
        }
    }

    bool CheckAllCorrect()
    {
        foreach (Transform child in this.transform)
        {
            if (!child.GetComponent<pieceScript2>().InRightPosition)
            {
                return false;
            }
        }
        return true;
    }
}
