using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class TrackCheckpoints : MonoBehaviour
{
    Transform checkpointsTransform;
    private void Awake()
    {
        checkpointsTransform = transform.Find("Checkpoints");
    }
}
    
