using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnableSlider : MonoBehaviour
{
    public Slider introSlider;
    public Toggle enableToggle;

    public void Slider_Enable(bool sliderOnOff)
    {
        introSlider.interactable = sliderOnOff;
    }
}
