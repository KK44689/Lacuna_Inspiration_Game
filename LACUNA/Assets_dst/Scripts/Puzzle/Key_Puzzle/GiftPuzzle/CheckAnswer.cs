using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CheckAnswer : MonoBehaviour
{
    public GameObject Inputs;
    public GameObject Puzzle;
    public GameObject PuzzleCollider;

    string answer = "";

    // Update is called once per frame
    public void CheckCorrectAnswer()
    {
        for (int i = 0; i < 15; i++)
        {
            answer += Inputs.transform.GetChild(i).GetComponent<TMP_InputField>().text;
            // print(Inputs.transform.GetChild(i).GetComponent<TMP_InputField>().text);
        }
        if(answer.ToLower().Contains("mylittlevangogh")){
            Puzzle.SetActive(false);
            PuzzleCollider.GetComponent<BoxCollider2D>().enabled = false;
            GenInspireItem.puzzleSolved = true;
            // print("correct");
        }
        print(answer);
    }
}
