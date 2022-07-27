using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BookshelfScript : MonoBehaviour
{
    TMP_Text textField;

    // Start is called before the first frame update
    void Start()
    {
        textField = FindObjectOfType<TMP_Text>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Interaction(GameObject player)
    {
        // print($"Hello from: {name}");
        textField.text = $"There seem to be a code engraved in the back panel: 9781";
    }
}
