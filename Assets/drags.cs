using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drags : MonoBehaviour
{

    float distanse = 3;
    public Camera cam;
    // Start is called before the first frame update
    private void OnMouseDrag()
    {
        Vector3 mouse = new Vector3 (Input.mousePosition.x, Input.mousePosition.y, distanse);
        Vector3 objPos = cam.ScreenToWorldPoint (mouse);
        transform.position = objPos;
    }
}
