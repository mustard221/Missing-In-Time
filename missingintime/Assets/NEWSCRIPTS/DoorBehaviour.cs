using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorBehaviour : MonoBehaviour
{

    public GameObject key;

    private bool isLocked = true;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject == key && isLocked)
        {
            OpenDoor();
        }
    }

    private void OpenDoor()
    {
        // Add door opening animation or simply change the door's position.
        Destroy(gameObject); // Adjust the value based on your door's size.
        isLocked = false;
    }
}
