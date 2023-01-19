using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public AudioSource theMusic;
    public bool startPlaying;
    public BeatScroller theBS;

    public Countdown countdown;

    public IEnumerator coroutine;
    public IEnumerator waitAfterHitNote;

    public static GameManager instance;

    public static int currentScore;
    public static int scorePerNote = 10;

    public static int currentMultiplier;
    public static int multiplierTracker;
    public int[] multiplierThresholds;

    public static bool noteHit;

    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        currentMultiplier = 1;
        waitAfterHitNote = WaitAfterHitNote(0.2f);
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
                countdown.gameObject.SetActive(true);
                coroutine = WaitAndStartPlaying(3.0f);
                StartCoroutine(coroutine);
                Debug.Log("Корутина в условии пошла");                
            }
        }
    }

    public IEnumerator WaitAndStartPlaying(float waitTime)
    {
        yield return new WaitForSeconds(3.0f);
        countdown.gameObject.SetActive(false);
        theMusic.Play();
        Debug.Log("Музыка пошла");
    }

    public void NoteHit()
    {
        Debug.Log("Note hit on time");
        noteHit = true;

        if (currentMultiplier - 1 < multiplierThresholds.Length)
        {
            multiplierTracker++;
            if (multiplierThresholds[currentMultiplier - 1] <= multiplierTracker)
            {
                multiplierTracker = 0;
                currentMultiplier++;
                Debug.Log("Current Multiplier" + currentMultiplier);
            }
        }
        
        currentScore += scorePerNote * currentMultiplier;
        StartCoroutine(waitAfterHitNote);

    }

    public IEnumerator WaitAfterHitNote(float waitTime)
    {
        yield return new WaitForSeconds(0.2f);
        noteHit = false;

    }


    public void NoteMissed()
    {
        Debug.Log("Note missed");
    }

}
