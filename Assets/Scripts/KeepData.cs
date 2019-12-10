using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeepData : MonoBehaviour
{
    public static int speed;
    public static float size;
    public static int time;

    public Dropdown speedChoice;
    public Dropdown timeChoice;
    public Slider sizeChoice;


    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    public void UpdateTime() {

        switch (timeChoice.value)
        {
            case 1:
                time = 1;
                break;
            case 2:
                time = 2;
                break;
            case 3:
                time = 3;
                break;
            case 4:
                time = 4;
                break;
            default:
                time = 1;
                break;
        }
    }
    public void UpdateSpeed()
    {

        switch (speedChoice.value)
        {
            case 1:
                speed = 10;
                break;
            case 2:
                speed = 20;
                break;
            case 3:
                speed = 30;
                break;
            case 4:
                speed = 40;
                break;
            default:
                speed = 1;
                break;
        }
    }

    public void UpdateSize() {
        size = sizeChoice.value;
    }
}
