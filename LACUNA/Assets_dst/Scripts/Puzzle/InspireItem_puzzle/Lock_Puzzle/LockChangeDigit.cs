using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LockChangeDigit : MonoBehaviour
{
    TextMeshProUGUI textMesh;

    int digit;

    public int correctNumber;

    public int orderDigit;

    string orderArrow;

    void Start()
    {
        textMesh = GetComponent<TextMeshProUGUI>();
        digit = 0;
        orderArrow = (orderDigit + 1).ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit2D hit =
                Physics2D
                    .Raycast(Camera
                        .main
                        .ScreenToWorldPoint(new Vector3(Input.mousePosition.x,
                            Input.mousePosition.y,
                            10)),
                    Vector2.zero);

            if (
                (hit.collider != null) &&
                (hit.collider.gameObject.name == ("arrowUp" + orderArrow))
            )
            {
                // Debug.Log(hit.collider.gameObject.name);
                digit++;
                textMesh.text = digit.ToString();
                if (digit > 9)
                {
                    digit = 0;
                    textMesh.text = digit.ToString();
                }
            }
            else if (
                (hit.collider != null) &&
                (hit.collider.gameObject.name == ("arrowDown" + orderArrow))
            )
            {
                // Debug.Log(hit.collider.gameObject.name);
                digit--;
                textMesh.text = digit.ToString();
                if (digit < 0)
                {
                    digit = 9;
                    textMesh.text = digit.ToString();
                }
            }
        }
        CheckDigit.digits[orderDigit] = digit;
        CheckDigit.CheckDigits();
    }
}
