using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class Note : MonoBehaviour
{

    public Text Textfield;

    public void SetText(string text)
    {
        Textfield.text = text;
    }
}
