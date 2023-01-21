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
        Debug.Log("����� ���� ��������: " + GameManager.currentScore);

        if (BoosterCollider.colliderBoosterReceived == true)
        {
            BoosterMultiplier.multiplierBoosterReceived = false;
            ChangeScale();
            Debug.Log("����� ���������");
        }

        if (BoosterMultiplier.multiplierBoosterReceived == true)
        {
                      
            GameManager.currentMultiplier = GameManager.multiplierTracker + 3;
            Debug.Log("��������� ��������");
            ChangeScaleBack();
            BoosterCollider.colliderBoosterReceived = false;
        }
    }

    public void ChangeScale()
    {
        noteTransform.localScale = new Vector3(2.2f, 2.2f, 2.2f);
        Debug.Log("ScaleChanged");
    }

    public void ChangeScaleBack()
    {
        noteTransform.localScale = new Vector3(1.7f, 1.7f, 1.7f);
        Debug.Log("ScaleReturned");
    }

}
