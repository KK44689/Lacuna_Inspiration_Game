using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CheckCorrectDigits : MonoBehaviour
{
    TextMeshProUGUI textMesh;

    public int correctDigit;

    public int orderDigit;

    // bool

    //         digit1_solve,
    //         digit2_solve,
    //         digit3_solve,
    //         digit4_solve;

    public static bool[] isCorrect;

    bool correct = false;

    // List<bool> allCorrect = new List<bool> { false, false, false, false };
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
            print("gen inspire");
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
        else{
            isCorrect[orderDigit] = false;
        }
    }
}
