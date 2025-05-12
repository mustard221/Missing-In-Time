using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CyanBook : MonoBehaviour
{
    [SerializeField] private AudioSource door;
    [SerializeField] private float delay = 2f;
    [SerializeField] private string sceneToLoad;

    private void OnMouseDown()
    {
        OpenDoor();
    }

    private void OpenDoor()
    {
        door.Play();
        StartCoroutine(SwitchScene());
    }

    private IEnumerator SwitchScene()
    {
        yield return new WaitForSeconds(delay);
        if (!string.IsNullOrEmpty(sceneToLoad))
        {
            SceneManager.LoadScene(sceneToLoad);
        }
    }
}

