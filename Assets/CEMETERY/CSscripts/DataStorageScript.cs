using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataStorageScript : MonoBehaviour
{
    //������� ���������� ������ � ���-�� �������� � ������� ������ ����

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


       // Debug.Log("�������: " + coinAmountStorage);

        Debug.Log("������� ��������: " + greenBoosterCountStorage);
       // Debug.Log("������ ��������: " + yellowBoosterCountStorage);
       // Debug.Log("����� ��������: " + blueBoosterCountStorage);
    }


}
