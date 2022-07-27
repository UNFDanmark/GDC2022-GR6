using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class PlayerInteraction : MonoBehaviour
{
    public int rayLength = 1;
    public GameObject inventoryUI;
    public Sprite keyTexture;
    public Sprite[] noteTextures;
    //public Image[] inventoryTextures;
    List<Image> inventoryTextures;
    List<Transform> inventorySlots;
    int numberOfItemGained;
    public bool isKeyObtained;


    // Start is called before the first frame update
    void Start()
    {
        numberOfItemGained = 0;
        inventorySlots = new();
        inventoryTextures = new();
        for (int i = 0; i < inventoryUI.transform.childCount; i++)
        {
            inventorySlots.Add(inventoryUI.transform.GetChild(i));
        }
        foreach (var item in inventorySlots)
        {
            // print(item.GetChild(item.childCount - 1).name);
            inventoryTextures.Add(item.GetChild(item.childCount - 1).GetComponent<Image>());
        }
    }

    // Update is called once per frame
    void Update()
    {
        RunInteraction();
    }

    void RunInteraction()
    {
        // Creates an invisible sphere on the player with a radius of raylength
        Collider[] colliders = Physics.OverlapSphere(transform.position, rayLength, LayerMask.GetMask("InteractableObject"));
        // Checks if player presses E key and is close to atleast interactable
        if (Input.GetKeyDown(KeyCode.E) && colliders.Length > 0)
        {
            List<float> distances = new();
            // calculates distance to player from all nearby interactables
            foreach (var item in colliders)
            {
                distances.Add((item.transform.position - transform.position).magnitude);
            }
            // Gets the index of the interactable closest to the player
            int closestObjectIndex = distances.IndexOf(distances.Min<float>());
            // Sends message to run "Interaction" method on closest interactable
            colliders[closestObjectIndex].SendMessage("Interaction", gameObject);
        }
    }


    public void AddItem(int item)
    {
        Color color = inventoryTextures[numberOfItemGained].color;
        color.a = 1f;
        switch (item)
        {
            case 0:
                inventoryTextures[numberOfItemGained].color = color;
                inventoryTextures[numberOfItemGained].sprite = keyTexture;
                isKeyObtained = true;
                break;
            case 1:
                inventoryTextures[numberOfItemGained].color = color;
                inventoryTextures[numberOfItemGained].sprite = noteTextures[0];
                break;
            case 2:
                inventoryTextures[numberOfItemGained].color = color;
                inventoryTextures[numberOfItemGained].sprite = noteTextures[1];
                break;
            case 3:
                inventoryTextures[numberOfItemGained].color = color;
                inventoryTextures[numberOfItemGained].sprite = noteTextures[2];
                break;
            case 4:
                inventoryTextures[numberOfItemGained].color = color;
                inventoryTextures[numberOfItemGained].sprite = noteTextures[3];
                break;
            default:
                break;
        }
        numberOfItemGained++;
    }

    private void OnDrawGizmos()
    {
        //Debug.DrawRay(transform.position, transform.forward * rayLength, Color.yellow);
        Color color = Color.yellow;
        color.a = 0.2f;
        Gizmos.color = color;
        Gizmos.DrawSphere(transform.position, rayLength);
    }
}
