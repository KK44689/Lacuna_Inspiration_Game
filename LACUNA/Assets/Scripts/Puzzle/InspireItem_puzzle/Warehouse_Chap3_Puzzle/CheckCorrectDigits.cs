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

    void Start()
    {
        textMesh = GetComponent<TextMeshProUGUI>();
        isCorrect = new bool[4] { false, false, false, false };
    }

    void Update()
    {
        isCorrectDigits();
        allCorrect();
        if (correct)
        {
            GenInspireItem.puzzleSolved = true;
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
