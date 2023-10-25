using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class zad2 : MonoBehaviour
{
    public float speed = 1.0f;
    public float distanceMoved = 0.0f;
    public int direction = 1;

    void Start()
    {
        // transform.eulerAngles = new Vector3(0, 45, 0);
    }


    // called once per frame
    void Update()
    {
        // wyliczam odleglosc do przebycia
        float distanceToMove = speed * Time.deltaTime;

        // dodaję tą odleglosc do przebytch
        distanceMoved += distanceToMove;

        if (distanceMoved >= 10.0f)
        {
            direction *= -1;
            distanceMoved = 0.0f;
        }

        transform.Translate(Vector3.right * distanceToMove * direction);
    }
}
