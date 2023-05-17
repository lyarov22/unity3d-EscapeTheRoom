using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Swords : MonoBehaviour
{

    public GameObject Sword1;
    public GameObject Sword2;
    public GameObject Sword3;
    public GameObject Sword4;

    public GameObject Sword_Tron1;
    public GameObject Sword_Tron2;
    public GameObject Sword_Tron3;
    public GameObject Sword_Tron4;

    public GameObject Chest;

    private Collider col;
    private Collider col2;
    private Collider col3;
    private Collider col4;
    private int a = 0;

    void Start()
    {
         col = Sword1.GetComponent<Collider>();
         col2 = Sword2.GetComponent<Collider>();
         col3 = Sword3.GetComponent<Collider>();
         col4 = Sword4.GetComponent<Collider>();
    }

    void Update()
    {
        if (a == 4)
        {
            Chest.active = true;
        }  
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other == col)
        {
            Sword_Tron1.active = true;
            Sword1.active = false;
            a++;
        }
        else if (other == col2)
        {      
            Sword_Tron2.active = true;
            Sword2.active = false;
            a++;
        }
        else if (other == col3)
        {  
            Sword_Tron3.active = true;
            Sword3.active = false;
            a++;
        }
        else if(other == col4){
            Sword_Tron4.active = true;
            Sword4.active = false;
            a++;
        }
    }
     
}
