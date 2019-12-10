using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowData : MonoBehaviour
{
    public Text speedText;
    public Text sizeText;
    public Text timeText;

    private void Awake()
    {
        speedText.text = KeepData.speed.ToString();
        sizeText.text = KeepData.size.ToString();
        timeText.text = KeepData.time.ToString();
    }

    void Update()
    {
        speedText.text = KeepData.speed.ToString();
        sizeText.text = KeepData.size.ToString();
        timeText.text = KeepData.time.ToString();
    }
}
