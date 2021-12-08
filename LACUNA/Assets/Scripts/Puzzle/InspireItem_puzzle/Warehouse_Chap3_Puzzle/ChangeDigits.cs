using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ChangeDigits : MonoBehaviour
{
    TextMeshProUGUI textMesh;

    public int digit;
    public GameObject Digit;


    // Start is called before the first frame update
    void Start()
    {
        textMesh = Digit.GetComponent<TextMeshProUGUI>();
        digit = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void IncreaseDigit()
    {
        this.digit++;
        textMesh.text = digit.ToString();
        if (digit > 9)
        {
            digit = 0;
            textMesh.text = digit.ToString();
        }
    }

    public void DecreaseDigit()
    {
        this.digit--;
        textMesh.text = digit.ToString();
        if (digit < 0)
        {
            digit = 9;
            textMesh.text = digit.ToString();
        }
    }
}
