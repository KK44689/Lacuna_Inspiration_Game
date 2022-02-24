using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;

public class DragAndDrop : MonoBehaviour
{
    public GameObject SelectedPiece;

    private RaycastHit2D raycastHit;

    int OIL = 1;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit2D hit =
                Physics2D
                    .Raycast(Camera
                        .main
                        .ScreenToWorldPoint(Input.mousePosition),
                    Vector2.zero);
            if (hit.transform.CompareTag("Puzzle"))
            {
                if (!hit.transform.GetComponent<piecesScript>().InRightPosition)
                {
                    SelectedPiece = hit.transform.gameObject;
                    SelectedPiece.GetComponent<piecesScript>().Selected = true;
                    SelectedPiece.GetComponent<SortingGroup>().sortingOrder =
                        OIL;
                    OIL++;
                }
            }
        }
        if (Input.GetMouseButtonUp(0))
        {
            if (SelectedPiece != null)
            {
                SelectedPiece.GetComponent<piecesScript>().Selected = false;
                SelectedPiece = null;
            }
        }
        if (SelectedPiece != null)
        {
            Vector3 MousePoint =
                Camera.main.ScreenToWorldPoint(Input.mousePosition);
            SelectedPiece.transform.position =
                new Vector3(MousePoint.x, MousePoint.y, 0);
        }
    }
}
