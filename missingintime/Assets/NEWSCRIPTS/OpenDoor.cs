using UnityEngine;
using UnityEngine.SceneManagement;  
using UnityEngine.UI;
using System.Collections;

public class ClickableObject : MonoBehaviour
{
    [SerializeField] private Image bgImage;    
    [SerializeField] private Sprite newBG;
    [SerializeField] private AudioSource door;
    [SerializeField] private string sceneToLoad;      
    [SerializeField] private float delay = 2f;

    Renderer rend;
    Color originalColor;
    public Color highlightColor = Color.yellow;

    void Start()
    {
        rend = GetComponent<Renderer>();
        originalColor = rend.material.color;
    }

    void OnMouseEnter()
    {
        rend.material.color = highlightColor;
    }

    void OnMouseExit()
    {
        rend.material.color = originalColor;
    }

    void OnMouseDown() 
    {
        OpenDoor();
    }

    private void OpenDoor()
    {
        // change bg image
        if (bgImage != null && newBG != null)
        {
            door.Play();
            bgImage.sprite = newBG;
            Debug.Log("door opened");
        }
        else
        {
            Debug.LogError("image not assigned");
        }

        // wait before loading next scene
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
