using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinalPanelTrigger : MonoBehaviour
{
    public GameObject finalPanel;

    void Start()
    {
        finalPanel.SetActive(false);

    }

     void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "ActiveZone")
        {
            finalPanel.SetActive(true);
            Debug.Log("collided");
        }
    }
}
