using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleManager : ScriptableObject
{
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

    }
    void LockpickPuzzle()
    {
        Debug.Log("This is a lockpick puzzle");
    }
}
