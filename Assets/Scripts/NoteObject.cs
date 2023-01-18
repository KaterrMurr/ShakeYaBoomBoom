using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteObject : MonoBehaviour
{
    //������, ������� ����������, ����� �� �� � ������ ������ ������ ����� (��������� �� ��� � �������� ���� � ����� ActiveZone),
    //� ���� �����, �� ���� �� ��� ������? 
    //���� ���� - ��������� ����� ������, ������� �����.
    
    public bool _canBePressed;
    //   public static int _progressAmount; - ���� �������� � GameManager

    // Start is called before the first frame update
    void Start()
    {
       // _progressAmount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "ActiveZone")
        {
            _canBePressed = true;
            Debug.Log("Active Zone!");
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "ActiveZone")
        {
            _canBePressed = false;
            GameManager.instance.NoteMissed();
            Debug.Log("Inactive Zone!");

        }
    }

    void OnMouseDown()
    {
        if (_canBePressed == true)
        {
            GameManager.instance.NoteHit();
         //_progressAmount = _progressAmount + 10; - ���� �������� � GameManager
                // Destroy the gameObject after clicking on it
         Destroy(gameObject);
         Debug.Log("NoteHit");
        }
        
    }
}
