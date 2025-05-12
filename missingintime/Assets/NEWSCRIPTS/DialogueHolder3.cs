using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace DialogueSystem
{
    public class DialogueHolder3 : MonoBehaviour
    {
        [SerializeField] public Image fade;

        private Animation anim;

        private void Awake()
        {
            anim = fade.GetComponent<Animation>();
            StartCoroutine(dialogueSequence());
        }

        private IEnumerator dialogueSequence()
        {
            for (int i = 0; i < transform.childCount; i++)
            {
                Deactivate();
                transform.GetChild(i).gameObject.SetActive(true);
                yield return new WaitUntil(() => transform.GetChild(i).GetComponent<DialogueLine>().finished);

                if (i == 5)
                {
                    anim.Play();
                    yield return new WaitForSeconds(anim.clip.length);
                }
            }

            gameObject.SetActive(false);
            SceneManager.LoadScene("mainscreen");
        }

        private void Deactivate()
        {
            for (int i = 0; i < transform.childCount; i++)
            {
                transform.GetChild(i).gameObject.SetActive(false);
            }
        }
    }
}
