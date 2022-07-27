using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float movementSpeed = 2f;
    Rigidbody rb;
    float horizontalMovement;
    float verticalMovement;
    public Texture2D[] characterTextures;
    public Material charcterMaterial;
    public AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        GetInput();
        //MovementHandler();
        PlayerSoundHandler();
        RotateCharacterTexture();
        
    }

    private void FixedUpdate()
    {
        MovementHandler();
    }

    void MovementHandler()
    {
        Vector3 moveVector = new(horizontalMovement, 0, verticalMovement); //rb.velocity.y
        moveVector = moveVector.normalized;
        rb.velocity = moveVector * movementSpeed;
    }

    void GetInput()
    {
        horizontalMovement = Input.GetAxis("Horizontal");
        verticalMovement = Input.GetAxis("Vertical");
    }

    void RotateCharacterTexture()
    {
        switch (horizontalMovement)
        {
            case -1:
                charcterMaterial.mainTexture = characterTextures[3];
                break;
            case 0:
                switch (verticalMovement)
                {
                    case 1:
                        charcterMaterial.mainTexture = characterTextures[2];
                        break;
                    default:
                        charcterMaterial.mainTexture = characterTextures[0];
                        break;
                }
                break;
            case 1:
                charcterMaterial.mainTexture = characterTextures[1];
                break;
        }
    }

    void PlayerSoundHandler()
    {
        if (horizontalMovement != 0f || verticalMovement != 0f)
        {
            if (audioSource.isPlaying.Equals(false))
            {
                audioSource.Play();
            }
        }
        else
        {
            audioSource.Stop();
        }
    }
}
