using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drag : MonoBehaviour
{

    float distanse = 3;
    public Transform pos;
    public Camera cam;
    private Rigidbody rb; 
     
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void OnMouseDown()
    {
        Ray ray = cam.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, distanse))
        {
            rb.isKinematic = true;
            rb.MovePosition(pos.position);
        }  
    }

    void FixedUpdate()
    {
        if (rb.isKinematic == true)
        {
            this.gameObject.transform.position = pos.position;
            if (Input.GetKeyDown(KeyCode.G))
            {
                rb.useGravity = true;
                rb.isKinematic = false;
               // rb.AddForce(cam.transform.forward * 500);
            }
        } 
    }
}
