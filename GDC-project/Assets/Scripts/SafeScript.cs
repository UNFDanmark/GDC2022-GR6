using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SafeScript : MonoBehaviour
{
    public GameObject safeUI;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Interaction()
    {
        ToggleVissibility();
    }

    void ToggleVissibility()
    {
        if (safeUI.activeSelf)
        {
            safeUI.SetActive(false);
        }
        else
        {
            safeUI.SetActive(true);
        }
    }

}
