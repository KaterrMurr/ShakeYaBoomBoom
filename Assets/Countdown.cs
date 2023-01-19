using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class Countdown : MonoBehaviour
{
   /*public GameObject thisCooldown;
    public Animation countdownAnimation;

    public IEnumerator countdownCoroutine;

    private TextMeshProUGUI countDownUI;
    public int number = 3;

    // Start is called before the first frame update
    void Start()
    {
        countDownUI = GetComponent<TextMeshProUGUI>();
        countdownCoroutine = CountdownCorutine(1.0f);

        if (thisCooldown.activeSelf)
        {
            StartCoroutine(countdownCoroutine);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public IEnumerator CountdownCorutine(float waitTime)
    {
        yield return new WaitForSeconds(0.0f);
        countDownUI.SetText("3"); 
        countdownAnimation.Play();
        yield return new WaitForSeconds(1.0f);
        countdownAnimation.Stop();
        number = number -1;
        countDownUI.text = number.ToString();
        countdownAnimation.Play();
        yield return new WaitForSeconds(1.0f);
        countdownAnimation.Stop();
        number = 1;
        countDownUI.text = number.ToString();
        countdownAnimation.Play();
        yield return new WaitForSeconds(1.0f);
        countdownAnimation.Stop();
        countDownUI.text = "GO!";
        countdownAnimation.Play();
        yield return new WaitForSeconds(1.0f);
        countdownAnimation.Stop();
        Destroy(gameObject);
    }
   */

}
