using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class DoorBehaviour : MonoBehaviour
{

    public GameObject key;

    //private bool isLocked = true;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject == key)
        {
            SceneManager.LoadScene(2);
        }
    }

    private void OpenDoor()
    {
        Destroy(gameObject); // door unlocked
        //isLocked = false;
    }
}
