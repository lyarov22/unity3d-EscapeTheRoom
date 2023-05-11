using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drags : MonoBehaviour
{

    float distanse = 3;
    public Camera cam;
    private Rigidbody rb;
   
    // Start is called before the first frame update

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void OnMouseDrag()
    {
        
            Vector3 mouse = new Vector3 (Input.mousePosition.x, Input.mousePosition.y, distanse); 
            Vector3 objPos = cam.ScreenToWorldPoint (mouse);
            rb.isKinematic = true;
            rb.useGravity = true;
            transform.position = objPos;
     
    }
    private void Update()
    {
       rb.isKinematic = false; 
    }
     
}
