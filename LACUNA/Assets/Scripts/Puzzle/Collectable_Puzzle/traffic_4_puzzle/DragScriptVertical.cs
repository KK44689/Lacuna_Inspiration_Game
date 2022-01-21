using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragScriptVertical : MonoBehaviour
{
    private bool isDragging;

    Rigidbody2D rb;

    bool collided = false;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    public void OnMouseDown()
    {
        isDragging = true;
    }

    public void OnMouseUp()
    {
        isDragging = false;
    }

    void Update()
    {
        if (isDragging)
        {
            Vector2 mousePosition =
                Camera.main.ScreenToWorldPoint(Input.mousePosition);

            // Vector2 temp = transform.position;
            // temp.y = mousePosition.y;
            Vector2 position = rb.position;
            position.y = mousePosition.y;

            // transform.position = temp;
            rb.MovePosition (position);
        }
    }
}
