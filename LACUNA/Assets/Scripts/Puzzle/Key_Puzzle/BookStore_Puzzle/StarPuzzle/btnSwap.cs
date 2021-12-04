using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class btnSwap : MonoBehaviour
{
    int clickedCount = 0;

    private Button

            clicked1,
            clicked2;

    private Vector3

            position1,
            position2;

    string

            btn1_name,
            btn2_name;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (clickedCount == 2)
        {
            clicked1.transform.position =
                Vector3
                    .Lerp(clicked1.transform.position,
                    position2,
                    10f * Time.deltaTime);
            clicked2.transform.position =
                Vector3
                    .Lerp(clicked2.transform.position,
                    position1,
                    10f * Time.deltaTime);
            Invoke("FirstScale", 0.5f);
        }
    }

    private void FirstScale()
    {
        clicked1.transform.name = btn1_name;
        clicked2.transform.name = btn2_name;
        clicked1.transform.localScale = new Vector2(1f, 1f);
        clicked2.transform.localScale = new Vector2(1f, 1f);
        clickedCount = 0;
    }

    public void moveBtn(Button btn)
    {
        if (btn.transform.name != "clicked" && clickedCount == 0)
        {
            clicked1 = btn;
            btn1_name = btn.transform.name;
            position1 = btn.transform.position;
            btn.transform.name = "clicked";

            btn.transform.localScale = new Vector2(0.8f, 0.8f);
            clickedCount++;
        }
        else if (btn.transform.name != "clicked" && clickedCount == 1)
        {
            clicked2 = btn;
            position2 = btn.transform.position;
            btn2_name = btn.transform.name;

            btn.transform.name = "clicked";

            btn.transform.localScale = new Vector2(0.8f, 0.8f);
            clickedCount++;
        }
    }
}
