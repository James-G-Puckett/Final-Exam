using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;

public class WriteFile : MonoBehaviour
{
    public InputField playerName;

    public void WriteToFile()
    {
        string path = "Assets/scores.txt";

        string newPlayerName = playerName.text;

        if (File.Exists(path))
        {
            string[] newText = { newPlayerName };
            File.WriteAllLines(path, newText);
        }
    }

    private void Update()
    {
        WriteToFile();
    }
}
