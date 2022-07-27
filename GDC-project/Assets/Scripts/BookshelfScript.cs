using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BookshelfScript : MonoBehaviour
{
    public GameObject userInterface;
    public TMP_Text textField;

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
        //textField.text = $"There seem to be a code engraved in the back panel: 9781";
        ToggleVissibility();
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
