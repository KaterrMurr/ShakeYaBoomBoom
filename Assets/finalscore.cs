using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;



public class finalscore : MonoBehaviour
{

    public int finalScore;
    private TextMeshProUGUI score;

    // Start is called before the first frame update
    void Start()
    {
        score = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        finalScore = GameManager.currentScore;
        score.text = finalScore.ToString();
    }
}
