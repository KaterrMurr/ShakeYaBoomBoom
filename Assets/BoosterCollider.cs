using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoosterCollider : MonoBehaviour
{
    public static bool colliderBoosterReceived;
    public static bool multiplierBoosterReceived;

    //public Transform noteTransform;

    void Start()
    {
       
    }

    public void BoosterReceived()
    {
        colliderBoosterReceived = true;

        multiplierBoosterReceived = false;
        Debug.Log("Бустер коллайдера получен");

    }

   
}
