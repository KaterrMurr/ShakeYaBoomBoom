using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProgressStorage : MonoBehaviour
{
    public static float _progressAmountStorage;
    public Transform noteTransform;

    
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

        if (BoosterCollider.colliderBoosterReceived == true)
        {
            BoosterMultiplier.multiplierBoosterReceived = false;
            ChangeScale();
            Debug.Log("Нотки увеличены");
        }

        if (BoosterMultiplier.multiplierBoosterReceived == true)
        {
          
            BoosterCollider.colliderBoosterReceived = false;
            GameManager.currentMultiplier = GameManager.multiplierTracker + 3;
            Debug.Log("Множитель увеличен");
            ChangeScaleBack();
        }
    }

    public void ChangeScale()
    {
        noteTransform.localScale = new Vector3(2.5f, 2.5f, 2.5f);
        Debug.Log("ScaleChanged");
    }

    public void ChangeScaleBack()
    {
        noteTransform.localScale = new Vector3(2f, 2f, 2f);
        Debug.Log("ScaleReturned");
    }

}
