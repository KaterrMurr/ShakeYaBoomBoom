using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MultiplierTextUI : MonoBehaviour
{
    public int mValue;
    private TextMeshProUGUI multiplierTextUI;

    // Start is called before the first frame update
    void Start()
    {
        multiplierTextUI = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        mValue = GameManager.currentMultiplier;
        multiplierTextUI.text = "x" + mValue.ToString();

    }
}
