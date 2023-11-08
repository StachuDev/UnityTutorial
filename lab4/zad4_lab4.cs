using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zad4_lab4 : MonoBehaviour
{
    // ruch wokół osi Y będzie wykonywany na obiekcie gracza, więc
    // potrzebna nam referencja do niego (konkretnie jego komponentu Transform)
    public Transform player;


    public float sensitivity = 180f;

    void Start()
    {
        // zablokowanie kursora na środku ekranu, oraz ukrycie kursora
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {

        // float moveY = Mathf.Clamp(Input.GetAxis("Mouse Y"), 0.5f, 0.9f);
        // pobieramy wartości dla obu osi ruchu myszy
        float mouseXMove = Input.GetAxis("Mouse X") * sensitivity * Time.deltaTime;
        float mouseYMove = Input.GetAxis("Mouse Y") * sensitivity * Time.deltaTime;

        // Debug.Log("mouseYMove: " + mouseYMove);
        // Debug.Log("Input.GetAxis(Mouse Y): " + Input.GetAxis("Mouse Y"));

        // wykonujemy rotację wokół osi Y
        player.Rotate(Vector3.up * mouseXMove);

        // transform.Rotate(new Vector3(-mouseYMove, 0f, 0f), Space.Self);

        Debug.Log(gameObject.transform.rotation.eulerAngles.x);

        if (gameObject.transform.rotation.eulerAngles.x <= 90 && gameObject.transform.rotation.eulerAngles.x >= 0)
        {
            // a dla osi X obracamy kamerę dla lokalnych koordynatów
            // -mouseYMove aby uniknąć ofektu mouse inverse
            transform.Rotate(new Vector3(-mouseYMove, 0f, 0f), Space.Self);
        }

        if (gameObject.transform.rotation.eulerAngles.x <= 360 && gameObject.transform.rotation.eulerAngles.x >= 270)
        {
            // a dla osi X obracamy kamerę dla lokalnych koordynatów
            // -mouseYMove aby uniknąć ofektu mouse inverse
            transform.Rotate(new Vector3(-mouseYMove, 0f, 0f), Space.Self);
        }
    }
}
