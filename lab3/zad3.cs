using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zad3 : MonoBehaviour
{

    public float speed = 5.0f;
    private Vector3 firstPosition;

    void Start()
    {
        firstPosition = transform.position;
    }


    void Update()
    {
        if (Vector3.Distance(firstPosition, transform.position) >= 10)
        {
            firstPosition = transform.position;
            transform.Rotate(0, 90, 0);
        }
        transform.Translate(Vector3.right * speed * Time.deltaTime);
    }




    // public float speed = 1.0f;
    // public float distanceMoved = 0.0f;
    // public Vector3 direction = new Vector3(1, 0, 0);

    // private int indexOfRotation = 0;
    // // (1,0,0) right
    // // (0,0,-1) back
    // // (-1,0,0) left
    // // (0,0,1) forward


    // void Start()
    // {
    //     // transform.eulerAngles = new Vector3(0, 45, 0);
    // }

    // public float rotationSpeed = 1.0f;  // Speed of rotation
    // // public Vector3 targetRotationAngles = new Vector3(90, 0, 0);  // Target rotation angles



    // // called once per frame
    // void Update()
    // {
    //     // wyliczam odleglosc do przebycia
    //     float distanceToMove;

    //     Quaternion targetRotation = Quaternion.Euler(new Vector3(0, 90, 0));


    //     if (distanceMoved >= 10.0f)
    //     {
    //         if (indexOfRotation >= 4)
    //         {
    //             indexOfRotation = 0;
    //         }

    //         // transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, Time.deltaTime * rotationSpeed);

    //         distanceMoved = 0.0f;

    //         // direction = indexOfRotation switch
    //         // {
    //         //     1 => Vector3.back,
    //         //     2 => Vector3.left,
    //         //     3 => Vector3.forward,
    //         //     _ => Vector3.right,
    //         // };
    //         indexOfRotation += 1;

    //     }
    //     else
    //     {
    //         // wyliczam odleglosc do przebycia
    //         distanceToMove = speed * Time.deltaTime;

    //         // dodaję tą odleglosc do przebytch
    //         distanceMoved += distanceToMove;
    //         switch (indexOfRotation)
    //         {
    //             case 0:
    //                 transform.Translate(Vector3.right * distanceToMove);
    //                 break;
    //             case 1:
    //                 transform.Translate(Vector3.back * distanceToMove);
    //                 break;
    //             case 2:
    //                 transform.Translate(Vector3.left * distanceToMove);
    //                 break;
    //             case 3:
    //                 transform.Translate(Vector3.forward * distanceToMove);
    //                 break;
    //         }

    //     }


    // }


    // void 
}
