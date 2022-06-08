using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WordsPerMinute : MonoBehaviour
{
    public Text wordsPerMinute;
    
    private float wordRate;
    private float wordRatePerMinute;
    private float timePassed;

    private void Update()
    {
       WPM();
    }

    private void WPM()
    {
        wordRate = GameObject.Find("WordBank").GetComponent<WordBank>().wordsCompleted;
        wordRatePerMinute = (wordRate -1) / timePassed * 60;
        timePassed += Time.deltaTime;

        wordsPerMinute.text = "WPM: " + wordRatePerMinute.ToString("000");
    }
}
