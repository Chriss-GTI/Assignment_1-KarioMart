using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LapTextController : MonoBehaviour
{
    public TextMeshProUGUI lapCounter;
    PlayerController playerController;

    private void Awake()
    {
        playerController = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    public void Update()
    {
        
        lapCounter.text = "Laps Completed:" +  playerController.GetLaps().ToString()+"/3";
    }
}
