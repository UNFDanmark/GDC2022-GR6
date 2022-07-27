using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteHandler : MonoBehaviour
{
    bool isUsed = false;
    public int item;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Interaction(GameObject player)
    {
        // print($"Hello from: {name}");
        if (!isUsed)
        {
            player.SendMessage("AddItem", 1);
            isUsed = true;
        }
    }
}
