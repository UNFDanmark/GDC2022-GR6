using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleHandler : MonoBehaviour
{
    public GameObject safepuzzleInterface;

    // Start is called before the first frame update
    void Start()
    {
        //safepuzzleInterface = Resources.Load<GameObject>("Prefabs/SafePuzzle");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartPuzzle(int puzzleIndex)
    {
        switch (puzzleIndex)
        {
            case 0:
                SafePuzzle();
                break;
            case 1:
                LockpickPuzzle();
                break;
            default:
                break;
        }
    }

    void SafePuzzle()
    {
        Debug.Log("This is a safe puzzle");
        safepuzzleInterface.SetActive(true);

    }

    void LockpickPuzzle()
    {
        Debug.Log("This is a lockpick puzzle");
    }

    void UIToggle()
    {

    }
}
