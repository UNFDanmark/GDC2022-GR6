using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SafeScript : MonoBehaviour
{
    public GameObject userInterface;

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
        ToggleVissibility();
    }


    void ToggleVissibility()
    {
        bool isActive = userInterface.activeSelf;
        if (isActive)
        {
            userInterface.SetActive(!isActive);
            Cursor.visible = !isActive;
        }
        else
        {
            userInterface.SetActive(!isActive);
            Cursor.visible = !isActive;
        }
    }

}
