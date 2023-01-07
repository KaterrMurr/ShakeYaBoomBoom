using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProgressBarScript : MonoBehaviour
{
    public Slider slider;
    private void Awake()
    {
        DontDestroyOnLoad(this);
    }

    private void Update()
    {
        slider.value = ProgressStorage._progressAmountStorage;
        Debug.Log("Slider Progress value =" + slider.value);
        if (ProgressStorage._progressAmountStorage >= 5000)
        {
            slider.minValue = 5000;
            slider.maxValue = 10000;
            Debug.Log("Slider min value reset =" + slider.minValue);
        }

        if (ProgressStorage._progressAmountStorage >= 10000)
        {
            slider.minValue = 10000;
            slider.maxValue = 15000;
            Debug.Log("Slider min value reset =" + slider.minValue);
        }
       
        if (ProgressStorage._progressAmountStorage >= 15000)
        {
            slider.minValue = 15000;
            slider.maxValue = 20000;
            Debug.Log("Slider min value reset =" + slider.minValue);
        }
    }

}
