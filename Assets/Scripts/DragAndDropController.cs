using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragAndDropController : MonoBehaviour
{
    public float gridSize = 0.5f;
    public bool snapToGrid = true;
    public bool smartDrag = true;
    public bool isDraggable = true;
    public bool isDragged = false;
    Vector2 initialPositionPointer;
    Vector2 initialPositionObject;

    // Update is called once per frame
    void Update()
    {
        if(isDragged)
        {
            if(!smartDrag)
            {
                transform.position = (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition);
            }
            else
            {
                transform.position = initialPositionObject +
                    (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition) - initialPositionPointer;
            }
            if(snapToGrid)
            {
                transform.position = new Vector2(Mathf.RoundToInt(transform.position.x/gridSize)*gridSize, 
                    Mathf.RoundToInt(transform.position.y/gridSize)*gridSize);
            }
        }
    }

    private void OnMouseOver()
    {
        if(isDraggable && Input.GetMouseButtonDown(0))
        {
            if(smartDrag)
            {
                initialPositionObject = (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition);
                initialPositionObject = transform.position;
            }
            isDragged = true;
        }
    }

    private void OnMouseUp()
    {
        isDragged = false;
    }
}
