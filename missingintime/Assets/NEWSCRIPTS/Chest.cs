using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Chest : MonoBehaviour
{

    public GameObject key;

    [SerializeField] private string sceneToLoad;


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject == key)
        {
            SceneManager.LoadScene(sceneToLoad);
        }
    }
}
