using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GSBooster : MonoBehaviour
{
    //������ ���� ������ ������ ������� ��������������� �� ����
    
    public Button button;
    public Rigidbody player;

    public GameObject glitter;
    public GameObject greenBoosterGlitter;
    public GameObject GCounter;
   
    //���� ������ �� ��� �������, � �������� ��������

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
        Debug.Log("���-�� � �����������: " + Physics.gravity);
        player.drag = 1.8f;
        Debug.Log("���-�� � ������: " + player.drag);
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
        Debug.Log("������ �����������: " + GravitySpeedBooster.greenBoosterCount);
        button.image.enabled = false;
        Destroy(GCounter);
        button.GetComponentInChildren<Text>().enabled = false;

        

        yield return new WaitForSeconds(5);                             //��� 5 ������

        Physics.gravity = new Vector3(0, -45F, 0);                      //���������� ����������
        Debug.Log("���������� �������������: " + Physics.gravity);
        player.drag = 2.65f;                                            //���������� ����
        Debug.Log("���� ������������: " + player.drag);
        button.gameObject.SetActive(false);

        
    }



}
