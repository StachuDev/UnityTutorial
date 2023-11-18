using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ex6 : MonoBehaviour
{
    private void OnTriggerEnter (Collider other)
    {
        if (other.gameObject.CompareTag("Player")){
            Debug.Log("Gracz sie zblizyl");
        }
    }

    private void OnTriggerExit (Collider other) {
        if (other.gameObject.CompareTag("Player")){
            Debug.Log("Gracz sie odszedł");
        }
    }
}
