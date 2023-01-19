using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
        coroutine = PlayAndDieAgain(0.2f);

    }

    // Update is called once per frame
    void Update()
    {

        if (GameManager.currentMultiplier == 2 && GameManager.noteHit == true)  //если в гейм менеджере переменная noteHit = true && GameManager.currentMultiplier = 2
        {
            StartCoroutine(PlayAndDieAgain(0.2f));
        }
    }

    public IEnumerator PlayAndDieAgain(float waitTime)
    {
        multiplierText.enabled = true;
        multiplierAnimation.Play();
        yield return new WaitForSeconds(0.2f);
        multiplierText.enabled = false;
        Debug.Log("Множитель мелькнул");
    }
}
