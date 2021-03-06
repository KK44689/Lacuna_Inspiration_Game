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

    // load/save variables
    [SerializeField]
    private PuzzleData PuzzleData;

    void Start(){
        GenInspireItem.puzzleSolved = PuzzleData.inspireItem_puzzle_solved;
    }

    // Update is called once per frame
    public void CheckCorrectAnswer()
    {
        for (int i = 0; i < 15; i++)
        {
            answer +=
                Inputs
                    .transform
                    .GetChild(i)
                    .GetComponent<TMP_InputField>()
                    .text;
        }
        if (answer.ToLower().Contains("mylittlevangogh"))
        {
            Puzzle.SetActive(false);
            PuzzleCollider.GetComponent<BoxCollider2D>().enabled = false;
            GenInspireItem.puzzleSolved = true;
            PuzzleData.inspireItem_puzzle_solved = GenInspireItem.puzzleSolved;
        }
    }
}
