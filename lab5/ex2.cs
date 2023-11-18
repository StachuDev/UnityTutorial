using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LiftMove : MonoBehaviour
{
    public float elevatorSpeed = 2f;
    private bool isRunning = false;
    public float distance = 8f;
    private bool isRunningUp = true;
    private bool isRunningDown = false;
    private float downPosition;
    private float upPosition;

    void Start()
    {
        upPosition = transform.position.z + distance;
        downPosition = transform.position.z;
    }

    void Update()
    {
        if (isRunningUp && transform.position.z >= upPosition)
        {
            isRunning = false;
        }
        else if (isRunningDown && transform.position.z <= downPosition)
        {
            isRunning = false;
        }

        if (isRunning)
        {
            Vector3 move = transform.forward * elevatorSpeed * Time.deltaTime;
            transform.Translate(move);
        }
    }

    private void OnTriggerEnter (Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Player wszedł na windę.");
           other.transform.parent = transform;
            if (transform.position.z >= upPosition)
            {
                isRunningDown = true;
                isRunningUp = false;
                elevatorSpeed = -elevatorSpeed;
            }
            else if (transform.position.z <= downPosition)
            {
                isRunningUp = true;
                isRunningDown = false;
                elevatorSpeed = Mathf.Abs(elevatorSpeed);
            }
            isRunning = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.transform.parent = null;
            Debug.Log("Player zszedł z windy.");
        }
    }
}