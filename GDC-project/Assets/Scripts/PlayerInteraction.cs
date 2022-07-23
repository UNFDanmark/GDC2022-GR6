using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
    public int rayLength = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        if (Input.GetKeyDown(KeyCode.E) && Physics.Raycast(transform.position, transform.forward, out hit, rayLength) && hit.collider.CompareTag("Interactable"))
        {
            Interact(hit);
        }
    }

    void Interact(RaycastHit hit)
    {
        print($"Interacted with item: {hit.collider.name}");
    }

    private void OnDrawGizmos()
    {
        Debug.DrawRay(transform.position, transform.forward * rayLength, Color.yellow);
    }
}
