using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InteractableObject : MonoBehaviour
{
    public bool isPuzzle;
    public int puzzleIndex;
    TMP_Text textField;
    //public TextManager textManager;
    //public PuzzleManager puzzleManager;
    //public ScriptableObject test;
    PuzzleHandler puzzleManager;
    TextHandler textManager;

    // Start is called before the first frame update
    void Start()
    {
        textField = FindObjectOfType<TMP_Text>();
        textManager = FindObjectOfType<TextHandler>();
        puzzleManager = FindObjectOfType<PuzzleHandler>();
        //textManager = Resources.Load<TextManager>("Scripts/TextManager");
        //puzzleManager = Resources.Load<PuzzleManager>("Scripts/PuzzleManager");
        //test = Resources.Load<ScriptableObject>("Scripts/PuzzleManager");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Interaction()
    {
        switch (isPuzzle)
        {
            case false:
                
                print($"Hello from object: {name}");
                print($"This is placeholder text for some story");
                // write text to UI
                break;
            case true:
                print($"Hello from object: {name}");
                // run puzzle
                puzzleManager.StartPuzzle(puzzleIndex);
                break;
        }
    }
}
