using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TableScript : MonoBehaviour
{
    bool isUsed = false;
    Transform noteObject;
    public int itemIndex;

    // Start is called before the first frame update
    void Start()
    {
        noteObject = transform.GetChild(transform.childCount - 1);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Interaction(GameObject player)
    {
        if (!isUsed)
        {
            noteObject.gameObject.SetActive(false);
            player.SendMessage("AddItem", itemIndex);
            isUsed = true;
        }
    }
}
