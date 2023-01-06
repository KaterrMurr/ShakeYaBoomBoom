using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataStorageScript : MonoBehaviour
{
    //система сохранения данных о кол-ве бустеров и монеток сквозь игру

    public static int coinAmountStorage;

    public static float greenBoosterCountStorage;
    public static float blueBoosterCountStorage;
    public static float yellowBoosterCountStorage;


    private void Awake()
    {
        DontDestroyOnLoad(this);
    }


    // Start is called before the first frame update
    void Start()
    {
       // coinAmountStorage = ScoreTextScript.coinAmount;

        greenBoosterCountStorage = GravitySpeedBooster.greenBoosterCount;
      //  blueBoosterCountStorage = FrictionBooster.blueBoosterCount;
        //yellowBoosterCountStorage = SizeSmallerBooster.yellowBoosterCount;
    }

    // Update is called once per frame
    void Update()
    {
       // coinAmountStorage = ScoreTextScript.coinAmount;

        greenBoosterCountStorage = GravitySpeedBooster.greenBoosterCount;
       // blueBoosterCountStorage = FrictionBooster.blueBoosterCount;
       // yellowBoosterCountStorage = SizeSmallerBooster.yellowBoosterCount;


       // Debug.Log("Монеток: " + coinAmountStorage);

        Debug.Log("Зеленых бустеров: " + greenBoosterCountStorage);
       // Debug.Log("Желтых бустеров: " + yellowBoosterCountStorage);
       // Debug.Log("Синих бустеров: " + blueBoosterCountStorage);
    }


}
