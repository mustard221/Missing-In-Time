using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakObject : MonoBehaviour
{
   void Break()
    {
        Destroy(gameObject);
    }

    private void OnMouseDown()
    {
        Break();
    }
}
