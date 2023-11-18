using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// public class ex5 : MonoBehaviour
// {   
//     private CharacterController character;
//     private bool exploded = false;
//     private float jumpForce = 21f;
//     void Start()
//     {
//         character = GameObject.FindWithTag("Player").GetComponent<CharacterController>();
//     }


//     void Update() {
//         if(exploded){
//             character.Move(Vector3.up * jumpForce * Time.deltaTime);
//         }
//     }

//     private void OnTriggerEnter (Collider other)
//     {
//         if (other.gameObject.CompareTag("Player")){
//             exploded = true;
//             Debug.Log("Gracz sie zblizyl");
//         }
//     }

//     private void OnTriggerExit (Collider other) {
//         if (other.gameObject.CompareTag("Player")){
//             Debug.Log("Gracz sie odszedł");
//         }
//     }
// }

public class ex5 : MonoBehaviour
{
   public float jumpForce = 21.0f;
   private CharacterController playerController;

   void Start()
   {
       // Get the player's CharacterController component
       playerController = GameObject.FindWithTag("Player").GetComponent<CharacterController>();
   }

   void OnTriggerEnter(Collider other)
   {
       // Check if the box collided with the player
       if (other.gameObject.tag == "Player")
       {
           // Make the player jump
           playerController.Move(Vector3.up * jumpForce);
       }
   }
}
