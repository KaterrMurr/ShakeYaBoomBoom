using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startingsettings : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        BoosterCollider.colliderBoosterReceived = false;
        BoosterMultiplier.multiplierBoosterReceived = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
