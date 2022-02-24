using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Rendering;

public class DragDrop : MonoBehaviour, IDragHandler
{
    int OIL = 1;

    public void OnDrag(PointerEventData eventData)
    {
        GetComponent<Canvas>().sortingOrder = OIL;
        OIL++;
        transform.position = Input.mousePosition;
    }

    // Update is called once per frame
    void Update()
    {
        if (GetComponent<pieceScript2>().InRightPosition)
        {
            transform.position =
                this.GetComponent<pieceScript2>().RightPosition;
        }
    }
}
