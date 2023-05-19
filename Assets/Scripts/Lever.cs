using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lever : MonoBehaviour
{
    public float smooth = 2.0f;
    public float doorOpenAngle = 30.0f;
    public Camera cam;
    public GameObject objectToDestroy;
    public List<Lever> levers;

    private Vector3 defaultRot;
    private Vector3 openRot;
    private bool open;
    private bool cur = false;
    private bool cure = false;

    // Use this for initialization
    void Start()
    {
        defaultRot = transform.eulerAngles;
        openRot = new Vector3(defaultRot.x, defaultRot.y, defaultRot.z + doorOpenAngle);
    }

    // Update is called once per frame
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
        }
        else
        {
            transform.eulerAngles = Vector3.Slerp(transform.eulerAngles, defaultRot, Time.deltaTime * smooth);
        }

        if (Input.GetKeyDown(KeyCode.E) && cur && cure)
        {
            ToggleLever();
        }
    }

    private void ToggleLever()
    {
        open = !open;
        CheckSequence();
    }

    private void CheckSequence()
    {
        int leverCount = levers.Count;
        bool isCorrectSequence = true;

        for (int i = 0; i < leverCount; i++)
        {
            if (!levers[i].open)
            {
                isCorrectSequence = false;
                break;
            }
        }

        if (isCorrectSequence)
        {
            Destroy(objectToDestroy);
        }
    }
}