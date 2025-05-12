using System.Collections;
using UnityEngine;

public class Guard1 : MonoBehaviour
{
    [SerializeField] private AudioSource thud; 
    [SerializeField] private AudioSource fall;  

    private void OnEnable()
    {
        if (thud != null && !thud.isPlaying)
        {
            thud.Play();  
        }

        if (fall != null && !fall.isPlaying)
        {
            fall.Play();  
        }
    }
}
