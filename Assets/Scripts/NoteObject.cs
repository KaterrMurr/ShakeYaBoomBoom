using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteObject : MonoBehaviour
{
    //Скрипт, который определяет, можем ли мы в данный момент нажать нотку (находится ли она в активной зоне с тегом ActiveZone),
    //и если можем, то была ли она нажата? 
    //Если была - добавляем очков игроку.
    
    public bool _canBePressed;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if ((Input.touchCount > 0) && (Input.GetTouch(0).phase == TouchPhase.Began))
        {
            Ray raycast = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit raycastHit;
            if (Physics.Raycast(raycast, out raycastHit))
            {
                Debug.Log("Something Hit");
               
                if (raycastHit.collider.CompareTag("Note"))
                {
                    Debug.Log("Note hit");
                }
            }
        }
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
