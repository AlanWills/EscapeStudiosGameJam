using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WaitForSliderValueEqual : ConditionScript
{
    public Slider Slider;
    public float DesiredValue;

    protected override bool Condition()
    {
        bool result = Slider.value == DesiredValue;
        if (result)
        {
            Slider.transform.parent.gameObject.SetActive(false);
        }

        return result;
    }
}
