using System.Collections;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace DialogueSystem
{
    public class DialogueHolder : MonoBehaviour
    {
        [SerializeField] public Volume volume;
        [SerializeField] public AudioSource woosh;
        [SerializeField] public Image fade;

        private Vignette vignette;
        private FilmGrain filmGrain;
        private Animation anim;

        private void Awake()
        {
            StartCoroutine(dialogueSequence());
            volume.profile.TryGet(out vignette);
            volume.profile.TryGet(out filmGrain);
            anim = fade.GetComponent<Animation>();
        }

        private IEnumerator dialogueSequence()
        {
            for (int i = 0; i < transform.childCount; i++)
            {
                Deactivate();
                transform.GetChild(i).gameObject.SetActive(true);
                yield return new WaitUntil(() => transform.GetChild(i).GetComponent<DialogueLine>().finished);

                if (i == 2 && vignette != null)
                {
                    anim.Play();
                    woosh.Play();
                    if (anim.isPlaying)
                    {
                        yield return new WaitForSeconds(1f);
                        vignette.intensity.value = 0.4f;
                        filmGrain.intensity.value = 0.2f;
                    }
                }
            }
            SceneManager.LoadScene("sceneone");
            gameObject.SetActive(false);
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

