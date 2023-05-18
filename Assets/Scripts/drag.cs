using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class drag : MonoBehaviour
{

 
   // public Transform pos;
    public Camera cam;
    private Rigidbody rb;

    public GameObject hand;
    public float smoothSpeed = 500f; // �������� �����������

    private Vector3 velocity = Vector3.zero;



    void Start()
    {
        rb = GetComponent<Rigidbody>();
       
    }

    void OnMouseDown()
    {
        float distance = Vector3.Distance(cam.transform.position, rb.position);


        float desiredDistance = 10f;
        if (distance < desiredDistance)
        {
            // ���� ���������� ������ ��������� ��������, ��������� ������������ ��������

            rb.isKinematic = true;
            Vector3 newPosition = Vector3.SmoothDamp(transform.position, hand.transform.position, ref velocity, smoothSpeed);

            // ��������� ����� ������� � �������
            transform.position = newPosition;
        }
        else
        {
            // ���� ���������� ������ ��� ����� ��������� ��������, ��������� ������ ��������

        }
    }

    void Update()
    {
        if (rb.isKinematic == true)
        { 
            transform.position = hand.transform.position;

            if (Input.GetKeyDown(KeyCode.Q))
            {
                rb.useGravity = true;
                rb.isKinematic = false;
               // rb.AddForce(cam.transform.forward * 500);
            }
        } 
    }
}
