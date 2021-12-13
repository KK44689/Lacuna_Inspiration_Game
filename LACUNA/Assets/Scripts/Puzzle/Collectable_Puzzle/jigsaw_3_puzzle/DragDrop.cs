using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragDrop : MonoBehaviour, IDragHandler
// , IEndDragHandler
{
    List<bool> checkRightPos = new List<bool>();

    bool allCorrect = false;

    public void OnDrag(PointerEventData eventData)
    {
        transform.position = Input.mousePosition;
    }

    // public void OnEndDrag(PointerEventData eventData)
    // {
    //     transform.localPosition = Vector3.zero;
    // }
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 36; i++)
        {
            checkRightPos.Add(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (GetComponent<pieceScript2>().InRightPosition)
        {
            transform.position =
                this.GetComponent<pieceScript2>().RightPosition;
            for (int i = 1; i <= 36; i++)
            {
                if (this.gameObject.name == "piece" + i.ToString())
                {
                    checkRightPos[i-1] = true;
                    print(checkRightPos[i-1]);
                }
            }
        }
        if (check())
        {
            print("won");
        }
    }

    bool check()
    {
        foreach (bool j in checkRightPos)
        {
            if (j == false)
            {
                return false;
            }
        }
        return true;
    }
}
