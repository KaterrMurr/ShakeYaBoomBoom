using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GravitySpeedBooster : MonoBehaviour
{
   //логика работы кнопки бустера на уровне: если бустер собран - кол-во +1, кнопку можно нажать, +1 идет в storage
    public GameObject gravitySpeedBooster;
    bool boosterIsCollected = false;
    public static float greenBoosterCount = 0;
    public Button thisBoosterButton;
    
    
    // Start is called before the first frame update
    void Start()
    {
        thisBoosterButton.gameObject.SetActive(false);
      
        greenBoosterCount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            
            boosterIsCollected = true;
            greenBoosterCount = greenBoosterCount + 1;
            DataStorageScript.greenBoosterCountStorage = greenBoosterCount;
            Debug.Log("Получен бустер: " + greenBoosterCount);                
            thisBoosterButton.gameObject.SetActive(true);
            DestroyBooster();//удаляем объект со сцены
        }  
    }

    public void DestroyBooster()
    {
       Destroy(gameObject);
       
    }

}
