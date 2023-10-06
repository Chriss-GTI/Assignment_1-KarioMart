using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoints : MonoBehaviour
{
    public Transform Spawnpoint;
    public GameObject Prefab;

    private void OnTriggerEnter(Collider other)

    {
        if(other.TryGetComponent<PlayerController>(out PlayerController player))
        {
            other.GetComponent<PlayerController>().EnteredCheckpoint(this);
            Debug.Log("Checkpoint");
        }

        Instantiate(Prefab, Spawnpoint.position, Spawnpoint.rotation);
    }

   

 
}
