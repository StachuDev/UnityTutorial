using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zad6 : MonoBehaviour
{
    // Smooth towards the height of the target

    public Transform target;
    public float smoothTime = 0.3f;
    public float yVelocity = 0.0f;

    void Update()
    {
        float newPosition = Mathf.SmoothDamp(transform.position.y, target.position.y, ref yVelocity, smoothTime);
        transform.position = new Vector3(transform.position.x, newPosition, transform.position.z);
    }
}
