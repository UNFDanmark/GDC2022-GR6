using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerInteraction : MonoBehaviour
{
    public int rayLength = 1;
    public GameObject inventoryUI;
    public Image keyImage;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RunInteraction();
    }

    void RunInteraction()
    {
        RaycastHit hit;
        //switch to overlap sphere instead of raycast
        if (Input.GetKeyDown(KeyCode.E) && Physics.Raycast(transform.position, transform.forward, out hit, rayLength, LayerMask.GetMask("InteractableObject")))
        {
            hit.collider.gameObject.SendMessage("Interaction");
        }
        if (Input.GetKeyDown(KeyCode.E) && Physics.Raycast(transform.position, transform.forward, out hit, rayLength, LayerMask.GetMask("TransitionPoint")))
        {
            hit.collider.gameObject.SendMessage("Interaction", gameObject);
        }
        //print($"Interacted with item: {hit.collider.name}");
        //InteractableObject otherScript = hit.collider.gameObject.GetComponent<InteractableObject>();
        //otherScript.Interaction();
    }

    private void OnDrawGizmos()
    {
        Debug.DrawRay(transform.position, transform.forward * rayLength, Color.yellow);
    }
}
