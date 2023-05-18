using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyPickup : MonoBehaviour
{
    public bool playerLook = false;
    public GameObject door;
    private GameObject key;

    private void Start()
    {

    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (playerLook)
            {
                door.GetComponent<DoorOpen>().haveKey = true;
                Destroy(key);
            }
        }
    }

    //private void OnTriggerEnter(Collider other)
    //{
        

    //}

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            playerLook = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            playerLook = false;
        }
    }
}
