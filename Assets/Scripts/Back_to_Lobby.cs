using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Back_to_Lobby : MonoBehaviour
{

    public GameObject Player;

    private Collider col;

    // Start is called before the first frame update
    void Start()
    {
        col = Player.GetComponent<Collider>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other == col)
        {
            SceneManager.LoadScene("New_Lobby");
        }
    }
}
