using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.PlayerSettings;
using static UnityEngine.GraphicsBuffer;

public class drags : MonoBehaviour
{

    float distanse = 3;
    public Camera cam;
    private Rigidbody rb;
     

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void OnMouseDown()
    {
  
        
        float distance = Vector3.Distance(cam.transform.position, rb.position);

        
        float desiredDistance = 10f;
        if (distance < desiredDistance  )
        {
            // Если расстояние меньше заданного значения, выполнить определенное действие
            
            rb.isKinematic = true;
        }
        else
        {
            // Если расстояние больше или равно заданному значению, выполнить другое действие
          
        }

       
            
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
                    rb.AddForce(cam.transform.forward * 1200);
            }
        }

    }
     
}
