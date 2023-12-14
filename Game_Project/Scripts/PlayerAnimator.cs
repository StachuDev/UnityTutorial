using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimator : MonoBehaviour
{

    private const string IS_WALKING = "IsMoving";
    private const string IS_JUMPING = "IsJumping";

    [SerializeField] private Player player;
    private Animator animator;
    private void Awake(){
        animator = GetComponent<Animator>();
    }

    private void Update(){
        // Debug.Log(IS_WALKING + player.IsWalking());
        // Debug.Log(IS_JUMPING + player.IsJumping());
        animator.SetBool(IS_WALKING, player.IsWalking());
        animator.SetBool(IS_JUMPING, player.IsJumping());
    }
}
