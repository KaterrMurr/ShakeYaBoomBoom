using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MultiplierTextToString : MonoBehaviour
{
    TextMeshProUGUI multiplierTextUI;
    public GameManager gameManager;
   

    // Start is called before the first frame update
    void Start()
    {
        multiplierTextUI = GetComponent<TextMeshProUGUI>();
        gameManager = GetComponent<GameManager>();

    }

    // Update is called once per frame
    void Update()
    {
        multiplierTextUI.text = "x" + GameManager.currentScore;
            

    }
}
