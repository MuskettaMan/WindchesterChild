using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Anims : MonoBehaviour {

    public enum AnimState {
        IdleFront,
        IdleBack,
        IdleLeft,
        IdleRight,
        WalkFront,
        WalkBack,
        WalkLeft,
        WalkRight
    }

    private Animator animator;

    private void Start() {
        animator = GetComponent<Animator>();
    }

    private void Update() {

        if(Input.GetKey(KeyCode.W)) {
            ChangeAnimationState(AnimState.WalkFront);
        } else if(Input.GetKey(KeyCode.S)) {
            ChangeAnimationState(AnimState.WalkBack);
        } else if(Input.GetKey(KeyCode.A)) {
            ChangeAnimationState(AnimState.WalkLeft);
        } else if(Input.GetKey(KeyCode.D)) {
            ChangeAnimationState(AnimState.WalkRight);
        }

        if(Input.GetKeyUp(KeyCode.W)) {
            ChangeAnimationState(AnimState.IdleFront);
        } else if(Input.GetKeyUp(KeyCode.S)) {
            ChangeAnimationState(AnimState.IdleBack);
        } else if(Input.GetKeyUp(KeyCode.A)) {
            ChangeAnimationState(AnimState.IdleLeft);
        } else if(Input.GetKeyUp(KeyCode.D)) {
            ChangeAnimationState(AnimState.IdleRight);
        }

    }

    private void ChangeAnimationState(AnimState state) {
        animator.SetInteger("AnimState", (int)state);
    }

}
