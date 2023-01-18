using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MultiplierTextPopUp : MonoBehaviour
{
    public MeshRenderer multiplierText;
    private Animation multiplierAnimation;
    public IEnumerator coroutine;


    // Start is called before the first frame update
    void Start()
    {
        multiplierText = GetComponent<MeshRenderer>();
        multiplierText.enabled = false;
        multiplierAnimation = GetComponent<Animation>();
        coroutine = PlayAndDieAgain(1.5f);

    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.currentMultiplier == 2)
        {
            PlayAndDieAgain(1.5f);
        }
    }

    public IEnumerator PlayAndDieAgain(float waitTime)
    {
        multiplierText.enabled = true;
        multiplierAnimation.Play();
        yield return new WaitForSeconds(1.5f);
        multiplierText.enabled = false;
        Debug.Log("Множитель мелькнул");
    }
}
