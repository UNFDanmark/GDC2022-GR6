using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour
{
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
        PlayerInteraction playerScript = player.GetComponent<PlayerInteraction>();
        if (playerScript.isKeyObtained)
        {
            print("You escaped");
            // Do something / win the game / something
        }
    }
}
