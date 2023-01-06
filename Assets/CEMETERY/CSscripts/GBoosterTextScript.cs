using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GBoosterTextScript : MonoBehaviour
{
    //отображение кол-ва бустеров в тексте на кнопке
    Text text;
    public static int boostAmount;

    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        text.text = DataStorageScript.greenBoosterCountStorage.ToString();
        
    }

}
