using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key_Door : MonoBehaviour
{

    public float smooth = 2.0f;
    public float DoorOpenAngle = 90.0f;

    public GameObject Door;
    public GameObject Key;

    private Collider col;

    public Camera cam;


    private Vector3 defaultRot;
    private Vector3 openRot;

    int a = 0;
    // Start is called before the first frame update
    void Start()
    {
        col = Key.GetComponent<Collider>();
        defaultRot = transform.eulerAngles;
        openRot = new Vector3(defaultRot.x, defaultRot.y + DoorOpenAngle, defaultRot.z);
    }

    // Update is called once per frame
    void Update()
    {
        if (a==1)
        {

            transform.eulerAngles = Vector3.Slerp(transform.eulerAngles, openRot, Time.deltaTime * smooth);
            Key.active = false;
        }
        else
        {

            transform.eulerAngles = Vector3.Slerp(transform.eulerAngles, defaultRot, Time.deltaTime * smooth);

        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other == col)
        {
            a = 1;
        }
    }
}
