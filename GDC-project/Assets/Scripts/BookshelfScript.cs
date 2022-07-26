using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BookshelfScript : MonoBehaviour
{
    public GameObject userInterface;
    public AudioSource audioSource;
    public AudioClip bookClip;
    public TMP_Text textField;

    private void Start()
    {
        audioSource = gameObject.AddComponent<AudioSource>();
        audioSource.volume = 1f;
    }

    public void Interaction(GameObject player)
    {
        ToggleVissibility();
        audioSource.PlayOneShot(bookClip);
    }

    void ToggleVissibility()
    {
        bool isActive = userInterface.activeSelf;
        if (isActive)
        {
            userInterface.SetActive(!isActive);
        }
        else
        {
            userInterface.SetActive(!isActive);
        }
    }
}
