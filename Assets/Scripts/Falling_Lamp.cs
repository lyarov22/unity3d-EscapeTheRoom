using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Falling_Lamp : MonoBehaviour
{
    public GameObject Lamp;

    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
       rb = Lamp.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Untagged"))
        {
            rb.isKinematic = false;
         
        }
        StartCoroutine(DelayedAction());
    }

    IEnumerator DelayedAction()
    {
        yield return new WaitForSeconds(2f); // Задержка в 5 секунды
        DestroyImmediate(GetComponent<Rigidbody>());
    }
}
