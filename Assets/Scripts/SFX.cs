using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class ButtonClickSound : MonoBehaviour
{
    private Button button;
    private AudioSource audioSource;

    private void Start()
    {
        button = GetComponent<Button>();
        audioSource = GetComponent<AudioSource>();

        button.onClick.AddListener(PlayClickSound);
    }

    private void PlayClickSound()
    {
        audioSource.Play();
    }
}