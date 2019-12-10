using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;

public class ReadFile : MonoBehaviour
{
    public Text scoreFile;
    
    public void ReadFileString()
    {
        string path = "Assets/scores.txt";

        scoreFile.text = "";

        string[] readText = File.ReadAllLines(path);
        foreach (string s in readText)
        {
            scoreFile.text += s + "\n";
        }
    }

    private void Awake()
    {
        ReadFileString();
    }


}
