using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class FinishLine : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player1" && other.GetComponent<PlayerController>().checkpoints.Count >=6)
        {
            other.GetComponent<PlayerController>().FinishedLap();
        } 
    }

}
