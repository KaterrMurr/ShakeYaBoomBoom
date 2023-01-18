using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cheats : MonoBehaviour
{
    public void AddExp()
    {
        ProgressStorage._progressAmountStorage = ProgressStorage._progressAmountStorage + 5000;
        Debug.Log("Added 5K exp.");
    }

}
