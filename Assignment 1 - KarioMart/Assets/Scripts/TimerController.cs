using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
using TMPro;

public class TimerController : MonoBehaviour

{
    public TextMeshProUGUI timeCounter;

    private TimeSpan timePlaying;
    private bool timerGoing;
    private float elapsedTime;

    private void Start()
    {
        timeCounter.text = "Time: 00:00.00";
        timerGoing = false;
    }

    public void TimerStart()
    {
        timerGoing = true;
        elapsedTime = 0f;

        StartCoroutine(UpdateTimer());
    }

    public void StopTimer()
    {
        timerGoing = false;
    }

    private IEnumerator UpdateTimer()
    {
        while(timerGoing)
        {
            elapsedTime += Time.deltaTime;
            timePlaying = TimeSpan.FromSeconds(elapsedTime);
            string timePlayingStr = "Time:" + timePlaying.ToString("mm':'ss'.'ff");
            timeCounter.text = timePlayingStr;

            yield return null;
        }
    }
}
