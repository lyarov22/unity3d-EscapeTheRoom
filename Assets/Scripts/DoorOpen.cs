using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen : MonoBehaviour
{
    public bool haveKey = false;
    private GameObject door;

    private void Start()
    {
        door = GetComponent<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            if (haveKey)
            {
                Destroy(door);
            }
        }
       
    }
}
