using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GSBooster : MonoBehaviour
{
    //скрипт всей логики работы бустера непосредственно на поле
    
    public Button button;
    public Rigidbody player;

    public GameObject glitter;
    public GameObject greenBoosterGlitter;
    public GameObject GCounter;
   
    //дали ссылки на все объекты, с которыми работаем

    public void Start()
    {
        button.GetComponent<Button>().onClick.AddListener(ChangeGravity);
        player.GetComponent<Rigidbody>();
        GBoosterTextScript.boostAmount = GBoosterTextScript.boostAmount;

    }

    void Update()
    {

    }
    public void ChangeGravity()
    {
        Physics.gravity = new Vector3(0, -30F, 0);
        Debug.Log("Что-то с гравитацией: " + Physics.gravity);
        player.drag = 1.8f;
        Debug.Log("Что-то с драгом: " + player.drag);
        StartCoroutine(OnThisButtonClicked());
    }

    public IEnumerator OnThisButtonClicked()
    {
        glitter.SetActive(false);
        greenBoosterGlitter.SetActive(true);
        yield return new WaitForSeconds(4f);
        glitter.SetActive(true);
        greenBoosterGlitter.SetActive(false);

        GravitySpeedBooster.greenBoosterCount = GravitySpeedBooster.greenBoosterCount - 1;
        GBoosterTextScript.boostAmount = GBoosterTextScript.boostAmount - 1;
        if (GravitySpeedBooster.greenBoosterCount <= 0)
        {
            GravitySpeedBooster.greenBoosterCount = 0;
        }
        DataStorageScript.greenBoosterCountStorage = GravitySpeedBooster.greenBoosterCount;
        Debug.Log("Бустер использован: " + GravitySpeedBooster.greenBoosterCount);
        button.image.enabled = false;
        Destroy(GCounter);
        button.GetComponentInChildren<Text>().enabled = false;

        

        yield return new WaitForSeconds(5);                             //ждём 5 секунд

        Physics.gravity = new Vector3(0, -45F, 0);                      //возвращаем гравитацию
        Debug.Log("Гравитация восстановлена: " + Physics.gravity);
        player.drag = 2.65f;                                            //возвращаем драг
        Debug.Log("Драг восстановлен: " + player.drag);
        button.gameObject.SetActive(false);

        
    }



}
