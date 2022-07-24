using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NumberDisplayScript : MonoBehaviour
{
    TMP_Text numberDisplay;
    public string code = "365";

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
        if (numberDisplay.text.Length < 3)
        {
            numberDisplay.text += number.ToString();
        }
    }

    public void ClearDisplay()
    {
        numberDisplay.text = "";
    }

    public void CheckCode()
    {
        if (numberDisplay.text.Equals(code))
        {
            numberDisplay.text = "acc";
            // toggle safe UI
            // todo run code supposed to happen after safe is opened
        }
    }
}
