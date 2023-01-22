using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProgressStorage : MonoBehaviour
{
    public static float _progressAmountStorage;
    public Transform noteTransform;
    public static ProgressStorage instance;

    private void Awake()
    {
        DontDestroyOnLoad(this);
       // BoosterCollider.colliderBoosterReceived = false;
       // BoosterMultiplier.multiplierBoosterReceived = false;
        if (instance != null && instance != this)
        {
           // Destroy(this.gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);

        }
    }

    // Start is called before the first frame update
    void Start()
    {
        instance = this;

        _progressAmountStorage = GameManager.currentScore;
       // BoosterCollider.colliderBoosterReceived = false;
      //  BoosterMultiplier.multiplierBoosterReceived = false;
        
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
            //GameManager.currentMultiplier = 1;
        }

        if (BoosterMultiplier.multiplierBoosterReceived == true)
        {
            GameManager.currentMultiplier = 5;
            //GameManager.currentMultiplier = GameManager.multiplierTracker += 3;
            Debug.Log("Множитель увеличен");
            ChangeScaleBack();
            BoosterCollider.colliderBoosterReceived = false;
        }

        /* if (BoosterCollider.colliderBoosterReceived == false && BoosterMultiplier.multiplierBoosterReceived == false)
         {
             GameManager.currentMultiplier = 1;
         }*/
       /* if (BoosterCollider.multiplierBoosterReceived == true)
        {
            GameManager.currentMultiplier = 3;
        }*/
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
