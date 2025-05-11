using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Torch : MonoBehaviour
{
    public GameObject fire;

    private bool isLocked = true;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject == fire && isLocked)
        {
            OpenDoor();
        }
    }

    private void OpenDoor()
    {
        Destroy(gameObject);
        isLocked = false;
    }
}
