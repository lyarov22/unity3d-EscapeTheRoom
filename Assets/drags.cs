using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.PlayerSettings;

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

    void OnMouseDown()
    {
            
          
            rb.isKinematic = true;
           
           // rb.AddForce(cam.transform.forward * 500);
    }
    void Update()
    {
        if (rb.isKinematic == true)
        {
            Vector3 mouse = new Vector3(Input.mousePosition.x, Input.mousePosition.y, distanse);
            Vector3 objPos = cam.ScreenToWorldPoint(mouse);
            transform.position = objPos;
            if (Input.GetKeyDown(KeyCode.Q))
                {
                    rb.useGravity = true;
                    rb.isKinematic = false;
                    rb.AddForce(cam.transform.forward * 1000);
            }
        }

    }
     
}
