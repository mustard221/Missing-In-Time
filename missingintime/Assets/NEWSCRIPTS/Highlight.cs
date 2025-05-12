using UnityEngine;
using UnityEngine.UI;

public class Highlight : MonoBehaviour
{
    Renderer rend;
    Color originalColor;
    public Color highlightColor = Color.yellow;

    [SerializeField] private Text descriptionText;

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
        string objectName = gameObject.name;

        // adding hints based on object
        if (objectName.Contains("door") || objectName.Contains("chest"))
        {
            DisplayDescription("It seems to be locked.");
        }
        else if (objectName.Contains("Torch"))
        {
            DisplayDescription("Just a regular torch...");
        }
        else if (objectName.Contains("Book"))
        {
            DisplayDescription("An old, dusty bookshelf");
        }
        else if (objectName.Contains("Note"))
        {
            DisplayDescription("The passage lies within the brightest tome.");
        }
        else
        {
            DisplayDescription("Nothing special here...");
        }

        // Destroy or hide text after 1 second
        Invoke("ClearDescription", 2f);
    }

    private void DisplayDescription(string description)
    {
        if (descriptionText != null)
        {
            descriptionText.text = description;
        }
        else
        {
            Debug.LogError("text not assigned");
        }
    }

    private void ClearDescription()
    {
        if (descriptionText != null)
        {
            descriptionText.text = ""; // Clear the text
        }
    }
}
