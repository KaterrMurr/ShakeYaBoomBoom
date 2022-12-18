using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteObject : MonoBehaviour
{
    //������, ������� ����������, ����� �� �� � ������ ������ ������ ����� (��������� �� ��� � �������� ���� � ����� ActiveZone),
    //� ���� �����, �� ���� �� ��� ������? 
    //���� ���� - ��������� ����� ������.
    
    private bool _canBePressed;
    
    // Start is called before the first frame update
    void Start()
    {
        
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
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "ActiveZone")
        {
            _canBePressed = false;
        }
    }
}
