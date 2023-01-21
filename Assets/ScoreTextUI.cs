using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreTextUI : MonoBehaviour
{
    public Slider slider;
    private TextMeshProUGUI scoreTextUI;
    
    // Start is called before the first frame update
    void Start()
    {
        scoreTextUI = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        slider.value = GameManager.currentScore;
        scoreTextUI.text = "Score: " + slider.value.ToString();

    }
}
