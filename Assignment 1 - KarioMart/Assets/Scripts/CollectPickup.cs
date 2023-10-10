using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public class CollectPickup : MonoBehaviour
{
    public AudioSource collectSound;
    [SerializeField] public float speedIncrease = 2000f;
    [SerializeField] public int duration = 2;


    public async void OnTriggerEnter(Collider other)
    {
        collectSound.Play();
        Debug.Log("Pickup has been collected");
        PlayerController speed = other.GetComponent<PlayerController>();

        speed.acceleration += speedIncrease;

        // Removes the visuals of the pickup so that it doesn't stay there for 2s
        GetComponent<MeshRenderer>().enabled = false;
        GetComponent <Collider>().enabled = false;

        // Waits 2 seconds before the powerup wares off from the player
        await Task.Delay(duration);
        speed.acceleration -= speedIncrease;

        if (gameObject == null)
        {
            Destroy(gameObject);
        }
    }
}
