using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaintingScript : MonoBehaviour
{
    bool isUsed = false;
    public int itemIndex;
    public Vector3 destination;
    bool needsToMove = false;
    public AudioClip clip;
    public AudioSource audioSource;

    private void Start()
    {
        audioSource = gameObject.AddComponent<AudioSource>();
        audioSource.volume = 1f;
    }


    private void FixedUpdate()
    {
        if (needsToMove && Vector3.Distance(transform.position, destination) > 0.001f)
        {
            transform.position = Vector3.MoveTowards(transform.position, destination, 0.01f);
        }
    }

    public void Interaction(GameObject player)
    {
        if (!isUsed)
        {
            needsToMove = true;
            audioSource.PlayOneShot(clip);
            player.SendMessage("AddItem", itemIndex);
            isUsed = true;
        }
    }
}
