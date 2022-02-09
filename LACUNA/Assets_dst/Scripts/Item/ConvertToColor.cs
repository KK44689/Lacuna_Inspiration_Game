using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConvertToColor : MonoBehaviour
{
    // get colored item
    public GameObject InspireItem_color;

    public void GenColorObj()
    {
        // generate colored item
        GameObject colorInspireObject =
            Instantiate(InspireItem_color,
            transform.position,
            Quaternion.identity);

        //update position of picked up item
        PositionPickedUpItem colorItem =
            colorInspireObject.GetComponent<PositionPickedUpItem>();
    }
}
