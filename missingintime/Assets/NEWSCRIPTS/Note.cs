using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Note : MonoBehaviour
{
    public UnityEvent interacted;
    private AudioSource audioSource;

    private void OnMouseDown()
    {
        interacted?.Invoke();
        audioSource.Play();

    }


}
