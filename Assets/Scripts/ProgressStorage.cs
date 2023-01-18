using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProgressStorage : MonoBehaviour
{
    public static float _progressAmountStorage;

    private void Awake()
    {
        DontDestroyOnLoad(this);
    }

    // Start is called before the first frame update
    void Start()
    {
        _progressAmountStorage = GameManager.currentScore;
    }

    // Update is called once per frame
    void Update()
    {
        _progressAmountStorage = GameManager.currentScore;
        Debug.Log("Общий счет сохранен: " + GameManager.currentScore);
    }
}
