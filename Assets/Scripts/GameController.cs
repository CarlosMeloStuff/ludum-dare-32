using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameController : MonoBehaviour 
{
    private List<string> inputStrings;

    private void Awake()
    {
        string[] tempInputArray = { 
            "Q", "W", "E", "R", "T", "Y", "U", "I", "O", "P", 
            "A", "S", "D", "F", "G", "H", "J", "K", "L",
            "Z", "X", "C", "V", "B", "N", "M"   
        };

        inputStrings = new List<string>(tempInputArray);
    }

    public string GetInputString()
    {
        int randomIndex = Random.Range(0, inputStrings.Count);
        string randomInputString = inputStrings[randomIndex];

        inputStrings.RemoveAt(randomIndex);
        
        return randomInputString;
    }

    public void ResetInputString(string key)
    {
        inputStrings.Add(key);
    }
}
