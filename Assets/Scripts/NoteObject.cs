using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteObject : MonoBehaviour
{
    //Скрипт, который определяет, можем ли мы в данный момент нажать нотку (находится ли она в активной зоне с тегом ActiveZone),
    //и если можем, то была ли она нажата? 
    //Если была - добавляем очков игроку, удаляем нотку.
    
    public bool _canBePressed;
    public static int _progressAmount;

    // Start is called before the first frame update
    void Start()
    {
        _progressAmount = 0;
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
            GameManager.instance.NoteMissed();
        }
    }

    void OnMouseDown()
    {
        if (_canBePressed == true)
        {
            GameManager.instance.NoteHit();
         _progressAmount = _progressAmount + 10;
                // Destroy the gameObject after clicking on it
         Destroy(gameObject);
         Debug.Log("NoteHit, progress:" + _progressAmount);
        }
        
    }
}
