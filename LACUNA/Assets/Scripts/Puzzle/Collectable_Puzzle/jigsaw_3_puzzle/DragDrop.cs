using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Rendering;

public class DragDrop : MonoBehaviour, IDragHandler
// , IEndDragHandler
{
    int OIL = 1;
    public void OnDrag(PointerEventData eventData)
    {
        // Vector3 tempPos = transform.position;
        // tempPos.z++; 
        // transform.position = tempPos;
        GetComponent<Canvas>().sortingOrder = OIL;
        OIL++;
        // print(GetComponent<Canvas>().sortingOrder);
        transform.position = Input.mousePosition;
    }

    // public void OnEndDrag(PointerEventData eventData)
    // {
    //     transform.localPosition = Vector3.zero;
    // }
    // Start is called before the first frame update
    void Start()
    {
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
