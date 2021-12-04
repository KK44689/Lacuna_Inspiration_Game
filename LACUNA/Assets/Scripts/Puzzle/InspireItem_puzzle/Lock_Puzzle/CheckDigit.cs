using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckDigit : MonoBehaviour
{
    public static int[] digits;
    public static int[] correctNumber;
    public static bool[] isCorrect;

    // Start is called before the first frame update
    void Start()
    {
        digits = new int[4] { 0, 0, 0, 0 };
        correctNumber = new int[4] { 4, 6, 3, 5 };
        isCorrect = new bool[4] { false, false, false, false };
        // foreach (float digit in digits)
        // {
        //     print (digit);
        // }
    }

    // Update is called once per frame
    void Update()
    {
    }

    public static bool CheckDigits()
    {
        for (int i = 0; i < 4; i++)
        {
            if (digits[i] == correctNumber[i])
            {
                isCorrect[i] = true;
            }
        }
        for (int i = 0; i < 4; i++)
        {
            if (isCorrect[i] == false)
            {
                return false;
            }
        }
        PuzzleCollider.puzzleSolved = true;
        return true;
    }
}
