using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NumberDisplayScript : MonoBehaviour
{
    TMP_Text numberDisplay;
    public AudioSource soundHandler;
    public AudioClip keySound;
    public string code = "3657";
    public GameObject safeUI;

    // Start is called before the first frame update
    void Start()
    {
        numberDisplay = GetComponent<TMP_Text>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void AddNumber(int number)
    {
        soundHandler.PlayOneShot(keySound);
        if (numberDisplay.text.Length < code.Length)
        {
            numberDisplay.text += number.ToString();
        }
    }

    public void ClearDisplay()
    {
        soundHandler.PlayOneShot(keySound);
        numberDisplay.text = "";
    }

    public void CheckCode()
    {
        soundHandler.PlayOneShot(keySound);
        if (numberDisplay.text.Equals(code))
        {
            numberDisplay.text = "acc";
            safeUI.SetActive(false);
            // todo run code supposed to happen after safe is opened
        }
    }
}
