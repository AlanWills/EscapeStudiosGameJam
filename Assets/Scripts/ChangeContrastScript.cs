using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(BrightnessContrast))]
public class ChangeContrastScript : MonoBehaviour
{
    public Slider Slider;

    private BrightnessContrast Contrast;

    public void UpdateContrast()
    {
        GetComponent<BrightnessContrast>().contrastAmount = Slider.value;
    }
}
