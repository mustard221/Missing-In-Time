using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scroll : MonoBehaviour
{
    [SerializeField] private string sceneToLoad;

    private void OnMouseDown()
    {
        SceneManager.LoadScene(sceneToLoad);
    }
}
