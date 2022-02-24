using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragScriptHorizontal : MonoBehaviour
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

            Vector2 position = rb.position;
            position.x = mousePosition.x;

            rb.MovePosition (position);
        }
    }
}
