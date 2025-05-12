using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Guard2 : MonoBehaviour
{
    public GameObject Objects;

    private void OnEnable()
    {
        Debug.Log("Guard2 enabled: " + gameObject.name);

        foreach (Transform child in Objects.transform)
        {
            child.gameObject.SetActive(true);
        }
    }

}

