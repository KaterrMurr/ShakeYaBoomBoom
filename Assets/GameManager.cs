using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public AudioSource theMusic;
    public bool startPlaying;
    public BeatScroller theBS;

    public IEnumerator coroutine;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (!startPlaying)
        {
            if (Input.anyKeyDown)
            {
                startPlaying = true;
                theBS._hasStarted = true;
                coroutine = WaitAndStartPlaying(5.0f);
                StartCoroutine(coroutine);
                Debug.Log("Корутина в условии пошла");
                
            }
        }
    }

    public IEnumerator WaitAndStartPlaying(float waitTime)
    {
        yield return new WaitForSeconds(5.0f);
        theMusic.Play();
        Debug.Log("Музыка пошла");
    }
}
