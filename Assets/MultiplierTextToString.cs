using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MultiplierTextToString : MonoBehaviour
{
    TextMeshProUGUI multiplierTextUI;
    private int multiplierToPopUp;


    // Start is called before the first frame update
    void Start()
    {
        multiplierTextUI = GetComponent<TextMeshProUGUI>();
        

    }

    // Update is called once per frame
    void Update()
    {
        multiplierToPopUp = GameManager.currentMultiplier;
        multiplierTextUI.text = multiplierToPopUp.ToString();
    
    }
}
