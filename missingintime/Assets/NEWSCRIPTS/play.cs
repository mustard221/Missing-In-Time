using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadOpeningScene : MonoBehaviour
{
    public void OnClick()
    {
        SceneManager.LoadScene("Opening");
    }
}
