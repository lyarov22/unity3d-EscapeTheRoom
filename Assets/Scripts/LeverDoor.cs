using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LeverDoor : MonoBehaviour
{
    public float smooth = 2.0f;
    public float DoorOpenAngle = 30.0f;
    public Camera cam;
    public GameObject Door;
     

    private Vector3 defaultRot;
    private Vector3 openRot;
    private Vector3 defaultRot1;
    private Vector3 openRot1;
    private bool open;
 

    private bool cur = false;
    private bool cure = false;

    
    void Start()
    {

        defaultRot = transform.eulerAngles;
        openRot = new Vector3(defaultRot.x, defaultRot.y, defaultRot.z + DoorOpenAngle);
        defaultRot1 = Door.transform.eulerAngles;
        openRot1 = new Vector3(defaultRot1.x, defaultRot1.y + 90.0f, defaultRot1.z);

    }

    void Update()
    {
        Ray ray = cam.ScreenPointToRay(Input.mousePosition);


        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {

            if (hit.collider.gameObject == this.gameObject)
            {
                cur = true;
            }
            else
            {
                cur = false;
            }
        }

        float distance = Vector3.Distance(cam.transform.position, this.gameObject.transform.position);


        float desiredDistance = 3f;
        if (distance < desiredDistance)
        {
            // Если расстояние меньше заданного значения, выполнить определенное действие

            cure = true;
        }
        else
        {
            // Если расстояние больше или равно заданному значению, выполнить другое действие
            cure = false;
        }
        if (open)
        {

            transform.eulerAngles = Vector3.Slerp(transform.eulerAngles, openRot, Time.deltaTime * smooth);
            Door.transform.eulerAngles = Vector3.Slerp(Door.transform.eulerAngles, openRot1, Time.deltaTime * smooth);
        }
        else
        {

            transform.eulerAngles = Vector3.Slerp(transform.eulerAngles, defaultRot, Time.deltaTime * smooth);
            Door.transform.eulerAngles = Vector3.Slerp(Door.transform.eulerAngles, defaultRot1, Time.deltaTime * smooth);
        }
        if (Input.GetKeyDown(KeyCode.E) && cur && cure)
        {
            open = !open;
        }
    }

}
