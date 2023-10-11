using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public float acceleration = 8000;
    [SerializeField] float turnSpeed = 50;
    public List<Checkpoints> checkpoints = new List<Checkpoints>();
    public int laps = 0;

    Quaternion targetRotation;
    new Rigidbody rigidbody;

    Vector3 lastposition;
    float sideSlipAmount;

    [SerializeField] TrackCheckpoints trackCheckpoints;

    public void EnteredCheckpoint(Checkpoints checkpoint)
    {
        if(checkpoints.Contains(checkpoint))
        { return; }
        checkpoints.Add(checkpoint);
    }

    public void FinishedLap()
    {
        laps++;
        if(laps >= 3)
        {
            SceneManager.LoadScene(1);
        }
        else
        {
            checkpoints.Clear();
        }
    }
    public float SideSlipAmount
    {
        get
        {
            return sideSlipAmount;
        }
    }

    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    {

        SetRotationPoint();
        SetSideSlip();

    }

    //Created this function to make the car follow the position of the mouse
    private void SetRotationPoint()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        Plane plane = new Plane(Vector3.up, Vector3.zero);
        float distance;
        if(plane.Raycast(ray, out distance))
        {
            Vector3 target = ray.GetPoint(distance);
            Vector3 direction = target - transform.position;
            float rotationAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg;
            targetRotation = Quaternion.Euler(0, rotationAngle, 0);

        }
    }

    //I created this side slip to reduce the cars "lag", because it was lagging back while accelerating
    private void SetSideSlip()
    {
        Vector3 direction = transform.position - lastposition;
        Vector3 movement = transform.InverseTransformDirection(direction);
        lastposition = transform.position;

        sideSlipAmount = movement.x;
    }

    //Creating a function to make the car accelarate when the Mouse button input is used
    private void FixedUpdate()
    {
        float speed = rigidbody.velocity.magnitude / 1000;

        float accelerationInput = acceleration *(Input.GetMouseButton(0) ? 1 : Input.GetMouseButton(1) ? -1 : 0) * Time.deltaTime;
        rigidbody.AddRelativeForce(Vector3.forward * accelerationInput);
        transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, turnSpeed * Mathf.Clamp(speed, -1, 1));
        
    }

    public int GetLaps()
    {
        return laps;
    }

}
