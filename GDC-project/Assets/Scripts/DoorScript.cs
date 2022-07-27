using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorScript : MonoBehaviour
{
    public void Interaction(GameObject player)
    {
        PlayerInteraction playerScript = player.GetComponent<PlayerInteraction>();
        if (playerScript.isKeyObtained)
        {
            print("You escaped");
            SceneManager.LoadScene("EndScene");
            // Do something / win the game / something
        }
    }
}
