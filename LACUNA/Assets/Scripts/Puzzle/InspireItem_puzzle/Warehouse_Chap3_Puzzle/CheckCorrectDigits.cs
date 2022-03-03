using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CheckCorrectDigits : MonoBehaviour
{
    TextMeshProUGUI textMesh;

    public int correctDigit;

    public int orderDigit;

    public static bool[] isCorrect;

    bool correct = false;

    // load/save variables
    [SerializeField]
    private PuzzleData PuzzleData;

    void Start()
    {
        textMesh = GetComponent<TextMeshProUGUI>();
        isCorrect = new bool[4] { false, false, false, false };

        // make code value = data value
        GenInspireItem.puzzleSolved = PuzzleData.inspireItem_puzzle_solved;
    }

    void Update()
    {
        isCorrectDigits();
        allCorrect();
        if (correct)
        {
            GenInspireItem.puzzleSolved = true;
            PuzzleData.inspireItem_puzzle_solved = GenInspireItem.puzzleSolved;
        }
    }

    void allCorrect()
    {
        for (int i = 0; i < isCorrect.Length; i++)
        {
            if (!isCorrect[i])
            {
                correct = false;
                return;
            }
            correct = true;
        }
    }

    void isCorrectDigits()
    {
        if (textMesh.text == correctDigit.ToString())
        {
            isCorrect[orderDigit] = true;
        }
        else
        {
            isCorrect[orderDigit] = false;
        }
    }
}
