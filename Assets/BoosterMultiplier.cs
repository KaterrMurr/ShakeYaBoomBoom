using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoosterMultiplier : MonoBehaviour
{
    public static bool colliderBoosterReceived;
    public static bool multiplierBoosterReceived;

    //public Transform noteTransform;

    public void BoosterReceived()
    {
        multiplierBoosterReceived = true;

        colliderBoosterReceived = false;
        Debug.Log("Бустер множителя получен");

    }



}
